﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criptocode
{
    class Program
    {

        
    static int atribuirOpcao(int _opc)
            {

                int alternativa;
                string mensagem, cript = "";
                int senha, i, senhacorreta = 246897531;
                switch (_opc)
                {

                    case 1:
                        alternativa = 1; Console.WriteLine("Digite a senha de acesso, Você tem três tentativas: ");
                        senha = int.Parse(Console.ReadLine());

                        for (i = 0; i < 2 & senha != senhacorreta; i++)
                        {
                            Console.WriteLine("Senha incorreta, Digite a novamente: ");
                            senha = int.Parse(Console.ReadLine());
                        }
                        if (senha == senhacorreta)
                        {
                            Console.WriteLine("=================================CRIPTOCODE UNLOCKED===========================================================================================================================================================================================================================================================================================================================");
                            Console.WriteLine("Os produtos sigilosos encontrados e no navio são:" +
                                        "O plutônico foi fabricado pela primeira vez em 1941 o ser humano não tinha a consciência de que estava produzindo um elemento extremamente perigoso. " +
                   "                     O Pu é usado para fazer bombas atômicas. Porém, o elemento também é importante por sua capacidade de gerar energia nuclear. Por conta disso tudo, o plutônio é extremamente tóxico." +
                "                        O Mercúrio, Longe de você, esse elemento químico realmente não causa estragos. Ele é até chamativo, com uma coloração prateada e a capacidade de ficar em estado líquido em temperatura ambiente. Porém, se ingerido ou permanecer durante longos períodos em contato com a pele, podemos classificar o mercúrio como um dos elementos químicos mais perigosos." +
             "                           Arsênio, assim como o mercúrio, o arsênio (As) é muito tóxico para os seres humanos. Nos tempos de Shakespeare, as mulheres usavam esse elemento químico para matar seus inimigos e maridos. Naquela época, esse composto era responsável por uma morte rápida e silenciosa. Hoje, porém, já existem indícios quando uma pessoa morre por envenenamento de arsênio." +
             "                           Por conta de sua periculosidade e tais produtos se encontram no Porto de Manaus com restrição total da sociedade.");
                        }
                        else
                            Console.WriteLine("079 115 032 112 114 111 100 117 116 111 115 032 115 105 103 105 108 111 115 111 115 032 101 110 099 111 110 116 114 097 100 111 115 032 101 032 110 111 032 110 097 118 105 111 032 115 195 163 111 058 013 010 009 009 009 009 009 009 009 009 009 079 032 112 108 117 116 195 180 110 105 099 111 032 102 111 105 032 102 097 098 114 105 099 097 100 111 032" +
                                " 112 101 108 097 032 112 114 105 109 101 105 114 097 032 118 101 122 032 101 109 032 049 057 052 049 032 111 032 115 101 114 032 104 117 109 097 110 111 032 110 195 163 111 032 116 105 110 104 097 032 097 032 099 111 110 115 099 105 195 170 110 099 105 097 032 100 101 032 113 117 101 032 101 115 116 097 118 097 032 112 114 111 100 117 122 105 110 100 111 032 117" +
           " 109 032 101 108 101 109 101 110 116 111 032 101 120 116 114 101 109 097 109 101 110 116 101 032 112 101 114 105 103 111 115 111 046 032 013 010 009 009 009 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 079 032 080 117 032 195 169 032 117 115 097 100 111 032 112 097 114 097 032 102 097 122 101 114 032 098 111 109 098 097 115 032 097 116" +
        " 195 180 109 105 099 097 115 046 032 080 111 114 195 169 109 044 032 111 032 101 108 101 109 101 110 116 111 032 116 097 109 098 195 169 109 032 195 169 032 105 109 112 111 114 116 097 110 116 101 032 112 111 114 032 115 117 097 032 099 097 112 097 099 105 100 097 100 101 032 100 101 032 103 101 114 097 114 032 101 110 101 114 103 105 097 032 110 117 099 108 101 097 114 046 032 080 111 " +
     "114 032 099 111 110 116 097 032 100 105 115 115 111 032 116 117 100 111 044 032 111 032 112 108 117 116 195 180 110 105 111 032 195 169 032 101 120 116 114 101 109 097 109 101 110 116 101 032 116 195 179 120 105 099 111 046 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 079 032 077 101 114 099 195 186 114 105 111 044 032 076 111 110 103 101 032 100 101" +
     " 032 118 111 099 195 170 044 032 101 115 115 101 032 101 108 101 109 101 110 116 111 032 113 117 195 173 109 105 099 111 032 114 101 097 108 109 101 110 116 101 032 110 195 163 111 032 099 097 117 115 097 032 101 115 116 114 097 103 111 115 046 032 069 108 101 032 195 169 032 097 116 195 169 032 099 104 097 109 097 116 105 118 111 044 032 099 111 109 032 117 109 097 032 099 111 108 111 114 097 " +
     "195 167 195 163 111 032 112 114 097 116 101 097 100 097 032 101 032 097 032 099 097 112 097 099 105 100 097 100 101 032 100 101 032 102 105 099 097 114 032 101 109 032 101 115 116 097 100 111 032 108 195 173 113 117 105 100 111 032 101 109 032 116 101 109 112 101 114 097 116 117 114 097 032 097 109 098 105 101 110 116 101 046 032 080 111 114 195 169 109 044 032 115 101 032 105 110 103 101 114" +
     " 105 100 111 032 111 117 032 112 101 114 109 097 110 101 099 101 114 032 100 117 114 097 110 116 101 032 108 111 110 103 111 115 032 112 101 114 195 173 111 100 111 115 032 101 109 032 099 111 110 116 097 116 111 032 099 111 109 032 097 032 112 101 108 101 044 032 112 111 100 101 109 111 115 032 099 108 097 115 115 105 102 105 099 097 114 032 111 032 109 101 114 099 195 186 114 105 111 032 099" +
     " 111 109 111 032 117 109 032 100 111 115 032 101 108 101 109 101 110 116 111 115 032 113 117 195 173 109 105 099 111 115 032 109 097 105 115 032 112 101 114 105 103 111 115 111 115 046 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 065 114 115 195 170 110 105 111 044 032 097 115 115 105 109 032 099 111 109 111 032 111 032 109 101 114 099 195 186 114 105 111 044 032 111" +
     " 032 097 114 115 195 170 110 105 111 032 040 065 115 041 032 195 169 032 109 117 105 116 111 032 116 195 179 120 105 099 111 032 112 097 114 097 032 111 115 032 115 101 114 101 115 032 104 117 109 097 110 111 115 046 032 078 111 115 032 116 101 109 112 111 115 032 100 101 032 083 104 097 107 101 115 112 101 097 114 101 044 032 097 115 032 109 117 108 104 101 114 101 115 032 117 115 097 118 097" +
     " 109 032 101 115 115 101 032 101 108 101 109 101 110 116 111 032 113 117 195 173 109 105 099 111 032 112 097 114 097 032 109 097 116 097 114 032 115 101 117 115 032 105 110 105 109 105 103 111 115 032 101 032 109 097 114 105 100 111 115 046 032 078 097 113 117 101 108 097 032 195 169 112 111 099 097 044 032 101 115 115 101 032 099 111 109 112 111 115 116 111 032 101 114 097 032 114 101 115 112" +
     " 111 110 115 195 161 118 101 108 032 112 111 114 032 117 109 097 032 109 111 114 116 101 032 114 195 161 112 105 100 097 032 101 032 115 105 108 101 110 099 105 111 115 097 046 032 072 111 106 101 044 032 112 111 114 195 169 109 044 032 106 195 161 032 101 120 105 115 116 101 109 032 105 110 100 195 173 099 105 111 115 032 113 117 097 110 100 111 032 117 109 097 032 112 101 115 115 111 097 032 " +
     "109 111 114 114 101 032 112 111 114 032 101 110 118 101 110 101 110 097 109 101 110 116 111 032 100 101 032 097 114 115 195 170 110 105 111 046 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 032 080 111 114 032 099 111 110 116 097 032 100 101 032 115 117 097 032 112 101 114 105 099 117 108 111 115 105 100 097 100 101 032 101 032 116 097 105 115 032 112 114 111 100 117 116 111" +
     " 115 032 115 101 032 101 110 099 111 110 116 114 097 109 032 110 111 032 080 111 114 116 111 032 100 101 032 077 097 110 097 117 115 032 099 111 109 032 114 101 115 116 114 105 195 167 195 163 111 032 116 111 116 097 108 032 100 097 032 115 111 099 105 101 100 097 100 101 046 ");
                        break;

                    case 2:
                        alternativa = 2; Console.WriteLine("Escreva uma mensagem a ser criptografada: ");
                        mensagem = Console.ReadLine().ToLower().ToUpper();

                        for (int k = 0; k < mensagem.Length; k++)
                        {
                            int ASCII = (int)mensagem[k];

                            int ASCIIC = ASCII + 4;

                            cript += Char.ConvertFromUtf32(ASCIIC);
                        }

                        Console.WriteLine("A chave criptográfica da mensagem é: " + cript);
                        Console.ReadKey();
                        break;

                    case 3:
                        alternativa = 3; Console.WriteLine("Insira a chave criptográfica correta para ler a mensagem: ");


                        mensagem = Console.ReadLine().ToLower();

                        for (int k = 0; k < mensagem.Length; k++)

                        {

                            int ASCII = (int)mensagem[k];
                            int ASCIIC = ASCII - 4;

                            cript += Char.ConvertFromUtf32(ASCIIC);

                        }

                        Console.Write("Text: {0}", cript);

                        Console.ReadKey();

                        break;
                    case 4: alternativa = 4; Console.WriteLine("O programa será encerrado"); break;
                    default:
                        alternativa = 4; Console.WriteLine("Não há comando para esta tecla,Pressione qualquer tecla para sair do programa !!!"); break;

                }
                return alternativa;
            }
            static void Main(string[] args)
            {
                int opc, alternativa;
                string alt;
                do
                {
                   Console.BackgroundColor = ConsoleColor.DarkBlue;
                   Console.ForegroundColor = ConsoleColor.White;
                   Console.Clear();

                    Console.WriteLine("Sistema de acesso a produtos restritos por serem perigosos, somente pessoas autorizadas podem ter o acesso ao sistema e ao" +
                        "físico, por isso é necessários que qualquer tipo de pessoa não ultrapasse os 50 quilômetros de distância dos tais produtos !!! ");
                    Console.WriteLine("");
                    Console.WriteLine("================================CRIPTOCODE======================================");
                    Console.WriteLine("====Pressione a numeração específica para a seguinte tomada de decisão==========");
                    Console.WriteLine("1-) Logar no sistema: ");
                    Console.WriteLine("2-) Criptografar Texto: ");
                    Console.WriteLine("3-) Descriptografar Texto: ");
                    Console.WriteLine("4-) Sair do programa: ");

                    opc = int.Parse(Console.ReadLine());
                    alternativa = atribuirOpcao(opc);
                    Console.WriteLine("Deseja continuar? (S)sim, (N)não");
                    string opci = Console.ReadLine(); opci.ToUpper(); opci.ToLower();
                    switch (opci)
                    {
                        case "s": alt = "s"; break;
                        case "n": alt = "n"; break;
                        default: alt = "s"; break;
                    }
                    Console.Clear();
                }
                while (alt == "s");

                Console.ReadKey();


            }
    }
}
