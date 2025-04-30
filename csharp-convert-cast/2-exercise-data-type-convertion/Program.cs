using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

string message = "";
float soma = 0;
foreach( string value in values ) {
  float result;
  if (float.TryParse(value, out result)) {
    Console.WriteLine(result);
    soma += result;
  } else {
    message += value;
  }
}

Console.WriteLine("Message: " + message);
Console.WriteLine("Total: " + soma);