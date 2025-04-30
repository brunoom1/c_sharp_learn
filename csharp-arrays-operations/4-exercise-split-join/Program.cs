string value = "abc123";

char[] valueArray = value.ToCharArray();

Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);

string joinResult = String.Join(',', valueArray);

Console.WriteLine(joinResult);

string[] splitResult = joinResult.Split(',');
foreach(string s in splitResult) {
  Console.WriteLine(s);
}