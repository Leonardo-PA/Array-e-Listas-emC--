 using Exemplosfundamentos.Models;

 // Usar esse codigo em C:\Users\leopd\Desktop\Atividades DIO\teste - Backup

//metodos de lista

List<string> listaString = new List<string>();//nesse caso não é necessario determinar capacidade maxima, pode deixar vazia. 

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");


//metodos de lista
// Console.WriteLine("Percorrendo a Lista com o FOR");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"posição N° {contador} - {listaString[contador]}");
// }

// Console.WriteLine("Percorrendo a Lista com o FOREACH");
// int contadorforeach = 0;
// foreach(string item in listaString)
// {
//      Console.WriteLine($"Posição N° {contadorforeach} - {listaString[contadorforeach]}");
//     contadorforeach++;
// }




//Metodo com array direto sem uso de listas 


 int[] arrayInteiro = new int[4];

 arrayInteiro[0] = 72;
 arrayInteiro[1] = 64;
 arrayInteiro[2] = 50;
 arrayInteiro[3] = 1;

//Criando metodo de copia manualmente. 
// int[] arrayInteirosDobrado = new int[arrayInteiro.Length *2];
// Array.Copy(arrayInteiro, arrayInteirosDobrado, arrayInteiro.Length);


//Array.Resize(ref arrayInteiro, arrayInteiro.Length * 2);//nesse caso está pegando a capacidade do seu array e multiplicando pelo valor estabelecido. 

  Console.WriteLine("Percorrendo o Array com o FOR");
 for(int contador = 0; contador < arrayInteiro.Length; contador ++)
 {
     Console.WriteLine($"Posição N° {contador} - {arrayInteiro[contador]}");
 }


  Console.WriteLine("Percorrendo o array com o FOREACH");

 int contadorforeach = 0;
 foreach(int valor in arrayInteiro)
 {
     Console.WriteLine($"Posição N° {contadorforeach} - {valor}");
     contadorforeach++;
 }
