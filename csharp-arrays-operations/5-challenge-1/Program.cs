string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(" ");

for (int i = 0; i < words.Length; i++) {
  char[] chArray = words[i].ToCharArray();
  words[i] = String.Join("", chArray.Reverse());
} 

Console.WriteLine(String.Join(" ", words));