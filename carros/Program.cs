using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace carros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu(args);
            
        }
        static void menu(string[] args) 
        {
            pessoa p1 = new pessoa();
            Console.WriteLine("qual seu nome ?");
            p1.nome = Console.ReadLine();
            Console.WriteLine("qual sobrenome?");
            p1.sobrenome = Console.ReadLine();
            Console.WriteLine("qual sua idade?");
            p1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("digite seu cpf :");
            p1.cpf = double.Parse(Console.ReadLine());
            

            Console.WriteLine("------------------");
            compra();
            
        }
        static void compra() 
        {
            int escolha = 0;
           string[] cores = { "preto", "branco", "prata", "cinza" };
           string[] modelos4x4 = { "toro", "hilux", "sw4", "strada" };
           string[] modelosendan = { "elantra", "siena,", "prisma", };
           string[] modelosret = { "hb20", "punto", "palio", "cruze" };
           int[] ano = { 2018, 2019, 2020, 2021, 2022, 2023 };
           Console.WriteLine("escolha seu modelo:");
           Console.WriteLine(modelosendan);
            switch (escolha) 
            {
                case 1: Console.WriteLine(" vc escolheu o elenatra");
                    break;
            }
        }
        
        
    }

    
    class pessoa 
    {
        public string nome = "";
        public string sobrenome = "";
        public int idade = 0;
        public double cpf = 0;
        
    }
}
