string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] pedidos = orderStream.Split(',');
Array.Sort(pedidos);

foreach(string pedido in pedidos) {
  Console.WriteLine($"{pedido} \t { (pedido.Length == 4? "": "- Error") }");
}