using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using WMPLib;
using System.IO;
using System.Resources;

namespace RomanTankonyv
{
    class Player
    {
        public void playSimpleSound(string media)
        {
            WindowsMediaPlayer mp = new WindowsMediaPlayer();
            byte[] b = (byte[]) Properties.Resources.ResourceManager.GetObject(media);
            FileInfo fileInfo = new FileInfo("play.mp3");
            FileStream fs = fileInfo.OpenWrite();
            fs.Write(b, 0, b.Length);
            fs.Close();
            mp.URL = fileInfo.Name;
            mp.controls.play();
        }
    }
}
