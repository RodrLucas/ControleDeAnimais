using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstAnimal = new Animal();
            var secondAnimal = new Animal();
            var thirdAnimal = new Animal();
            var fourthAnimal = new Animal();
            var fifthAnimal = new Animal();

            int qtdCachorro = 0, qtdGato = 0, qtdPeixe = 0;


            Console.WriteLine("Controle de aniamais");

            //Primeiro
            Console.Write("Informe o nome do primeiro animal: ");
            firstAnimal.Nome = Console.ReadLine();

            Console.Write("Informe o tipo do primeiro animal: ");
            firstAnimal.Tipo = Console.ReadLine();

            if(firstAnimal.Tipo.ToUpper() == "CACHORRO") qtdCachorro++;
            if (firstAnimal.Tipo.ToUpper() == "GATO") qtdGato++;
            if (firstAnimal.Tipo.ToUpper() == "PEIXE") qtdPeixe++;

            //Segundo
            Console.Write("Informe o nome do segundo animal: ");
            secondAnimal.Nome = Console.ReadLine();

            Console.Write("Informe o tipo do segundo animal: ");
            secondAnimal.Tipo = Console.ReadLine();

            if (secondAnimal.Tipo.ToUpper() == "CACHORRO") qtdCachorro++;
            if (secondAnimal.Tipo.ToUpper() == "GATO") qtdGato++;
            if (secondAnimal.Tipo.ToUpper() == "PEIXE") qtdPeixe++;


            //Terceiro
            Console.Write("Informe o nome do teceiro animal: ");
            thirdAnimal.Nome = Console.ReadLine();

            Console.Write("Informe o tipo do terceiro animal: ");
            thirdAnimal.Tipo = Console.ReadLine();

            if (thirdAnimal.Tipo.ToUpper() == "CACHORRO") qtdCachorro++;
            if (thirdAnimal.Tipo.ToUpper() == "GATO") qtdGato++;
            if (thirdAnimal.Tipo.ToUpper() == "PEIXE") qtdPeixe++;

            //Quarto
            Console.Write("Informe o nome do quarto animal: ");
            fourthAnimal.Nome = Console.ReadLine();

            Console.Write("Informe o tipo do quarto animal: ");
            fourthAnimal.Tipo = Console.ReadLine();

            if (fourthAnimal.Tipo.ToUpper() == "CACHORRO") qtdCachorro++;
            if (fourthAnimal.Tipo.ToUpper() == "GATO") qtdGato++;
            if (fourthAnimal.Tipo.ToUpper() == "PEIXE") qtdPeixe++;

            //Quinto
            Console.Write("Informe o nome do quinto animal: ");
            fifthAnimal.Nome = Console.ReadLine();

            Console.Write("Informe o tipo do quinto animal: ");
            fifthAnimal.Tipo = Console.ReadLine();

            if (fifthAnimal.Tipo.ToUpper() == "CACHORRO") qtdCachorro++;
            if (fifthAnimal.Tipo.ToUpper() == "GATO") qtdGato++;
            if (fifthAnimal.Tipo.ToUpper() == "PEIXE") qtdPeixe++;


            //Resultado
            Console.WriteLine("Total de animais");
            Console.WriteLine($"Cachorros: {qtdCachorro}");
            Console.WriteLine($"Gatos: {qtdGato}");
            Console.WriteLine($"Peixes: {qtdPeixe}");
            Console.ReadKey();
        }
    }
}
