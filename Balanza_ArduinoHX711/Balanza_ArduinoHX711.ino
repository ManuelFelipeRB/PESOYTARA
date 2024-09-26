#include "HX711.h"

const int DOUT=A0;
const int CLK=A1;

HX711 balanza;

void setup() {
  Serial.begin(9600);
  balanza.begin(DOUT, CLK);
  Serial.print("Lectura del valor del ADC:  ");
  Serial.println(balanza.read());
  Serial.println("No ponga ningun  objeto sobre la balanza");
  Serial.println("Destarando...");
  Serial.println("...");
  balanza.set_scale(753.25); // Establecemos la escala
  balanza.tare(5);  //El peso actual es considerado Tara.
  
  Serial.println("Listo para pesar");  
}

void loop() {
  //Serial.print("Peso: ");
  Serial.println(balanza.get_units(5),0);
  //Serial.println("gr");
  delay(500);
}