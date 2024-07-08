#include <Servo.h>
#define AIR_AC   2
#define BOM_AG   4
#define BOM_AI   5
#define CALEF    6
Servo myservo;
void setup() {
  Serial.begin(9600);
  pinMode(2,OUTPUT);
  pinMode(4,OUTPUT);
  pinMode(5,OUTPUT);
  pinMode(6,OUTPUT);
  myservo.attach(3);
}

void loop() {
  int comand = Serial.read();
  int dato;
  if(comand=='1'){ // Envia valor de sensor Humedad
    dato = analogRead(A0);
    Serial.print(dato);
    Serial.println(" ");
  }
  if(comand=='2'){ // Envia valor de sensor Temp
    dato = analogRead(A1);
    Serial.print(dato);
    Serial.println(" ");
  }
  if(comand=='3'){ // Enciende Ventilador
    digitalWrite(AIR_AC,1);
  }
  if(comand=='4'){ // Apaga Ventilador
    digitalWrite(AIR_AC,0);
  }
  if(comand=='5'){ // Servo 90°
     myservo.write(90);
     delay(100);
  }
  if(comand=='6'){ // Servo 0°
     myservo.write(0);
     delay(100);
  }
  if(comand=='7'){ // Enciede Bomba Agua
    digitalWrite(BOM_AG,1);
  }
  if(comand=='8'){ // Apaga Bomba Agua
    digitalWrite(BOM_AG,0);
  }
  if(comand=='9'){ // Enciede Bomba Aire
    digitalWrite(BOM_AI,1);
  }
  if(comand=='A'){ // Apaga Bomba Aire
    digitalWrite(BOM_AI,0);
  }
  if(comand=='B'){ // Enciede Calefaccion
    digitalWrite(CALEF,1);
  }
  if(comand=='C'){ // Apaga Calefaccion
    digitalWrite(CALEF,0);
  }
  
}
