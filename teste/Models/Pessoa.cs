using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplosfundamentos.Models
{
    public class Pessoa
    {
        public string Nome {get; set;} =string.Empty; //Comentario 1 //

        public int Idade {get;set;}

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos"); // cometario 2 //
            //Console.WriteLine($"Olá, meu nome é {Nome} \n e tenho {Idade} anos"); // cometario 3 //
        }
    }
}

        //comentario 1: Foi necessario definir como vazio o valor de String pois o mesmo entra em conflito no termiinal 
        //Apresentando erro CS8618: O propriedade não anulável 'Nome' precisa conter um valor não nulo ao sair do construtor. Considere adicionar o modificador "obrigatório" ou declarar o propriedade como anulável.
        //Assim se definirmos o valor da nossa String como "Empty" o sistema reconhece e puxa o valor diretamente da pasta Progam.cs tornando o Terminal menos poluido. 


        //comentarios 2:pode ser inserida diretamente dessa forma o codigo pois assim não tera uma quebra de linha dentro dos paramentros 
        // comentario 3: pode ser inserido o \n que representa uma quebra de linha;