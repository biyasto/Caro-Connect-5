using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using WMPLib;
using System.Text;
using System.Threading.Tasks;

namespace Caro
{
    static class sound
    {
        public static void Play(SoundPlayer s)
        {
            if (Sound_on)
                s.Play();
            else
                s.Stop();
        }
        static public bool Sound_on = true;
        static public SoundPlayer click = new SoundPlayer(Properties.Resources.click);
        static public SoundPlayer click2 = new SoundPlayer(Properties.Resources.click2);
        static public SoundPlayer announce = new SoundPlayer(Properties.Resources.announce);
        static public SoundPlayer start = new SoundPlayer(Properties.Resources.start);
        static public SoundPlayer victory = new SoundPlayer(Properties.Resources.victory);
        static public SoundPlayer tie = new SoundPlayer(Properties.Resources.tie);
        static public SoundPlayer p1 = new SoundPlayer(Properties.Resources.P1);
        static public SoundPlayer p2 = new SoundPlayer(Properties.Resources.P2);

        static public bool Theme_on = true;
        static public WMPLib.WindowsMediaPlayer theme_player = new WMPLib.WindowsMediaPlayer();

        public static void Theme_start()
        {
            sound.theme_player.URL = "theme.mp3";
            sound.theme_player.controls.stop();
            theme_player.settings.setMode("loop", true);
        }
        public static void PlayTheme(bool ON)
        {
           
            if (ON)
            {
                
                if (Theme_on) theme_player.controls.play();
            }
            else  theme_player.controls.pause();
            
        }
       
    }
}
