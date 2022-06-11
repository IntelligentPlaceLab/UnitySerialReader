/*
 * SerialOutput sketch
 * Print numbers to the serial port
*/
void setup()
{
  Serial.begin(9600); // send and receive at 9600 baud
}

int number = 0;
int number2 = 1;

void loop()
{
  Serial.print(number); //print first number
  Serial.print(", "); //add a comma
  Serial.print(number2); //print second number
  Serial.println(); //line break

  delay(500); // delay half second between numbers
  number++; //add 1 to number
  number2++; //add 1 to number
}