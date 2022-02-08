//Requisitos
//Requisito 01: 
//Nossa calculadora deve ter a possibilidade de somar dois números

//Requisito 02: 
//Nossa calculadora deve ter a possibilidade fazer várias operações de soma

//Requisito 03:
//Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração

//Requisito 04: 
//Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {


            //calcularTerreno();
            //padariaNotStonks();
            //dias_De_vida();
            //converterGraus();
            //salarioFuncionario();

      
            
            
            /*     
            string escolha;
            string strSegundoNumero;
       
            do
            {
                double resultado = 0;


                
                Console.WriteLine("Calculadora top");

                Console.WriteLine("Digite o primeiro número:");
                string strPrimeiroNumero = Console.ReadLine();

                do {
                    Console.WriteLine("Digite o segundo número:");
                     strSegundoNumero = Console.ReadLine();
                    if (strSegundoNumero == "0")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite um valor diferente de 0:");
                        Console.ForegroundColor= ConsoleColor.White;
                    }
                }while (strSegundoNumero == "0");

                double n1 = System.Convert.ToDouble(strPrimeiroNumero);
                double n2 = System.Convert.ToDouble(strSegundoNumero);

                Console.WriteLine("Digite qual operação deseja fazer:");
                Console.WriteLine("Somar: + | Subtrair: -  |  Multiplicar: * | Dividir: /  | Sair: s");
                string operacao = Console.ReadLine();

                if (operacao == "s")
                {
                    break;
                }else if (operacao == "+")
                {
                    resultado = n1 + n2;

                }else if (operacao == "-")
                {
                    resultado = (n1 - n2);

                }else   if (operacao == "*")
                {
                    resultado = (n1 * n2);

                }else  if (operacao == "/")
                {
                    if (n2 == 0)
                    {
                        Math.Round(resultado,2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Não é possível dividir por zero");
                        Console.WriteLine("Tente novamente");
                    }
                    else
                    {

                        resultado = (n1 / n2);
                    }
                }
                Console.Clear();
                Console.WriteLine("Resultado: " + resultado);
                do
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Deseja continuar?(s/n)");
                    escolha = Console.ReadLine();
                    if (escolha != "s" && escolha != "n")
                    {
                     
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Comando inexistente..");
                        Console.WriteLine("Tente novamente...");

                    }
               ;
                }while (escolha != "s" && escolha != "n");
            } while (escolha == "s" || escolha != "n");

           
       */    
            

        }

        public static void calcularTerreno()
        {
            String opcao;
            do
            {


                Console.WriteLine("Calculadora de Área de Terreno");


                Console.WriteLine("Digite o valor da base do terreno:");
                string strBase = Console.ReadLine();

                Console.WriteLine("Digite o valor da altura do terreno:");
                string strAltura = Console.ReadLine();

                double valorBase = System.Convert.ToDouble(strBase);
                double valorAltura = System.Convert.ToDouble(strAltura);

                double areaRetangulo = valorBase * valorAltura;

                Console.WriteLine("Resultado:");
                Console.WriteLine("Valor da base: " + valorBase);
                Console.WriteLine("Valor da altura: " + valorAltura);
                Console.WriteLine("Valor da área: " + areaRetangulo);

                Console.WriteLine("Deseja realizar o cálculo novamente?(s/n)");
                  opcao = Console.ReadLine();
            }while(opcao == "s");

        }


        public static void padariaNotStonks()
        {
            string opcao;
            do
            {
                Console.WriteLine("Digite a quantidade de pães franceses vendidos:");
                string strPaoFrances = Console.ReadLine();
                Console.WriteLine("Digite a quantidade de broas vendidas:");
                string strBroa = Console.ReadLine();

                double valorPaoFrances = System.Convert.ToDouble(strPaoFrances);
                double valorBroa = System.Convert.ToDouble(strBroa);

                double valorFinal = (valorPaoFrances * 0.12) + (valorBroa * 1.5);

                Console.WriteLine("Valor Arrecadado: " + valorFinal + "R$");
                Console.WriteLine("Valor que irá para a poupança: " + (valorFinal * 0.1) + "R$");


                Console.WriteLine("Deseja realizar o cálculo novamente?(s/n)");
                opcao = Console.ReadLine();

            } while(opcao == "s");
        }

        public static void dias_De_vida()
        {
            String opcao;
            do
            {
                Console.WriteLine("Digite seu nome:");
                string strNome = Console.ReadLine();

                Console.WriteLine("Digite sua idade:");
                string strIdade = Console.ReadLine();

                double idade = System.Convert.ToDouble(strIdade);

                double totdias = idade * 365;

                Console.WriteLine("Nome: " + strNome);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("Total de dias: " + totdias);


                Console.WriteLine("Deseja realizar a operação novamente?(s/n)");
                opcao = Console.ReadLine();

            } while(opcao == "s");
        }


        public static void converterGraus()
        {
            String opcao;
            do
            {
                Console.WriteLine("Digite a temperatura em Celsius:");
                string strCelsius = Console.ReadLine();

                double grausCelsius = System.Convert.ToDouble(strCelsius);

                double grausFahrenheit = grausCelsius * 1.8 + 32;

                Console.WriteLine("Temperatura em Celsius: " + grausCelsius);
                Console.WriteLine("Temperatura em Fahrenheit: " + grausFahrenheit);

                Console.WriteLine("Deseja realizar a operação novamente?(s/n)");
                opcao = Console.ReadLine();


            }while(opcao == "s");
        }


        public static void salarioFuncionario()
        {
            string opcao;
            do
            {
                Console.WriteLine("Digite o valor do salário: ");
                string strSalario = Console.ReadLine();

                double salario = System.Convert.ToDouble(strSalario);

                double salarioAumento = salario + (salario * 0.15);
                double salarioFinal = salarioAumento - (salarioAumento * 0.08);


                Console.WriteLine("Salário: " + salario + " R$");
                Console.WriteLine("Salário com aumento: " + salarioAumento + "R$");
                Console.WriteLine("Salário final: " + salarioFinal + "R$");



                Console.WriteLine("Deseja realizar a operação novamente?(s/n)");
                opcao = Console.ReadLine();

            } while (opcao == "s");
        }

    }

    
}
