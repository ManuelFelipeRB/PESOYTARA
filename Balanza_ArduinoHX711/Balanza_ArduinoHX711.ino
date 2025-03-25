
void setup() {
  Serial.begin(9600);
  randomSeed(analogRead(A0)); // Inicializa la semilla aleatoria con ruido analógico
}

void loop() {
  int randomNum = random(2000, 4501) * 10; // Genera múltiplos de 10 entre 10000 y 45000
  if (randomNum > 0) { 
    Serial.println(randomNum); // Imprime el número si es positivo
  }
  delay(900); // Espera 600 ms antes de generar otro número
}

