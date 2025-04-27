int MAX = 10;
int MIN = 5;

string entryMessage = $"Digite um valor entre {MAX} e {MIN}";
Console.WriteLine(entryMessage);

string? inputLine;
bool isValidInteger = false;
int number = 0;

do {
  inputLine = Console.ReadLine();

  isValidInteger = int.TryParse(inputLine, out number);
  bool isValidRange = number >= MIN && number <= MAX;

  if (!isValidInteger || !isValidRange) {
    Console.WriteLine("O valor é inválido. " + entryMessage);
    continue;
  }

  break;

} while ( true );

Console.WriteLine("O valor de entrada foi aceito!");
