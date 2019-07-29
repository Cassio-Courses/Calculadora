using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            string x;
            while (true)
            {
                calculadora();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Deseja continuar a fazer calculos amiguinho?");
                Console.WriteLine("Digite 1 para continuar ou 0 encerrar o programa opora");
                x = Console.ReadLine();
                if (x == "0")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }


        }

        static void calculadora()
        {
            {
                Console.WriteLine("Escreva numero 1");
                double n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Escreva o numero 2");
                double n2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Escreva qual função deseja fazer com os numeros");
                Console.WriteLine("1 para soma, 2 para subtração, 3 para multiplicação, 4 para divisão");
                string x = Convert.ToString(Console.ReadLine()); //Falta o tratamento de empty string
                while (x == "" || x == null)
                {
                    Console.Clear();
                    Console.WriteLine("Escreva qual função deseja fazer com os numeros");
                    Console.WriteLine("1 para soma, 2 para subtração, 3 para multiplicação, 4 para divisão");
                    Console.WriteLine("Insira uma opção");
                    x = Console.ReadLine();

                }
                while (Convert.ToInt64(x) <= 0 && Convert.ToInt64(x) > 4)
                {
                }

                functions.Escolha(x, n1, n2);//chama função quando sair dos whiles
            }

            }
        }
        public class functions
        {
            public static double soma(double n1, double n2)
            {
                double soma;
                soma = n1 + n2;
                return soma;
            }
            public static double subs(double n1, double n2)
            {
                double subs;
                subs = n1 - n2;
                return subs;
            }
            public static double mult(double n1, double n2)
            {
                double mult;
                mult = n1 * n2;
                return mult;
            }
            public static double divs(double n1, double n2)
            {
                double divs;
                divs = n1 / n2;
                return divs;
            }
        public static string Escolha(string x, double n1, double n2)
        {
            string result;
            Console.Clear();
            if (x == "1")
            {
                result = (string.Format("O Resultado entre a soma dos numeros {0} e {1} é: {2}", n1, n2, functions.soma(n1, n2)));
            }
            else if (x == "2")
            {
                result = (string.Format("O Resultado entre a substração dos numeros {0} e {1} é: {2}", n1, n2, functions.subs(n1, n2)));
            }
            else if (x == "3")
            {
                result = (string.Format("O Resultado entre a multiplicação dos numeros {0} e {1} é: {2}", n1, n2, functions.mult(n1, n2)));
            }
            else if (x == "4")
            {
                if (n2 == 0)
                {
                    result = ("O segundo numero não pode ser zero fiadaputa");
                }
                else
                {
                    result = (string.Format("O Resultado entre a divisão dos numeros {0} e {1} é: {2}", n1, n2, functions.divs(n1, n2)));
                }
            }
            else
            {
                result = ("Opção invalida, ecolha a opção novamente");

            }
            return result;
        }


        }
    }
