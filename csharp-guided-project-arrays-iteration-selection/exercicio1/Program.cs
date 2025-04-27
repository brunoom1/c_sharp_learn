int[,] scores = new int[,] {
  {1, 2, 3, 4, 5},
  {10, 12, 13, 14, 15}
};

Console.WriteLine(scores[1,0]);

foreach (int n in scores) {
  Console.WriteLine("score: " + n + ", ");
}