using Exemplosfundamentos.Models; 

int[] arrayInteiro = new int[3];

arrayInteiro[0] = 72;
arrayInteiro[1] = 64;
arrayInteiro[2] = 50;
//arrayInteiro[3] = 1;

for(int contador = 0; contador < arrayInteiro.Length; contador ++)
{
    Console.WriteLine($"Posição N° {contador} - {arrayInteiro[contador]}");
}




// //Codigo redigido para testes em que seja direcionado os comandos. 

// using Exemplosfundamentos.Models;

// //Teste Etapa 1
//         Pessoa pessoa1 = new Pessoa();
//         pessoa1.Nome = "Leo";
//         pessoa1.Idade = 26;
//         pessoa1.Apresentar();


// //Teste de Varivais da Etapa 2 
//         string apresentacao = "Olá, seja bem vindo"; //string recebe o valor de string no caso textos dentro das "".  

//         int quantidade = 1; //representa tipo Inteiro e passa o valor para ele.
//         Console.WriteLine("Valor da variavel quantidade: " + quantidade);

//         quantidade = 10; //Nesse caso está sendo alterado o valor de uma variveis já existente. 
//         Console.WriteLine("Valor da variavel quantidade: " + quantidade);

//         double altura = 1.80; //representa casas decimais. sempre usar com . dentro da programação não , pois a mesma é usada em texto.

//         decimal preco = 1.80M; // se passar um valor direto devera ser incluido um M que representa exatamente a casa decimal nele. 

//         bool condicao = true; // condiçõa de verdadeiro ou falso com relação as outras variveis. 
    
//         Console.WriteLine(apresentacao);
//         Console.WriteLine("Valor da variavel quantidade: " + quantidade);
//         Console.WriteLine("Valor da variavel altura: " + altura.ToString("0.00"));
//         Console.WriteLine("Valor da variavel preco: " + preco);
//         Console.WriteLine("Valor da variavel condicao: " + condicao);

// //Etapa 2.1 Teste de datas
//         DateTime dataAtual = DateTime.Now.AddDays(5); //pega um datetime data/hora atual do horario atual da sua maquina, sendo assim sempre que estiver executando prestar atenção. 
//         Console.WriteLine(dataAtual.ToString("dd/MM/yyyy  HH:mm"));

