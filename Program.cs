using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculando_Idade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();
            Console.WriteLine("Olá, porfavor informe seu nome");
            obj.Nome = string.Format(Console.ReadLine());
            Console.WriteLine("Perfeito, agora informe sua altura");
            obj.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Perfeito, agora o dia do seu aniversario");
            obj.Dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Perfeito, agora o mes do seu aniversario");
            obj.Mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Perfeito, agora o ano do seu aniversario");
            obj.Ano = int.Parse(Console.ReadLine());
            obj.Mensagem();
        }
    }
}
