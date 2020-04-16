/*  
 *   Testprogram to test Serial communication with Arduino and C# software
 *   
 *   By connecting the inputs 2 through 5 to GND with a button, 4 different testmessages are sent.
 *   
 *   The app also listens to a Serial in message. When the message is complete, ends with '\n' character the complete 
 *   message is send back to the sender.
 */

void setup() {
  Serial.begin(9600);       // start communication at 9600 baud
  
  pinMode(2,INPUT_PULLUP);  // Set IO-pin 2 to input and use internal PullUp resistor
  pinMode(3,INPUT_PULLUP);  // Set IO-pin 3 to input and use internal PullUp resistor
  pinMode(4,INPUT_PULLUP);  // Set IO-pin 4 to input and use internal PullUp resistor
  pinMode(5,INPUT_PULLUP);  // Set IO-pin 5 to input and use internal PullUp resistor
}

void loop() {
  if(!digitalRead(2))       // Read IO-pin 2, when connencted to grond send test message
  {
    Serial.println("Test 1");
  }
  else if(!digitalRead(3))  // Read IO-pin 3, when connencted to grond send test message
  {
    Serial.println("Test 2");
  }
  else if(!digitalRead(4))  // Read IO-pin 4, when connencted to grond send test message
  {
    Serial.println("Test 3");
  }
  else if(!digitalRead(5))  // Read IO-pin 5, when connencted to grond send test message
  {
    Serial.println("Test 4");
  }

  if(Serial.available()>0)          // als er characters in de ontvangst buffer staan 
  {                                 // dan deze verwerken
    char readByte = Serial.read();  // lees karakter als deze beschikbaar is 
    tekstRegel += readByte;         // voeg toe aan opgebouwde string
    if(readByte == '\n')            // is gelezen karakter het eind karakter
    {
      Serial.println(tekstRegel);   // dan string terug sturen
      tekstRegel = "";              // en nieuwe string opbouwen
    }
  }
}
