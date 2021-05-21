using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_GUI
{
    public class AvatarDeJogador : Avatar
    {
        public List<Acao> ListaAcao;
        public int XP { get; set; }
        public int MaxMP { get; set; }
        public int MP { get; set; }


        public AvatarDeJogador()
        {
            ListaAcao = new List<Acao>();
        }


        public virtual void LevelUP()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("  *****************************************");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("        Você subiu de nivel!!!");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("  *****************************************");
            Console.WriteLine();
            Console.ReadKey();

            this.MaxHP = this.MaxHP + 10;
            this.MaxMP = MaxMP +5;
            this.Forca = this.Forca++;

        }

        public bool verificarMp(int MP, int CustoMP)
        {
            bool GastoMP;

            if(Mp < CustoMP)
            {
                GastoMP = false;
                
            }
            else
            {
                GastoMP = true;
                
            }

            return (GastoMP);
        }
        public override void AcaoNoTurno(Avatar oponente)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════════════════════════════════╗");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("  * ESCOLHA AÇÃO DESEJADA PELO NUMERO (x): * ");

            Console.WriteLine();
            for (int i = 0; i < ListaAcao.Count; i++)
            {
                if (verificarMp(Mp, ListaAcao[i].CustoMP))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"   ({i}) : { ListaAcao[i].AcaoNome} - Custo: { ListaAcao[i].CustoMP}MP");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"   ({i}) : { ListaAcao[i].AcaoNome} - Custo: { ListaAcao[i].CustoMP}MP");
                    Console.ResetColor();
                }
                
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" ╚═══════════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(" Digite a opção da ação e pressione ENTER...");

            try
            {
                int AcaoEscolhida = Convert.ToInt32(Console.ReadLine());
                if (verificarMp(Mp, ListaAcao[AcaoEscolhida].CustoMP))
                {

                    Mp = Mp - ListaAcao[AcaoEscolhida].CustoMP;


                    ListaAcao[AcaoEscolhida].ResolverAcao(oponente);
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("  *** VOCÊ NÃO TEM MANA PARA ISSO!!! *** !");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.Clear();
                    AcaoNoTurno(oponente);
                }
            }
            catch (Exception e)
            {
        
                Console.Clear();
                AcaoNoTurno(oponente);

            }

        }

    }
    public delegate void AcaoJ(Avatar Alvo); 
    public class Acao
    {
        public String AcaoNome { get; set; }
        public int CustoMP { get; set; }
        public  AcaoJ ResolverAcao;

    }
}
