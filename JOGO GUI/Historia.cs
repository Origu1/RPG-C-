using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_GUI
{
    public class Historia 
    {
        private AvatarDeJogador Jogador1 = new AvatarDeJogador();


        public void InicioH()
        {
            Console.WriteLine("");
            Console.WriteLine("      #======================================================================================# ");
            Console.WriteLine("      |                                                                                      | ");
            Console.WriteLine("      |                                                                                      | ");
            Console.WriteLine("      | *      *      *       *    *_m_m_                    _m_m_    *         *       *    | ");
            Console.WriteLine("      |    *       *       *        | @ |                    | @ |         *       *       * | ");
            Console.WriteLine("      | *     *   dd     *       * d|   |BOM JOGO E BOA SORTE|   |   *        *         *    | ");
            Console.WriteLine("      |         ,dPBd            dss| @ |                    | @ |                           | ");
            Console.WriteLine("      |        /sBDDBS,        ,sdPB|   |^^^^^^^__^^^__^^^^^^|   |{**}          {**}         | ");
            Console.WriteLine("      |      ,/   __/  ,     .d$$$$$|   |                    |   | ||      {**}  ||      {**}| ");
            Console.WriteLine("      |     /    /   :  ,   d$P´´Y´´|   |    INICIO DE JOGO  |   |   {**}   ||   {**}     || | ");
            Console.WriteLine("      |   _/   .   _/    `__/  :   /|   |         ___        |   |    ||{**}  {**}||  {**}   | ");
            Console.WriteLine("      |  /    /   /     /    /  `   |m_m_m_m_m_m_|===|_m_m_m_m_m_|       ||    ||      ||    | ");
            Console.WriteLine("      |_/______________/____________|           |=====|          |___________________________| ");
            Console.WriteLine("      |                                                                                      | ");
            Console.WriteLine("      |                                                                                      | ");
            Console.WriteLine("      |                          BEM VINDO AO JOGO: RESGATE AO REI                           | ");
            Console.WriteLine("      |                                                                                      | ");
            Console.WriteLine("      #======================================================================================# \n\n\n ");
            Console.WriteLine(" Pressione ENTER para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n HISTÓRIA:");
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║ Em uma noite chuvosa o exercito dos orcs capituraram o rei Luciano que comandava  ║" + Environment.NewLine +
                " ║ as vastas terras do reino de Sorocaba.                                            ║" + Environment.NewLine +
                " ║ Sem um rei para impor ordem, todo o reino caia em desgraça, Sorocaba já nao erá   ║" + Environment.NewLine +
                " ║ mais a mesma de antes, uma noite um profeta com o nome de Waldir mais conhecido   ║" + Environment.NewLine +
                " ║ como O CABRA BÃO recebeu um pressagio de 3 nobres guerreiro que possuiam forças   ║" + Environment.NewLine +
                " ║ suficientes para derrotar os orcs e resgatar o seu Rei, assim mandou os ultimos   ║" + Environment.NewLine +
                " ║ guardas do reino em busca dos 3 nobres guerreiros para ajudar no resgate do  Rei  ║");
            Console.WriteLine(" ╙═══════════════════════════════════════════════════════════════════════════════════╜");
            Console.WriteLine("");
            Console.WriteLine(" Pressione ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();

            EscolhaDeJogador();

          
            Fase fase1 = new Fase(Jogador1);
            fase1.JogarFase();

            Final();
        }

        private void Final()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" ╔══════════════════════════════════════════╗");
            Console.WriteLine(" ║     PARABENS VOCÊ CHEGOU NO FINAL!!!     ║");
            Console.WriteLine(" ╙══════════════════════════════════════════╜");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("  VOCÊ TEM UMA ESCOLHA DIFICIL AGORA...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" ╔══════════════════════════════════════════╗");
            Console.WriteLine(" ║     Deseja libertar o rei Luciano ?      ║");
            Console.WriteLine(" ╙══════════════════════════════════════════╜");
            Console.WriteLine();
            Console.WriteLine(" Pressione (S) para sim ou (N) para não!");
            Console.WriteLine();
            string Resposta = Console.ReadLine();

            if (Resposta == "s")
            {
                Console.WriteLine(" Você escolheu libertar o rei Luciano");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" WALDIR O CABRA BÃO...");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine(" ╔═════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine(" ║ OBRIGADO NOBRE GUERREIRO, VOCÊ SERA EXALTADO EM SUA VOLTA E SERA RECONHECIDO COMO UM CABRA BÃOOO!!! ║");
                Console.WriteLine(" ╙═════════════════════════════════════════════════════════════════════════════════════════════════════╜");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(" Você escolheu deixar o rei apodrecer e se tornou o rei de Sorocaba");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Magenta; 
                Console.WriteLine("  WALDIR O CABRA BÃO...");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine(" ╔═══════════════════════════════════════════════════════════════╗");
                Console.WriteLine(" ║ Ó MINHAS VISÕES, ISSO NÃO ERA POSSIVEL, SEU TRAIDOR           ║"); 
                Console.WriteLine(" ╙═══════════════════════════════════════════════════════════════╜");
                Console.ReadKey();
               
            }
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("       *Criadores* ");
            Console.WriteLine(" GUILHERME BATISTA GARCIA ");
            Console.WriteLine(" SUELEN CRISTINA GOMES FELIZARDO ");
           

        }

        public void EscolhaDeJogador()
        {
            Cavaleiro Jeremias = new Cavaleiro();

            Arqueiro IndioAj = new Arqueiro();

            Mago FelipeSmith = new Mago();


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" #══════════════════════════════#");
            Console.WriteLine(" ║   Escolha o seu personagem ! ║ ");
            Console.WriteLine(" #══════════════════════════════#");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 1) Jeremias.");
            Console.ResetColor();

            Jeremias.Historia();


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" 2) Indio Ana Jones");
            Console.ResetColor();



            IndioAj.Historia();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" 3) Felipe Smith");
            Console.ResetColor();

            FelipeSmith.Historia();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Digite o numero que corresponde ao personagem e pressione ENTER...");


            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Jogador1 = Jeremias;
                        break;
                    }

                case "2":
                    {
                        Jogador1 = IndioAj;
                        break;
                    }

                case "3":
                    {
                        Jogador1 = FelipeSmith;
                        break;
                    }
                default:
                    {
                        Console.WriteLine(" Nenhuma opção possivel selecionada ! ");
                        Console.ReadKey();
                        EscolhaDeJogador();



                        break;
                    }

            }



        }
    }
}
