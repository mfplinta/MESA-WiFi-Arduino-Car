#include <ESP8266WiFi.h>
#include <WiFiClient.h>
#include <ESP8266WebServer.h>

/* CHS Mesa - Arduino Car WiFi powered
 * Programmed and engineered by:
 * Matheus Plinta
 * 
 * (Program adapted to NodeMCU)
 * 17/May/2019
 */

#define RGB_R       12
#define RGB_G       13
#define RGB_B       15

#define MOTOR_L_PWM 16    // 16
#define MOTOR_R_PWM 5     // 5
#define MOTOR_L_FWD 4     // 4
#define MOTOR_L_BWD 0     // 0
#define MOTOR_R_FWD 2     // 2
#define MOTOR_R_BWD 14    // 14

const char *ssid = "Arduino Car";
const char *password = "colt1234";

ESP8266WebServer server(80);

void handleRoot() {
  server.send(200, "text/html", "<!DOCTYPE html><html><body><h1>Arduino Car Web Server</h1><p><a href=\"/forward\"><button class=\"button\">FORWARD</button></a></p><a href=\"/backwards\"><button class=\"button\">BACKWARDS</button></a></p><a href=\"/left\"><button class=\"button\">LEFT</button></a></p><a href=\"/right\"><button class=\"button\">RIGHT</button></a></p>");
}
void handleForward() {
  drive(1000, 0);
  handleRoot();
}

void handleBackwards() {
  drive(1000, 0);
  handleRoot();
}

void handleLeft() {
  drive(1000, -1000);
  handleRoot();
}

void handleRight() {
  drive(1000, 1000);
  handleRoot();
}

/* Drive the car wheels.
 *  Speed: -1023/1023
 *  Speed diferential: -1023/1023
 *  (- Steer left / + Steer right)
 */
void drive(int speed, int speedDiferential) {
  int pin_left = MOTOR_L_FWD;
  int negative_pin_left = MOTOR_L_BWD;
  int pin_right = MOTOR_R_FWD;
  int negative_pin_right = MOTOR_R_BWD;
  int speed_left = speed;
  int speed_right = speed;

  if(speedDiferential < 0) {
    speed_left -= abs(speedDiferential);
  }
  else if(speedDiferential > 0) {
    speed_right -= abs(speedDiferential);
  }
  if(speed_left < 0) {
    pin_left = MOTOR_L_BWD;
    negative_pin_left = MOTOR_L_FWD;
  }
  if(speed_right < 0) {
    pin_right = MOTOR_L_BWD;
    negative_pin_right = MOTOR_R_FWD;
  }
  
  digitalWrite(pin_left, 1);
  digitalWrite(negative_pin_left, 0);
  digitalWrite(pin_right, 1);
  digitalWrite(negative_pin_right, 0);
  /*if(speed != 0) {
    digitalWrite(MOTOR_L_PWM, 1);
    digitalWrite(MOTOR_R_PWM, 1);
  }
  else {
    digitalWrite(MOTOR_L_PWM, 0);
    digitalWrite(MOTOR_R_PWM, 0);
  }*/
  analogWrite(MOTOR_L_PWM, abs(speed_left));
  analogWrite(MOTOR_R_PWM, abs(speed_right));
}

/* Sets the cor of the RGB LED
 */
void setRGBColor(int red, int green, int blue)
{
  analogWrite(RGB_R, red);
  analogWrite(RGB_G, green);
  analogWrite(RGB_B, blue);  
}

/* Cycle RGB colors
 */
unsigned int rgbColors[] = {1023, 0, 0};
void cycleRGB() {
  for (int dec_color = 0; dec_color < 3; dec_color += 1) {
    int inc_color = dec_color == 2 ? 0 : dec_color + 1;

    // cross-fade the two colours.
    for(int i = 0; i < 1023; i += 1) {
      rgbColors[dec_color] -= 1;
      rgbColors[inc_color] += 1;
      
      setRGBColor(rgbColors[0], rgbColors[1], rgbColors[2]);
      delay(2);
    }
  }
}

void setup() {
  analogWriteFreq(1);
  pinMode(MOTOR_L_PWM, OUTPUT);
  pinMode(MOTOR_R_PWM, OUTPUT);
  pinMode(MOTOR_L_FWD, OUTPUT);
  pinMode(MOTOR_L_BWD, OUTPUT);
  pinMode(MOTOR_R_FWD, OUTPUT);
  pinMode(MOTOR_R_BWD, OUTPUT);

  WiFi.softAP(ssid, password);
  IPAddress myIP = WiFi.softAPIP();
  server.on("/", handleRoot);
  server.on("/forward", handleForward);
  server.on("/backwards", handleBackwards);
  server.on("/left", handleLeft);
  server.on("/right", handleRight);
  server.begin();
}

void loop() {
  cycleRGB();
  server.handleClient();
}