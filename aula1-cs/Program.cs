
Console.WriteLine("Hello, World!");

Console.ReadLine();

#pragma warning disable CA1416
Console.Beep(1485, 2000);


//entreada de dados do teclado//
Console.WriteLine("Preparar...");
Console.ReadKey();
Console.WriteLine("Apontar...");
Console.ReadKey();
Console.WriteLine("FOGO!!");
Console.ReadKey();//ReadKey (esconde a tecla usada)//

//Arte//

//Nome//

Console.WriteLine("Digite seu nome:");
string tecla = Console.ReadLine();//ReadLine (Permite ao usuario digitar um texto)//

Console.Write("ola, ");
Console.WriteLine(tecla);
Console.WriteLine("pressione uma tecla");
Console.ReadKey(true);

//Nome e sobrenome//

Console.WriteLine("Digite seu primeiro nome:");
string Nome = Console.ReadLine();

Console.WriteLine("Digite seu sobrenome:");
string Sobrenome = Console.ReadLine();

Console.WriteLine(Nome + " " + Sobrenome);//Ligação via operador//

Console.ReadKey(true);

string NomeCompleto = string.Concat(Nome, " ", Sobrenome);//Metodo de concatenação//
Console.WriteLine(NomeCompleto);

Console.ReadKey(true);

string NomeCompleto2 = String.Format("{0} {1}", Nome, Sobrenome);
Console.WriteLine(NomeCompleto2);

Console.ReadKey(true);


