using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Jogo_GUI
{
   public class Batalha
    {
        public AvatarDeJogador Jogador1;
        public NPC Jogador2;
        public int ContadorDeTurno;

        public Avatar Vencedor;

        public Batalha(AvatarDeJogador Jogador1, NPC Jogador2)
        {
            
            this.Jogador1 = Jogador1;
            this.Jogador2 = Jogador2;
            ContadorDeTurno = 1;
        }
   
        public Avatar IniciarBatalha()
        {
        
            while (Jogador1.EstaVivo() && Jogador2.EstaVivo())
            {
                ImprimirInfoDoTurno();
                //Deseja pausar turno a turno
               // Console.ReadKey();
                // Console.Clear(); 
                if (ContadorDeTurno % 2 == 0) // turno do jogador 2
                {
                    Jogador2.AcaoNoTurno(Jogador1);
                   
                }
                else // turno do jogador 1
                {
                    Jogador1.AcaoNoTurno(Jogador2);
                }

                

                ContadorDeTurno++;
                
            }
            ImprimirInfoDoTurno();
            

            VerificarVencedor();
            Console.Clear();

            
            if (Vencedor is null) // caso empate
               
            Console.WriteLine("Empate");
            
            else if (Vencedor.Equals(Jogador1))
            {
                
                Console.ResetColor();
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" ╔═══════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("");
                Console.WriteLine($@"              {Vencedor.Nome} Venceu a batalha !!!                          ");
                Console.WriteLine("");
                Console.WriteLine(" ╚═══════════════════════════════════════════════════════════════════════════╝");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ╔═══════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("");
                Console.WriteLine($@"                   VOCÊ FALHOU NA SUA MISSÃO !!!!                           ");
                Console.WriteLine("");
                Console.WriteLine(" ╚═══════════════════════════════════════════════════════════════════════════╝");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

                Historia historia = new Historia();
                historia.InicioH();
                Console.Clear();
            }
            return Vencedor;

          
        }

        

        private void ImprimirInfoDoTurno()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("                            ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                            ╓═══════════╖");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($@"                              Turno: {this.ContadorDeTurno}");;
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                            ╙═══════════╜");
            Console.ResetColor();
            Jogador1.ImprimirStatus();
            Jogador2.ImprimirNpc();
        }

        private Avatar VerificarVencedor()
        {
            if (Jogador1.EstaVivo())
                Vencedor = Jogador1;
            else if (Jogador2.EstaVivo())
                Vencedor = Jogador2;

            return Vencedor;
        }
    }
}
