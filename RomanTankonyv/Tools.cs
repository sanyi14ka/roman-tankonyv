using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Drawing;

namespace RomanTankonyv
{
    
    class Tools
    {
        public Image[] images = new Image[10];
        public int currentBackgroundIndex;
        public void ClearButtons(Form f)
        {
            for (int i = 0; i < f.Controls.Count; i++)
            {
                if (f.Controls[i] is Button)
                {
                    
                    //todo put condition to prevent removing of forward and back buttons
                    f.Controls.RemoveAt(i);
                    i--;
                }
            }
        }

        public void ChangeBackground(Form f, int n)
        {
            f.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + n.ToString());
            f.BackgroundImageLayout = ImageLayout.Stretch;
        }

    }
}
