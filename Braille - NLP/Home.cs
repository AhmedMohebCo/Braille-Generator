using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Braille___NLP
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
        }

        //Checker Process
        private void Checker_Click(object sender, EventArgs e)
        {
            try
            {
                //Clear Shapes
                View_Shape.Refresh();
                List<Braille> Data = Braille.Understanding(Text_Input.Text);
                List<int> Op = Braille.Operations(Data);

                int[] Operations = Op.ToArray();
                int X = 5;
                int Y = 5;

                //Check Item Position
                foreach (var item in Operations)
                {
                    char[] value = item.ToString().ToCharArray();
                    if (X >= 820)
                    {
                        X = 5;
                        Y = 50;
                    }
                    Generate_Shapes(value, X, Y);
                    X += 35;
                }

                //Check If There're Any Operation
                if (Operations.Length == 0)
                {
                    MessageBox.Show("Characters Not Found", "Wait", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                Data.Clear();
                Op.Clear();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        //Position Circle
        private void Generate_Shapes(char[] Data,int X,int Y)
        {
            foreach (var Current in Data)
            {
                switch (Current)
                {
                    case '1':
                        Create_Shape(X, Y);
                        break;
                    case '2':
                        Create_Shape(X + 15, Y);
                        break;
                    case '3':
                        Create_Shape(X, Y + 15);
                        break;
                    case '4':
                        Create_Shape(X + 15, Y + 15);
                        break;
                    case '5':
                        Create_Shape(X, Y + 30);
                        break;
                    case '6':
                        Create_Shape(X + 15, Y + 30);
                        break;
                }
            }
        }

        //Create Circle
        private void Create_Shape(int X, int Y)
        {
            //Initialize Bounds
            Rectangle bounds = View_Shape.ClientRectangle;
            bounds.Height = 10;
            bounds.Width = 10;
            bounds.X = X;
            bounds.Y = Y;

            //Drawing The Circle
            Graphics Graph = View_Shape.CreateGraphics();
            using (Graph)
            {
                Graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Graph.FillEllipse(Brushes.Black, bounds);
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs About = new AboutUs();
            About.Show();
        }
    }
}
