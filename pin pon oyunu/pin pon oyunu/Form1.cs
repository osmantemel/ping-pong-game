using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pin_pon_oyunu
{
    public partial class form1 : Form
    {
        public int speed_left = 4;
        public int speed_top = 4;
        public int points = 0;
        private void Label2_Click(object sender, EventArgs e){}
       
        
        public form1()
        {
            InitializeComponent();
            
            Cursor.Hide(); // mausu gizler
            this.FormBorderStyle = FormBorderStyle.None;// form ekran kenarlıkları kaldırır
            this.TopMost = true;// form herzaman en üstte yer taşıyan özelliğini aktif ettik
            this.Bounds = Screen.PrimaryScreen.Bounds;// form çalıştırıldğında tüm ekran olarak açılır
            raket.Top = oyunekranı.Bottom - (oyunekranı.Bottom / 10);// bottom=oyun ekranının yüsekliği demek raketin konumunu atadık
           
            gameover.Left = oyunekranı.Width / 2 -( gameover.Width / 2);
            gameover.Top = oyunekranı.Height / 2 - (gameover.Height / 2);
            gameover.Visible = false;// form çalıştığında görünmeyecek anlamına gelir
        //    timer1.Enabled = true;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            raket.Left = Cursor.Position.X - (raket.Width / 2);
            ball.Left = ball.Left + speed_left;
            ball.Top = ball.Top + speed_top;


            if (ball.Left <= oyunekranı.Left)
            {
                speed_left = -speed_left;
            }
            if (ball.Right >= oyunekranı.Right)
            {
                speed_left = -speed_left;
            }
            if (ball.Top <= oyunekranı.Top)
            {
                speed_top = -speed_top;
            }


            if (ball.Bottom >= oyunekranı.Bottom)
            {

                gameover.Visible = true;
                timer1.Enabled = false;

            }

            if (ball.Bottom >= raket.Top && ball.Bottom <= raket.Bottom && raket.Left <= ball.Left && raket.Right >= ball.Right)
            {
                speed_top += 2;
                speed_left += 2;

                speed_top = -speed_top;
                points++;
                points_lbl.Text = Convert.ToString(points);
            }
        
           // Random R = new Random();
           // oyunekranı.BackColor = Color.FromArgb(R.Next(150,225), R.Next(150, 225), R.Next(150, 225));// ratagele renk yapıcam
        

        
        
        
        }

        private void form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
            if(e.KeyCode==Keys.F1)
            {
                ball.Top = 50;
                ball.Left = 50;
                points = 0;
                points_lbl.Text = "0";
                gameover.Visible = false;
                timer1.Enabled=true;
               // oyunekranı.BackColor = Color.White;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
        }
    }
}
