using System;
using System.Media;

namespace Jogo_GUI
{
    class Program
    {

        static void Main(string[] args)
        {
            Musica musica = new Musica();
            musica.tocar();

            Historia historia = new Historia();
            historia.InicioH();

            

           
            

            /*
            {

                Batalha batalha = new Batalha(avatar1, avatar2);
                batalha.IniciarBatalha();
                Console.ReadKey();
            }
            Console.ReadKey();
            Console.Clear();
            */

        }
       
    }
}
