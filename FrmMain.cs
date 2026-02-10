using SharpDX.DirectInput;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESA_WiFi_Arduino_Car
{
    public partial class FrmMain : Form
    {
        private bool _controlEnabled = false;
        private bool _serverEnabled = false;
        private bool _joystickFetchEnabled = false;
        private bool _carConnected = false;

        private Joystick joystick;
        private DirectInput directInput;
        private UdpListener listener;
        private UdpClient client;
        private IPEndPoint carEndPoint;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void QueryControllers()
        {
            _joystickFetchEnabled = false;

            cbController.DataSource = directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices)
                .Select(d => d.InstanceGuid
                .ToString()
                .Replace("-", "") + $"  /  \"{d.InstanceName}\"")
                .ToList();

            if(!string.IsNullOrEmpty(cbController.Text))
            {
                StartJoystickFetch();
            }
        }

        private void StartJoystickFetch()
        {
            _joystickFetchEnabled = true;

            if(Guid.TryParse(cbController.Text.Substring(0, 32), out Guid joystickGuid))
            {
                joystick = new Joystick(directInput, joystickGuid);
                joystick.Acquire();

                Task.Factory.StartNew(async () =>
                {
                    while(_joystickFetchEnabled)
                    {
                        joystick.Poll();
                        try
                        {
                            var data = joystick.GetCurrentState();
                            var throttle = (int)((data.Z-32767)*-1*0.03137);
                            var left = 0;
                            var right = 0;

                            if(data.X > 32895)
                            {
                                left = 0;
                                right = (int)((data.X - 32895)*0.03137);
                            }
                            else
                            {
                                left = (int)((32895 - data.X)*0.03112);
                                right = 0;
                            }

                            Invoke(new Action(() =>
                            {
                                if(throttle > 0)
                                {
                                    pbThrottle.Value = throttle;
                                    pbReverse.Value = 0;
                                }
                                else
                                {
                                    pbThrottle.Value = 0;
                                    pbReverse.Value = throttle * -1;
                                }

                                pbLeft.Value = left;
                                pbRight.Value = right;
                            }));

                            if(_carConnected && _controlEnabled)
                            {
                                if(throttle > 15)
                                {
                                    listener.Reply($"M{throttle - left},{throttle - right}", carEndPoint);
                                }
                                else if(throttle < -15)
                                {
                                    listener.Reply($"M{throttle + left},{throttle + right}", carEndPoint);
                                }
                                else
                                {
                                    listener.Reply($"M{throttle - left},{throttle - right}", carEndPoint);
                                }
                                
                            }
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        await Task.Delay(10);
                    }
                });
            }
        }

        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "n/a";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;
        }

        private void GetOwnIP()
        {
            lblIp.Text = GetLocalIPv4(NetworkInterfaceType.Wireless80211);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            directInput = new DirectInput();
            listener = new UdpListener();
            _serverEnabled = true;

            Task.Factory.StartNew(async () =>
            {
                while(_serverEnabled)
                {
                    var received = await listener.Receive();
                    if(received.Message == "!")
                    {
                        _carConnected = true;

                        Invoke(new Action(() =>
                        {
                            lblCarStatus.Text = "Car connected";
                            lblCarStatus.BackColor = Color.GreenYellow;
                            btnConnectCar.Text = "Disconnect";
                            gbLED.Enabled = true;
                            gbMotor.Enabled = true;
                            gbCarControlling.Enabled = true;
                        }));
                    }
                }
            });

            QueryControllers();
            GetOwnIP();
        }

        private void TbtnRainbowMode_CheckedChanged(object sender, EventArgs e)
        {
            tbRed.Enabled = !tbtnRainbowMode.Checked;
            tbGreen.Enabled = !tbtnRainbowMode.Checked;
            tbBlue.Enabled = !tbtnRainbowMode.Checked;
            
            if(tbtnRainbowMode.Checked)
            {
                pbColor.BackColor = SystemColors.Control;
                listener.Reply("C", carEndPoint);
            }
            else
            {
                ColorSlider_Scroll(null, EventArgs.Empty);
            }
        }

        private void BtnEnableControl_Click(object sender, EventArgs e)
        {
            _controlEnabled = !_controlEnabled;

            btnEnableControl.Text = _controlEnabled ? "Disable" : "Enable";
            tbLeftMotor.Enabled = !_controlEnabled;
            tbRightMotor.Enabled = !_controlEnabled;

            if(_controlEnabled)
            {
                tbLeftMotor.Value = 0;
                tbRightMotor.Value = 0;
            }
        }

        private void BtnQueryControllers_Click(object sender, EventArgs e)
        {
            QueryControllers();
        }

        private void ColorSlider_Scroll(object sender, EventArgs e)
        {
            pbColor.BackColor = Color.FromArgb((int)(tbRed.Value*0.248), (int)(tbGreen.Value*0.248), (int)(tbBlue.Value*0.248));
            listener.Reply($"L{tbRed.Value},{tbGreen.Value},{tbBlue.Value}", carEndPoint);
        }

        private void BtnToggleServer_Click(object sender, EventArgs e)
        {
            _serverEnabled = !_serverEnabled;

            btnToggleServer.Text = _serverEnabled ? "Stop Listener" : "Start Listener";
            lblServerStatus.Text = _serverEnabled ? "Server enabled" : "Server disabled";
            lblServerStatus.BackColor = _serverEnabled ? Color.GreenYellow : Color.LightSalmon;
            txtCarIp.Enabled = _serverEnabled;
            txtCarPort.Enabled = _serverEnabled;
            btnConnectCar.Enabled = _serverEnabled;

            if(_serverEnabled)
            {
                GetOwnIP();
            }
            else
            {
                lblIp.Text = "n/a";
                if(_carConnected)
                {
                    BtnConnectCar_Click(null, EventArgs.Empty);
                }
            }
        }

        private void CbController_TextChanged(object sender, EventArgs e)
        {
            var selected = !string.IsNullOrWhiteSpace(cbController.Text);

            pbThrottle.Enabled = selected;
            pbReverse.Enabled = selected;
            pbLeft.Enabled = selected;
            pbRight.Enabled = selected;
        }

        private void BtnConnectCar_Click(object sender, EventArgs e)
        {
            if(!_carConnected)
            {
                var validated = false;

                if(IPAddress.TryParse(txtCarIp.Text, out IPAddress carIp))
                {
                    if(int.TryParse(txtCarPort.Text, out int carPort))
                    {
                        validated = true;
                        carEndPoint = new IPEndPoint(carIp, carPort);

                        listener.Reply("P", carEndPoint);
                    }
                }

                if(!validated)
                {
                    MessageBox.Show("IP Address or port incorrectly set! Please check the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                _carConnected = false;

                lblCarStatus.Text = "Car disconnected";
                lblCarStatus.BackColor = Color.LightSalmon;
                btnConnectCar.Text = "Connect";
                gbLED.Enabled = false;
                gbMotor.Enabled = false;
                gbCarControlling.Enabled = false;
            }
        }

        private void Motors_Scroll(object sender, EventArgs e)
        {
            listener.Reply($"M{tbLeftMotor.Value},{tbRightMotor.Value}", carEndPoint);
        }
    }
}
