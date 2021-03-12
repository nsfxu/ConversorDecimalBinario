using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDecimalBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation v = new Validation();
            int opcao;
            while (true)
            {
                Console.WriteLine("Digite uma das opções abaixo: ");

                Console.WriteLine("1 - Decimal para Binário | máx: 65536");
                Console.WriteLine("2 - Binário para Decimal | máx: 16 chrs");
                Console.WriteLine("3 - Sair");

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        int valor;
                        string binario = "", input = "";
                        Console.WriteLine("Digite o número");
                        input = Console.ReadLine();

                        #region Validação da primeira opção
                        if (v.isNumber(input))
                            valor = Convert.ToInt32(input);
                        else
                        {
                            Console.WriteLine("Digite somente números!!!!!!!!!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                        if (v.isMax(valor))
                        {
                            Console.WriteLine("Você digitou um número maior que o máximo permitido.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else if (v.isNegative(valor))
                        {
                            Console.WriteLine("Números negativos não são permitidos.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        #endregion

                        while (valor != 0)
                        {
                            binario += Convert.ToString(valor % 2);
                            valor = valor / 2;
                        }

                        Console.WriteLine("O valor em binário é: " + binario);
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 2:
                        string binario2;
                        int valorfinal = 0;
                        Console.WriteLine("Digite o número binário");
                        binario2 = Console.ReadLine();

                        #region Validação da segunda opção                      
                        if (v.isBMax(binario2))
                        {
                            Console.WriteLine("O binário digitado tem mais de 16 chars");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        #endregion

                        int i;
                        for (i = 0; i < binario2.Length; i++)
                        {
                            if (binario2[i] == '1')
                                valorfinal += 1 * Convert.ToInt32(Math.Pow(2, i));
                            else
                                valorfinal += 0 * Convert.ToInt32(Math.Pow(2, i));
                        }

                        Console.WriteLine("O valor em decimal é: " + valorfinal);

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        return;
                }
            }
        }
    }
}
