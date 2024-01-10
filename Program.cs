using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace logica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercicio de Estrutura sequencial

            /* Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
             mensagem explicativa*/
            Console.WriteLine("programa que calcula soma de inteiros");
            Console.WriteLine("Escreva o primeiro numero: ");
             int n1= int.Parse(Console.ReadLine());
             Console.WriteLine("Escreva o segundo numero: ");
             int n2= int.Parse(Console.ReadLine());
             int soma = n1 + n2;

             Console.WriteLine("Soma = " + soma);
            Console.ReadLine();

             /*Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
               casas decimais.*/

             Console.WriteLine("programa que calcula a Area de um circulo: ");
             Console.WriteLine("Informe o Raio do circulo: ");
             double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             double pi = 3.14159;
             double area = pi * Math.Pow(raio, 2);

             Console.WriteLine("A area do circulo é igual a: " + area.ToString("f4", CultureInfo.InvariantCulture));
             Console.ReadLine();

            /*Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto 
            de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D)*/
            Console.WriteLine("Programa que calcula a diferença entre o produto da multiplicação de AB por CD");
            Console.WriteLine("informe o numero A ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("informe o numero B ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("informe o numero C ");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("informe o numero D ");
            int D = int.Parse(Console.ReadLine());

            int dif = A * B - C * D;

            Console.WriteLine("A diferença do produto de AB por CD é: " + dif);
            Console.ReadLine();


}
}
}
