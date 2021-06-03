using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu() 
        {
            Console.Clear();

            Console.WriteLine("=======================");

            Console.WriteLine("Escolha uma das opções:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - IMC");
            Console.WriteLine("6 - Média Alunos");
            Console.WriteLine("7 - Sair");

            Console.WriteLine("=======================");

            int res = int.Parse(Console.ReadLine());

            switch(res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Imc(); break;
                case 6: Media(); break;
                case 7: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma() 
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = n1+n2;
            Console.WriteLine($"O resultado da soma entre {n1} e {n2} é: {resultado}");
            Console.ReadKey();   
            Menu();
        }

        static void Subtracao() 
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = n1-n2;
            Console.WriteLine($"O resultado da subtração entre {n1} e {n2} é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = n1/n2;
            Console.WriteLine($"O resultado da divisão entre {n1} e {n2} é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = n1*n2;
            Console.WriteLine($"O resultado da multiplicação entre {n1} e {n2} é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Imc()
        {
            
            Console.Clear();

            Console.WriteLine("Digite o seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            double resultado = peso/(altura*altura);

            if(resultado < 16)
                Console.WriteLine($"Seu IMC é {resultado}, considerado Subpeso severo, cuidado!");
            if(resultado >= 16 && resultado <= 19.9)
                Console.WriteLine($"Seu IMC é {resultado}, considerado Subpeso, cuidado!");
            if(resultado >= 20 && resultado <= 24.9)
                Console.WriteLine($"Seu IMC é {resultado}, Normal!");
            if(resultado >= 25 && resultado <= 29.9)
                Console.WriteLine($"Seu IMC é {resultado}, considerado Sobrepeso, cuidado!");
            if(resultado >= 30 && resultado <= 39.9)
                Console.WriteLine($"Seu IMC é {resultado}, considerado obesidade, cuidado!");
            if(resultado >= 40)
                Console.WriteLine($"Seu IMC é {resultado}, está com obesidade mórbida, cuidado!");
            
            Console.ReadKey();
            Menu();
        }
    
        static void Media()
        {
            Console.Clear();

            double total = 0;

            Console.WriteLine("Informe a quantidade de alunos: ");
            double alunos = double.Parse(Console.ReadLine());

            for(int i = 1; i <= alunos; i++) 
            {
                Console.WriteLine($"Digite a nota do {i}º aluno");
                double nota = double.Parse(Console.ReadLine());

                total += nota;
            }

            double media = total/alunos;
            Console.WriteLine($"A média das notas dos {alunos} alunos é {media}.");

            Console.ReadKey();
            Menu();
        }
    }
}
