using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Media;

namespace Jogo_GUI
{
    public class Musica
        {
            private SoundPlayer player;
            private string PATH_MUSICA = "C:/Users/guiba/OneDrive/Desktop/Nova pasta (3)/Trabalho Jogo RPG/JOGO GUI/assets/rpg-music.wav";
            public Musica()
            {
                this.player = new SoundPlayer(PATH_MUSICA);
                this.player.Load();
            }

            public void tocar()
            {
                this.player.PlayLooping();
            }
        }
    
}
