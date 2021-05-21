using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_GUI
{
    public class Chefao4 : NPC
    {
        public override void Falar()
        {
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" RIKO...");
            Console.ReadKey();
            Console.ResetColor();
            Console.WriteLine(" ╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║ Oh não outro humano para encher o saco... !!!                  ║");
            Console.WriteLine(" ║ Tu não chegara perto daquele cadeado HAHAHA ... !!!            ║"); 
            Console.WriteLine(" ╙════════════════════════════════════════════════════════════════╜");
            Console.WriteLine();
            Console.ReadKey();
        }
        public override int AtaqueBasico()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════════════════════════════════╗");
            Console.ResetColor();
            Console.WriteLine($@"   {Nome}: Ataque - RAIO TECNOLÓGICO {Forca}  em -> Guerreiro    ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" ╚═══════════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine(" Pressione ENTER para continuar...");
            Console.ReadKey();
            Console.Clear();
            return Forca;
        }

    public Chefao4(int Level, int Forca, int baseHP, string Nome = "RIKO")
        {
            this.Nome = Nome;
            this._baseForca = Forca;
            this._baseHP = 100;
            this.Nome = "RIKO";
            this.Level = Level;
            this.HP = this.MaxHP;
        }

      
    }
}
