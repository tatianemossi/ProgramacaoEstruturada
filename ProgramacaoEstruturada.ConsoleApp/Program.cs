using System;
using System.Linq;

namespace ProgramacaoEstruturada.ConsoleApp
{
    internal class Program
    {
        /*
         Desenvolver um algoritmo que dados 10 valores inteiros permita:
        • Encontrar o Maior Valor da sequência
        • Encontrar o Menor Valor da sequência
        • Encontrar o Valor Médio da sequência 
        • Encontrar os 3 maiores valores da sequência 
        • Encontrar os valores negativos da sequência
        • Mostrar na Tela os valores da sequência
        • Remover um item da sequência
        */
        static void Main(string[] args)
        {
            var listaNumerosDigitados = new int[10];
            LerListaNumeros(listaNumerosDigitados);

            listaNumerosDigitados = OrdenarListaOrdemCrescente(listaNumerosDigitados);

            int numeroMaior = 0;
            DescobrirNumeroMaior(listaNumerosDigitados, ref numeroMaior);
            EscreverNumeroMaior(numeroMaior);

            int numeroMenor;
            DescobrirNumeroMenor(listaNumerosDigitados, out numeroMenor);
            EscreverNumeroMenor(numeroMenor);

            decimal valorMedio = 0;
            valorMedio = DescobrirValorMedio(listaNumerosDigitados);
            EscreverValorMedio(valorMedio);

            var tresMaioresNumeros = new int[3];
            tresMaioresNumeros = DescobrirTresMaioresNumeros(listaNumerosDigitados);
            EscreverTresMaioresNumeros(tresMaioresNumeros);

            var listaNumerosNegativos = new int[10];
            listaNumerosNegativos = EncontrarNumerosNegativos(listaNumerosDigitados);
            EscreverNumerosNegativos(listaNumerosNegativos);
            Console.WriteLine();

            EscreverListaNumeros(listaNumerosDigitados);
            Console.WriteLine();
            listaNumerosDigitados = RemoverNumero(listaNumerosDigitados);

            EscreverListaNumeros(listaNumerosDigitados);

            Console.ReadLine();
        }               

        static void LerListaNumeros(int[] listaNumerosDigitados)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o número:");
                listaNumerosDigitados[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void DescobrirNumeroMaior(int[] listaNumerosDigitados, ref int numeroMaior)
        {
            numeroMaior = listaNumerosDigitados[9];
        }

        static void DescobrirNumeroMenor(int[] listaNumerosDigitados, out int numeroMenor)
        {
            numeroMenor = listaNumerosDigitados[0];
        }

        static int[] OrdenarListaOrdemCrescente(int[] listaNumerosDigitados)
        {
            listaNumerosDigitados = listaNumerosDigitados.OrderBy(c => c).ToArray();
            return listaNumerosDigitados;
        }

        static decimal DescobrirValorMedio(int[] listaNumerosDigitados)
        {
            int somatorio = 0;
            decimal valorMedio;
            for (int i = 0; i < listaNumerosDigitados.Length; i++)
            {
                somatorio = somatorio + listaNumerosDigitados[i];
            }

            valorMedio = Convert.ToDecimal(somatorio) / Convert.ToDecimal(listaNumerosDigitados.Length);

            return valorMedio;
        }

        static int[] DescobrirTresMaioresNumeros(int[] listaNumerosDigitados)
        {
            var tresMaioresNumeros = new int[3];
            tresMaioresNumeros[0] = listaNumerosDigitados[9];
            tresMaioresNumeros[1] = listaNumerosDigitados[8];
            tresMaioresNumeros[2] = listaNumerosDigitados[7];

            return tresMaioresNumeros;
        }

        static int[] EncontrarNumerosNegativos(int[] listaNumerosDigitados)
        {
            var listaNumerosNegativos = new int[10];
            int indice = 0;
            for (int i = 0; i < listaNumerosDigitados.Length; i++)
            {
                if (listaNumerosDigitados[i] < 0)
                {
                    listaNumerosNegativos[indice] = listaNumerosDigitados[i];
                    indice++;
                }
            }
            return listaNumerosNegativos;
        }        

        static void EscreverNumeroMaior(int numeroMaior)
        {
            Console.WriteLine($"Maior Valor da Sequência: {numeroMaior}.");
        }

        static void EscreverNumeroMenor(int numeroMenor)
        {
            Console.WriteLine($"Menor Valor da Sequência: {numeroMenor}.");
        }

        static void EscreverValorMedio(decimal valorMedio)
        {
            Console.WriteLine($"Valor Médio da Sequência: {valorMedio}.");
        }

        static void EscreverTresMaioresNumeros(int[] tresMaioresNumeros)
        {
            Console.WriteLine($"Os três maiores números: {tresMaioresNumeros[0]}, {tresMaioresNumeros[1]}, {tresMaioresNumeros[2]}.");
        }

        static void EscreverNumerosNegativos(int[] listaNumerosNegativos)
        {
            Console.Write("Numeros Negativos: ");
            for (int i = 0; i < listaNumerosNegativos.Length; i++)
            {
                if (listaNumerosNegativos[i] < 0)
                {
                    Console.Write(listaNumerosNegativos[i]);
                }
            }
            
        }

        static void EscreverListaNumeros(int[] listaNumerosDigitados)
        {
            Console.Write("Numeros Digitados: ");
            for (int i = 0; i < listaNumerosDigitados.Length; i++)
            {
                Console.Write($"{listaNumerosDigitados[i]} ");
            }
        }

        private static int[] RemoverNumero(int[] listaNumerosDigitados)
        {
            Console.WriteLine("Digite o número a ser removido: ");
            int numeroRemovido = Convert.ToInt32(Console.ReadLine());
            listaNumerosDigitados = listaNumerosDigitados.Where(val => val != numeroRemovido).ToArray();
            Console.WriteLine($"O número {numeroRemovido} foi removido.");
            return listaNumerosDigitados;
        }

    }
}
