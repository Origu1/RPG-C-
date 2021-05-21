using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_GUI
{
    public class Chefao3 : NPC
    {
        public override void Falar()
        {
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" PRIXY...");
            Console.ReadKey();
            Console.ResetColor();
            Console.WriteLine(" ╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║ Hummmmm um humano delicioso, já sei....                        ║");
            Console.WriteLine(" ║ HAHAHAHAHAH você será a minha JANTA !!!                        ║");
            Console.WriteLine(" ╙════════════════════════════════════════════════════════════════╜");
            Console.WriteLine();
            Console.ReadKey();
        }

        public override int AtaqueBasico()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════════════════════════════════╗");
            Console.ResetColor();
            Console.WriteLine($@"   {Nome}: Ataque - LANÇAR VENENO RADIOATIVO {Forca}  em -> Guerreiro    ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" ╚═══════════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine(" Pressione ENTER para continuar...");
            Console.ReadKey();
            Console.Clear();
            return Forca;
        }
        public Chefao3 (int Level, int Forca, int baseHP, string Nome = "PRIXY")
        {
            this.Nome = Nome;
            this._baseForca = Forca;
            this._baseHP = 70;
            this.Nome = "PRIXY";
            this.Level = Level;
            this.HP = this.MaxHP;
        }
        
        
       
        
    }
}
