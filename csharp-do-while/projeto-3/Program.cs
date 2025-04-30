string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

foreach( string myString in myStrings ) {

  string processString = myString;
  do {
    int periodPosition = processString.IndexOf('.');

    if (periodPosition == -1) {
      Console.WriteLine(processString);
      break;
    } 

    string stringPart = processString.Substring(0, periodPosition);
    Console.WriteLine(stringPart);
    
    processString = processString.Remove(0, periodPosition + 1).TrimStart();
  } while (true);
}