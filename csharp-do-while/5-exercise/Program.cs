string? readResult;
int idade = 0;
bool isValid = false;

Console.WriteLine("Digite sua idade: ");
do {
  readResult = Console.ReadLine();

  isValid = int.TryParse(readResult, out idade);

  if (!isValid) {
    Console.WriteLine("Valor não é valido");
    break;
  }

  if (idade < 8) {
    Console.WriteLine("Limitamos o formulários para maiores de 8 anos");
    isValid = false;
    break;
  }

  if (idade > 130) {
    Console.WriteLine("Desculpe, mais é dificil acreditar que você tenha essa idade.");
    isValid = false;
  }

} while (readResult == null);

if (isValid) {
  if (idade >= 18) {
    Console.WriteLine("Você já pode usar nossos serviços");
  } else {
    Console.WriteLine("Desculpe, você ainda não tem idade para usar nossos serviços.");
  }
}

Console.WriteLine(">> " + readResult);