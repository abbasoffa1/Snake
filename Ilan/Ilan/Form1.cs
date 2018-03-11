using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ilan
{
    public partial class Form1 : Form
    {
        int currentLeft;
        int currentTop;
        int size = 30;
        List<int> kordinat = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btn.Width = size;
            btn.Height = size;
            btn.Left = currentLeft;
            btn.Top = currentTop;
            bt.Width = size;
            bt.Height = size;
            
            int list_count = 0;
            for (int i = 0; i < 20; i++)
            {
                kordinat.Add(list_count);
                list_count += size;
            }
            Create_Eat();
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {           
            if (e.KeyCode == Keys.W)
            {
                if (btn.Location.X.ToString() == bt.Location.X.ToString() && btn.Location.Y.ToString() == bt.Location.Y.ToString())
                {
                    btn.Width = btn.Width += size / 2;
                    btn.Height = btn.Height += size / 2;
                    Create_Eat();    
                }
              
                currentTop -= 30;
                btn.Top = currentTop;
                if ((btn.Top < 0) || (this.Width == btn.Top) || (this.Width - 36 < btn.Top))
                {
                    MessageBox.Show("Game Over");
                }
            }
            else if (e.KeyCode == Keys.S)
            {
                if (btn.Location.X.ToString() == bt.Location.X.ToString() && btn.Location.Y.ToString() == bt.Location.Y.ToString())
                {
                    btn.Width = btn.Width += size / 2;
                    btn.Height = btn.Height += size / 2;
                    Create_Eat();
                }
               
                currentTop += 30;
                btn.Top = currentTop;
                if ((btn.Top < 0) || (this.Width == btn.Top) || (this.Width - 36 < btn.Top))
                {
                    MessageBox.Show("Game Over");
                }
            }
            else if (e.KeyCode == Keys.A)
            {
                if (btn.Location.X.ToString() == bt.Location.X.ToString() && btn.Location.Y.ToString() == bt.Location.Y.ToString())
                {
                    btn.Width = btn.Width += size / 2;
                    btn.Height = btn.Height += size / 2;
                    Create_Eat();
                }
               
                currentLeft -= 30;
                btn.Left = currentLeft;
                if ((btn.Left < 0) || (this.Width == btn.Left) || (this.Width - 36 < btn.Left))
                {
                    MessageBox.Show("Game Over");
                }
            }
            else if (e.KeyCode == Keys.D)
            {
                if (btn.Location.X.ToString() == bt.Location.X.ToString() && btn.Location.Y.ToString() == bt.Location.Y.ToString())
                {
                    btn.Width = btn.Width += size / 2;
                    btn.Height = btn.Height += size / 2;
                    Create_Eat();
                }
               
                currentLeft += 30;
                btn.Left = currentLeft;
                if ((btn.Left < 0) || (this.Width == btn.Left) || (this.Width - 36 < btn.Left))
                {
                    MessageBox.Show("Game Over");
                }
            }
        }
        private void Create_Eat()
        {
            Random rand = new Random();
            bt.Left = kordinat[rand.Next(0, kordinat.Count)];
            bt.Top = kordinat[rand.Next(0, kordinat.Count)];

        }
        private void Uzanmag()
        {
            var SnakeBody = new SnakeBody();
            
        }
        
    }
    public class SnakeBody
    {
        public string Tail;
        public string Head;
        public SnakeBody()
        {
           
        }
    }
}
