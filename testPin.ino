//Función de testeo de pines
  void testPin(){
  // Bucle para cada una de las salidas del multiplexor
  for (int i = 0; i < MAX_SALIDAS; i++) {
    // Salida actual del multiplexor
    selecSalida(i);
    
    // Envío de tensión para encender led de posición
    digitalWrite(SIG_PIN, HIGH);
    
    // Leer el estado de la salida actual
    int estadoSalida = analogRead(SIG_PIN);

    oled.clearDisplay(); // Limpia la pantalla
    oled.setCursor(10, 10); //Posición del texto
    oled.print("PIN:"); //
    oled.print(i+1); //
    oled.setCursor(30, 40); //Posición del texto
    if (estadoSalida > 80){
      oled.println(" OK");
    }else(oled.println(" FAIL"));
    oled.display();               //Mostramos en pantalla
    
    // Mostrar el estado de la salida actual por Serial
    Serial.print("Salida ");
    Serial.print(i+1);
    Serial.print(": ");
    Serial.println(estadoSalida);
    
    // Retardo
    delay(500);
  };
  };