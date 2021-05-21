using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; 
using System.Threading.Tasks;

namespace Jogo_GUI
{
    public class Fase
    {
        private AvatarDeJogador Jogador1 = new AvatarDeJogador();


        public List<NPC> Inimigos = new List<NPC>();

        public int Pedacos = 0;


        

        public void JogarFase()
        {
            while (Pedacos != 3)
            {
                GerenciarBatalha(EscolhaInimigos());
            }

            Chefao4 Chef4 = new Chefao4(1, 16, 100);
            Console.Clear();
            Chef4.Falar();

            GerenciarBatalha(Chef4);


        }

        

        public void GerenciarBatalha(NPC Inimigo)
        {
            Jogador1.HP = Jogador1.MaxHP;
            Jogador1.Mp = Jogador1.MaxMP;

            Batalha batalha = new Batalha(Jogador1, Inimigo);
            Avatar Vencedor = batalha.IniciarBatalha();

            if (Jogador1.Equals(Vencedor))
            {
                Pedacos++;  
                Jogador1.LevelUP();
                Inimigo.Concluida = true;
            }
            else 
            {
               
            }
            
        }

        public Fase(AvatarDeJogador Jogador1)
        {
            this.Jogador1 = Jogador1;
            Inimigos = new List<NPC>();

            Chefao1 Chef1 = new Chefao1(1, 7, 30);

            Chefao2 Chef2 = new Chefao2(1, 10, 45);

            Chefao3 Chef3 = new Chefao3(1, 13, 70);


            Inimigos.Add(Chef1);
            Inimigos.Add(Chef2);
            Inimigos.Add(Chef3);

        }

        public NPC EscolhaInimigos()
        {

            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" WALDIR O CABRA BÃO...");
            Console.ResetColor();
            Console.WriteLine(" ╔════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║Sua missão é simples nobre guerreiro, você precisa da chave para abrir o cadeado que prende             ║" + Environment.NewLine +
                " ║nosso rei na cela, tive visões de 3 pedaços de um item de ouro, suponho que seja a chave que precisamos ║" + Environment.NewLine +
                " ║e estavam em posse de 3 orc's que fazem a segurança do orc superior RIKO então derrote os 3 orc's       ║" + Environment.NewLine +
                " ║junte os pedaçoes e liberte nosso rei...                                                                ║");
            Console.WriteLine(" ╙════════════════════════════════════════════════════════════════════════════════════════════════════════╜");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ╔═════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║        SELECIONE CONTRA QUEM VOCÊ QUER LUTAR        ║");
            Console.WriteLine(" ╙═════════════════════════════════════════════════════╜");
            Console.WriteLine();
            Console.WriteLine();


            for (int ContadorInimigos = 0; ContadorInimigos < Inimigos.Count; ContadorInimigos++)
            {


                if (Inimigos[ContadorInimigos].Concluida == false)
                {
                    Console.WriteLine("    ╔════════════════════╗");
                    Console.WriteLine(" " + ContadorInimigos + ")    " + Inimigos[ContadorInimigos].Nome);
                    Console.WriteLine("    ╙════════════════════╜");
                }



            }

            Console.WriteLine();
            Console.WriteLine(" Digite uma opção da sua escolha do 0 ~ 3 e pressione ENTER...: ");
            
            try
            {
                int Escolha = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Jogador1.Falar();
                Inimigos[Escolha].Falar();

                return (Inimigos[Escolha]);
            }
            catch (Exception e)
            {
                //mensagem para indicar QUE PRESSIONOU ALGO ERRADO
                Console.Clear();
                EscolhaInimigos();
                return (Inimigos[1]);

            }


        }

    }
}
