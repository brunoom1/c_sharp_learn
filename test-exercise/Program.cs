
Random rd = new Random();

int hero = 10;
int villain = 10;

int countInterations = 0;

do {

  int golpe = rd.Next(1, 10);

  Console.WriteLine($"Round {countInterations}");
  if (countInterations % 2 == 0) {
    villain -= golpe;  
      Console.WriteLine($"\tHero: attack({golpe})");
    Console.WriteLine($"\tVillain: integrity({villain})");
  } else {
    hero -= golpe;
    Console.WriteLine($"\tVillain: attack({golpe})");
    Console.WriteLine($"\tHero: integrity({hero})");
  }
  Console.WriteLine();

  countInterations ++;
} while (hero > 0 && villain > 0);

if (hero <= 0) {
  Console.WriteLine("Hero lost");
} else {
  Console.WriteLine("Villain lost");
}
