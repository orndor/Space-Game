using System;
using System.Collections.Generic;
using System.Text;
using System.Media;

namespace Space_Game
{
    class Bowser
    {
        public static void PlayMusic()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
            player.Play();

        }
    }
}
