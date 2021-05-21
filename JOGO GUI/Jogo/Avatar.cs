using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_GUI
{
    public class Avatar
    {
        
       public string Nome { get; set; }
       
       public int MaxHP { get; set; }

       public int HP { get; set; }

       public int Level {get; protected set; }

        
       public virtual int Forca { get; set; }

       public int Mp { get; set; } 

       public int MaxMp { get; set; }

       public virtual void Falar()
       {

       }
        public virtual void Historia()
        {

        }

        public virtual void Perso()
        {

        }

        public Boolean EstaVivo()
        {
            return (this.HP > 0);
        }

        public virtual int AtaqueBasico()
        {
            Console.WriteLine(" Ataque básico");
            return Forca;
        }
        public virtual void AtaqueBasico(Avatar oponente)
        {
            int ResultadoATK = this.AtaqueBasico();
            oponente.HP = oponente.HP - ResultadoATK;
        }

        public void ImprimirAcao(string Acao, int ValorAcao, Avatar Alvo=null)
        {

            Console.WriteLine(" ╔═══════════════════════════════════════════════════════════════════════════════════╗");
            if (Alvo == null)
                Console.WriteLine($"   { Nome} {Acao} {ValorAcao} ");

            else
                Console.WriteLine($"   { Nome} : {Acao} {ValorAcao}  em -> {Alvo.Nome}");
            Console.WriteLine(" ╚═══════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine(" Pressione ENTER para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
        
        public void ImprimirStatus()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════════════════════════════════╗");
            Console.ResetColor();
            Console.WriteLine($@"   {this.Nome} // HP: {this.HP} // Mana: {this.Mp}       ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" ╚═══════════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();


        }

        public int AutoCura()
        {
            int retorno = (Forca / 2) * Level;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" ╙═══════════════════════════════════════════════════════════════════════════════════╜");
            Console.ResetColor();
            ImprimirAcao(Acao: " Auto Cura", retorno);
            Console.WriteLine("");
            Console.WriteLine(" Pressione Enter para continuar");

            return retorno;

        }

        public virtual void AcaoNoTurno(Avatar oponente)
        {
          
       
            if (this.HP <= (this.MaxHP / 2))
            {
                
                this.HP = this.HP + AutoCura();
            }
            else
            {
                int ResultadoATK = this.AtaqueBasico();
                oponente.HP = oponente.HP - ResultadoATK;

            }

            return ;
        }

  
    }
}
