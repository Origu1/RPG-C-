using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_GUI
{
    public class Chefao1 : NPC
    {
        public override void Falar()
        {
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" REVERTCHAN");
            Console.ReadKey();
            Console.ResetColor();
            Console.WriteLine(" ╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║ HAHAHAHA essa batalha será facil...                            ║");
            Console.WriteLine(" ║ Nós iremos te derrotar!!!                                      ║");
            Console.WriteLine(" ╙════════════════════════════════════════════════════════════════╜");
            Console.WriteLine();
            Console.ReadKey();
        }

        public Chefao1(int Level, int Forca, int baseHP, string Nome = "REVERTCHAN")
        {
            this.Nome = Nome;
            this._baseForca = Forca;
            this._baseHP = baseHP;
            this.Nome = " REVERTCHAN";
            this.Level = Level;
            this.HP = this.MaxHP;
        }

        public override int AtaqueBasico()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════════════════════════════════╗");
            Console.ResetColor();
            Console.WriteLine($@"   {Nome}: Ataque - BOMBA ÁCIDA {Forca * 2}  em -> Guerreiro    ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" ╚═══════════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine(" Pressione ENTER para continuar...");
            Console.ReadKey();
            Console.Clear();
            return Forca*2;
        }


      
    }
}
