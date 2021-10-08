using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steroid_space_ship
{
    public class Bullet
    {
        public void main()
        {
            Timer timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timer1_Tick);
        }
        public static void timer1_Tick(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 39; j++)
                {
                    if (UI_menu.form.matrix[i, j] == 3)
                    {
                        if (j == 0)
                        {
                            UI_menu.form.matrix[i, j] = 0;
                            break;
                        }
                        UI_menu.form.matrix[i, j] = 0;
                        UI_menu.form.matrix[i, j - 1] = 3;
                    }

                }
            }
        }
        public void bullet(object sender, KeyEventArgs e)
        {

        }
    }
}
