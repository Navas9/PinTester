//Función para leer los movimientos del enconder a derecha e izquierda
void leerEncoder() {
  int MSB = digitalRead(ENCODER_A_PIN); // Bit más significativo
  int LSB = digitalRead(ENCODER_B_PIN); // Bit menos significativo

  int encoded = (MSB << 1) | LSB; // Converting the 2 pin value to single number
  int sum = (lastEncoded << 2) | encoded; // Adding it to the previous encoded value

  if (sum == 0b1101 || sum == 0b0100 || sum == 0b0010 || sum == 0b1011) encoderPos++;
  if (sum == 0b1110 || sum == 0b0111 || sum == 0b0001 || sum == 0b1000) encoderPos--;

  lastEncoded = encoded; // Guarda el último valor
  lastEncoderTime = millis();
}