using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_GUI
{
    public class Chefao2 : NPC
    {
        public override void Falar()
        {
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" IBIRAPUERA...");
            Console.ResetColor();
            Console.WriteLine(" ╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║ Oh vou aniquilar sua raça seu imundo....                       ║");
            Console.WriteLine(" ║ Me vingarei da morte de meu filho RIAAN, Morraaaaa!!!          ║");
            Console.WriteLine(" ╙════════════════════════════════════════════════════════════════╜");
            Console.WriteLine();
            Console.ReadKey();
        }

        public override int AtaqueBasico()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════════════════════════════════╗");
            Console.ResetColor();
            Console.WriteLine($@"   {Nome}: Ataque - DELETE HUMANO FROM TERRA {Forca}  em -> Guerreiro    ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" ╚═══════════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine(" Pressione ENTER para continuar...");
            Console.ReadKey();
            Console.Clear();
            return Forca;
        }

        public Chefao2(int Level, int Forca, int baseHP, string Nome = "IBIRAPUERA")
        {
            this.Nome = Nome;
            this._baseForca = Forca;
            this._baseHP = 50;
            this.Nome = "IBIRAPUERA";
            this.Level = Level;
            this.HP = this.MaxHP;
        }

    
    }
}
