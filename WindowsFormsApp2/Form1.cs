using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

            //Point res = new Point(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y)
            
            t.Interval = 100; // specify interval time as you want
            bool fshown = true;
            t.Tick += new EventHandler(timer_Tick);
            t.Start();


            void timer_Tick(object sender, EventArgs e)
            {

                int resx = Screen.PrimaryScreen.Bounds.Width -20;
                
                if (fshown)
                {
                    if (Cursor.Position.X > resx)
                    {
                        t.Stop();
                        MoveForm(true);
                        fshown = false;
                    }
                }
                else
                {
                    resx -= 180;
                    if (Cursor.Position.X < resx)
                    {
                        t.Stop();
                        MoveForm(false);
                        fshown = true;
                    }
                }

            }

            InitializeComponent();


            void MoveForm(bool action)
            {
                //System.Windows.Forms.Timer x = new System.Windows.Forms.Timer();
                //true to Show form false to hide
                System.Windows.Forms.Timer t2 = new System.Windows.Forms.Timer();

                //Point res = new Point(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y)

                int i = 20;
                int dist = 0;
                t2.Interval = 1; // specify interval time as you want
                t2.Tick += new EventHandler(timer_Tick2);
                t2.Start();
                if (action)
                {
                    dist = 10;

                }
else
                {
                    dist= -10;
                }

                void timer_Tick2(object sender, EventArgs e)
                {
                    if (i < 1) { t2.Stop();
                    } else {
                        this.Location = new Point(this.Location.X - dist, this.Location.Y);
                        i--;
                    }
                }
                t.Start();
            }


        }


        //private void Form1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    /// sets mouse pointer to top left
        //    ///int x = new int();
        //    ///int y = new int();
        //    ///Cursor.Position = new Point(x, y);
        //    ///
        //    label1.Text = string.Format("x: {0}; y: {1}", Cursor.Position.X, Cursor.Position.Y);

        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
