string[] userTypes = new string[] {"administrador", "gerente", "usuario"};

string joinRules = string.Join(", ", userTypes);
string entryInvalidMessage = $"Entrada inválida. Qual sua função? ({joinRules})";

bool entryIsValid = false;

Console.WriteLine($"Qual o seu papel na empresa? ({joinRules})");

do {
  string? readValue = Console.ReadLine();
  
  if (readValue == null) {
    Console.WriteLine(entryInvalidMessage);
    continue;
  }

  string okValue = readValue.Trim().ToLower();

  if (userTypes.Contains(okValue)) {
    entryIsValid = true;
  } else {
    Console.WriteLine(entryInvalidMessage);
  }  

} while (!entryIsValid);

Console.WriteLine("Bem vindo ao trabalho!");