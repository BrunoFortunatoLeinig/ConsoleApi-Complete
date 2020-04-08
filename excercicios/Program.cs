using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Formatação do sistema
            Console.Title = "CONSOLE COMPLETO";
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();



            //variaveis
            /*quando precisamos colocar um valor direto para uma variavel não é necessario
             informar ela novamente com o valor dentro do código.*/
            String Nome, Nome2 = "Thanos", NomeC, RG, CPF, Email, CC;
            Double AN, ID, N1, N2, N3, N4, N5, Dados, Salario, S, SS1, SS2, A1, A2, C1, C2, C3, C4;


            //algoritimo de titulo
            // \t faz com que de espaços no comando de saida e /n pula linha
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\t\t\t\t\t-------------------------------------------");
            Console.WriteLine("\t\t\t\t\t      Bem vindo ao Console Completo??      ");
            Console.WriteLine("\t\t\t\t\t-------------------------------------------");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Black;


            //pedido de nome e mensagem com nome
            Console.WriteLine("Qual o seu nome??");
            Nome = Console.ReadLine();
            Console.WriteLine("Seja bem vindo " + Nome);
            Console.WriteLine("");


            //nome do "robo"
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Meu Nome é " + Nome2 + "!!!!");
            Console.ForegroundColor = ConsoleColor.Black;
            Press();


            //soma entre dois numeros
            Console.Write("\n" + Nome + " Por favor me diga um número: ");
            N1 = double.Parse(Console.ReadLine());
            Console.Write("Informe outro número: ");
            N2 = double.Parse(Console.ReadLine());
            S = N1 + N2;
            Console.WriteLine("Testando.... A Soma entre ->" + N1 + " e " + N2 + " é: " + S);
            Console.WriteLine("\nFuncionou, Agora vamos a outras funcionalidades");
            Press();
            Console.WriteLine("");


            //algoritimo para par ou impar
            Console.Write("Por Gentileza informe mais um número: ");
            N3 = double.Parse(Console.ReadLine());
            if (N3 % 2 == 0)
            {
                Console.WriteLine("\neste número é PAR");
            }
            else
            {
                Console.WriteLine("\neste número é IMPAR");
            }
            Console.WriteLine("");
            Press();


            //inserção e validação de dado usuario.
            validacaodedados(out NomeC, out RG, out CPF, out Email, out Dados);
            Console.WriteLine("");
            Press();


            //ajuste de sálario
            Console.Write("Gostei de você, vou te dar um aumento, Qual o seu salario atual???: R$");
            Salario = double.Parse(Console.ReadLine());
            A1 = 300;
            A2 = 200;
            SS1 = Salario + A1;
            SS2 = Salario + A2;
            if (Salario < 1700)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nSeu aumento é de R$300,00 ficando em: R$" + SS1);
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nSeu aumento é de R$200,00 ficando em: R$" + SS2);
                Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.WriteLine("");
            Press();


            //verificação da idade e validação da mesma.
            Console.WriteLine("Precisarei saber sua idade agora para podermos proseguir");
            ValidacaoAcesso(out AN, out ID);


            //algoritimo para a calculadora SIMPLES, entra com operação e 2 valores
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\t\t\t\t--------------------------------------");
            Console.WriteLine("\t\t\t\t\t          CALCULADORA THANOS          ");
            Console.WriteLine("\t\t\t\t\t--------------------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Agora você tem acesso a minha calculadora, Então vamos-lá!!!!");
            Press();
            Console.Write("Informe um Número: ");
            N4 = double.Parse(Console.ReadLine());
            Console.Write("Informe outro número: ");
            N5 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual cálculo deseja fazer???");
            Console.WriteLine("a para Soma");
            Console.WriteLine("b para Subtração");
            Console.WriteLine("c para Multiplicação");
            Console.WriteLine("d para Divisão");
            CC = Console.ReadLine();
            C1 = N4 + N5;
            C2 = N4 - N5;
            C3 = N4 * N5;
            C4 = N4 / N5;
            switch (CC)
            {
                case "a":
                    Console.WriteLine("O resultado da Operação é: " + C1);
                    break;
                case "b":
                    Console.WriteLine("O resultado da Operação é: " + C2);
                    break;
                case "c":
                    Console.WriteLine("O resultado da Operação é: " + C3);
                    break;
                case "d":
                    Console.WriteLine("O resultado da Operação é: " + C4);
                    break;
                default:
                    Console.WriteLine("Operação invalida");
                    break;
            }

            //Parabenização
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nParabéns conseguiu usar minha calculadora");
            Console.ForegroundColor = ConsoleColor.Black;
            Press();

            //Calculo e cadastro de IMC
            Console.WriteLine("\nagora quero saber se está no seu pesso ideal ou não, então seguinte:");
            double M, A, IMC;
            string Escolha;
            Console.Write("informe sua massa em (Kg): ");
            M = Convert.ToDouble(Console.ReadLine());
            Console.Write("informe sua Altura em (m): ");
            A = Convert.ToDouble(Console.ReadLine());
            IMC = M / Math.Pow(A, 2);
            Console.WriteLine("deseja fazer um novo cadastro ou acessar o atual??\n presione: (N) para Novo cadastro OU (A) para acessar o IMC salvo: ");
            Escolha = Console.ReadLine();

            switch (Escolha)
            {
                case "n": ; Cadastro(IMC);
                    break;

                case "a": ; Acessar(IMC);
                    break;

                default:
                    Console.WriteLine("Deveria presionar (A) ou (N). presione qualquer tecla para encerrar:");
                    break;
            }
            
            //Troca de Frase, utilizando método de String.
            Program p = new Program();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\npara nossa ULTIMA interação");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\ninforme uma frase");
            String Frase = "";
            Frase = Console.ReadLine();
            Console.WriteLine("Alterei um Pouco sua Frase, Olha ai como Ficou\n" + p.Alterar(Frase));
            Console.WriteLine("\n\naeeew finalizamos finalmente nossas interações, até a próxima");
            Console.WriteLine("precione qualquer tecla para sair");
            Console.ReadKey();
        }

        //método de cadastro para ser invocado no algoritimo de IMC
        private static void Cadastro(double IMC)
        {
            Double IMC2, A3, M2;
            Console.WriteLine("Para um novo cadastro é necessário alguns dados novamente");
            Console.Write("Informe seu Nome: ");
            string Nome3 = Console.ReadLine();
            Console.Write("Informe sua Idade: ");
            int Idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("informe sua massa em (Kg): ");
            M2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("informe sua Altura em (m): ");
            A3 = Convert.ToDouble(Console.ReadLine());
            IMC2 = M2 / Math.Pow(A3, 2);
            if ((IMC2 >= 18.25) && (IMC2 < 25))
            {
                Console.WriteLine("Seu IMC é: {0}, você está no peso ideal", Math.Round(IMC, 2));
            }
            else
            {
                Console.WriteLine("Seu IMC é: {0}, você está acima do peso", Math.Round(IMC, 2));
            }
            Console.ReadKey();
        }

        //método de acesso ao IMC salvo para ser invocado no algoritimo de IMC
        private static void Acessar(double IMC)
        {
            if ((IMC >= 18.25) && (IMC < 25))
            {
                Console.WriteLine("Seu IMC é: {0}, você está no peso ideal", Math.Round(IMC, 2));
            }
            else
            {
                Console.WriteLine("Seu IMC é: {0}, você está acima do peso", Math.Round(IMC, 2));
            }
            Press();
        }

        //método de string para alterar uma frase ou palavra sendo entrada em sistema
        private string Alterar(string Frase)
        {
            if (Frase.Trim().Length > 0)
            {
                int Total = Frase.Length;
                int Contador = 0;

                var StringBuilder = new StringBuilder(Frase);

                while (Contador < Total)
                {
                    if ((StringBuilder[Contador] == 'a') || (StringBuilder[Contador] == 'A'))
                    {
                        StringBuilder[Contador] = '&';
                    }
                    Contador++;
                }

                Frase = StringBuilder.ToString();

                return Frase;
            }
            else
            {
                return null;
            }
        }

        //método para esperar o úsuario a apertar enter
        private static void Press()
        {
            Console.WriteLine("pressione Enter para continuar");
            Console.ReadKey();
        }


        //validação de dados parte da criação de método para o algoritimo de entrada e validação de dados
        //(criar método com comando "Control.")
        private static void validacaodedados(out string NomeC, out string RG, out string CPF, out string Email, out double Dados)
        {
            Console.WriteLine("UFA, deu certo... Agora preciso que me informe alguns dados para continuarmos");
            Console.Write("Nome Completo: ");
            NomeC = Console.ReadLine();
            Console.Write("E-mail: ");
            Email = Console.ReadLine();
            Console.Write("RG: ");
            RG = Console.ReadLine();
            Console.Write("Telefone: ");
            CPF = Console.ReadLine();
            Console.WriteLine("\nVejamos... Seus dados são:\n" + "Telefone:" + CPF + " RG:" + RG);
            Console.WriteLine("Nome Completo: " + NomeC + " E-mail: " + Email);
            Console.WriteLine("\nConfirme com 1 para: SIM ou 2 para: NÂO se os dados estão corretos");
            Dados = 1;
            Dados = double.Parse(Console.ReadLine());
            if (Dados == 1)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nPERFEITO, Estamos indo Bem!!!");
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.WriteLine("\nEntão você informou os dados errados. (hehehe) por favor informe novamente.\n");
                validacaodedados(out NomeC, out RG, out CPF, out Email, out Dados);
            }
        }


        //validação de idade para acesso a calculadora
        //(criar método com comando "Control.")
        private static void ValidacaoAcesso(out double AN, out double ID)
        {
            Console.Write("Informe seu ano de nascimento: ");
            AN = double.Parse(Console.ReadLine());
            ID = DateTime.Now.Year - AN;
            if (ID > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nBOA, Acesso permitido");
                Console.ForegroundColor = ConsoleColor.Black;
                Press();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEita Acesso Negado");
                Console.ForegroundColor = ConsoleColor.Black;
                ValidacaoAcesso(out AN, out ID);
            }
        }

        //método para pedida de Nome
        private static string ResultName()
        {
            Console.WriteLine("Write first name: ");
            var firstName = Console.ReadLine();
            Console.WriteLine("Write last name: ");
            var lastName = Console.ReadLine();
            var result = firstName + " " + lastName;
            return result;
        }
    }
}