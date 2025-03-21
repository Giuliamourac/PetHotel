using System;

namespace PetHotel
{
    class Program
    {
        static void Main(string[] agrs)
        {
            Console.WriteLine("Bem vindo(a) ao PetHotel, para realizarmos o cadastro de seu pet pressione uma tecla.");
            Console.ReadKey();

            Console.WriteLine("Qual a espécie do seu pet?");
            string Especie = Console.ReadLine();

            Console.WriteLine("Qual a raça do seu pet?");
            string Raca = Console.ReadLine();

            Console.WriteLine("Qual o nome do seu pet?");
            string Nome = Console.ReadLine();

            Console.WriteLine("Qual a idade do seu pet?");
            int Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual a cor do seu pet?");
            string Cor = Console.ReadLine();

            Console.WriteLine("+========================================================= +");
            Console.WriteLine("                      Pet Hotel                             ");
            Console.WriteLine("+========================================================= +");
            Console.WriteLine($"  Espécie: {Especie}          | Raça: {Raca}               ");
            Console.WriteLine("+========================================================= +");
            Console.WriteLine($"  Atende pela alcunha de: {Nome}                           ");
            Console.WriteLine($"  Idade: {Idade} ano(s)       | Pelagem // cor: {Cor}      ");
            Console.WriteLine("+========================================================= +");
        }
    }
}