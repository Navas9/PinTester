// Selecciona una salida específica del multiplexor
void selecSalida(int output) {
  // Convierte el número de salida en binario
  digitalWrite(S0, bitRead(output, 0));
  digitalWrite(S1, bitRead(output, 1));
  digitalWrite(S2, bitRead(output, 2));
  digitalWrite(S3, bitRead(output, 3));
}