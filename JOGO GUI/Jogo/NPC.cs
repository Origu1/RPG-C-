using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_GUI
{

    public class NPC : Avatar
    {
        protected int _baseHP;


        protected int _baseForca;

        protected int _baseMana;

        public Boolean Concluida = false;

        public void ImprimirNpc()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════════════════════════════════╗");
            Console.ResetColor();
            Console.WriteLine($@"   {this.Nome}        HP: {this.HP}        ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" ╚═══════════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
        }

   
        public int MaxHP
        {
            get { return _baseHP * this.Level; }
        }

        public override int Forca
        {
            get { return _baseForca + this.Level; }
        }
        
       public int MaxMp
        {
            get { return _baseMana + this.Level; }
        }

       
    }
}
