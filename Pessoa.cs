using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculando_Idade
{
    public class Pessoa
    {
        private string nome;
        private double altura;
        private int dia;
        private int mes;
        private int ano;
        private int soma;
        
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }

        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public void Mensagem()
        {
            int soma = 2022 - ano;
            Console.WriteLine(nome+" Você tem "+altura+" metros de altura e "+soma+" anos de idade!");
        }
    }
}
