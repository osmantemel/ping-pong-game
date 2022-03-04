namespace pin_pon_oyunu
{
    partial class form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.oyunekranı = new System.Windows.Forms.Panel();
            this.gameover = new System.Windows.Forms.Label();
            this.points_lbl = new System.Windows.Forms.Label();
            this.score__lbl = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.raket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.oyunekranı.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raket)).BeginInit();
            this.SuspendLayout();
            // 
            // oyunekranı
            // 
            this.oyunekranı.BackColor = System.Drawing.Color.Pink;
            this.oyunekranı.Controls.Add(this.gameover);
            this.oyunekranı.Controls.Add(this.points_lbl);
            this.oyunekranı.Controls.Add(this.score__lbl);
            this.oyunekranı.Controls.Add(this.ball);
            this.oyunekranı.Controls.Add(this.raket);
            this.oyunekranı.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oyunekranı.Location = new System.Drawing.Point(0, 0);
            this.oyunekranı.Name = "oyunekranı";
            this.oyunekranı.Size = new System.Drawing.Size(800, 450);
            this.oyunekranı.TabIndex = 0;
            // 
            // gameover
            // 
            this.gameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameover.Location = new System.Drawing.Point(364, 143);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(377, 298);
            this.gameover.TabIndex = 4;
            this.gameover.Text = "GAME OVER\r\n\r\nF1 -TRY AGAIN\r\n\r\nESC-EXIT\r\n\r\n";
            // 
            // points_lbl
            // 
            this.points_lbl.AutoSize = true;
            this.points_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.points_lbl.Location = new System.Drawing.Point(274, 9);
            this.points_lbl.Name = "points_lbl";
            this.points_lbl.Size = new System.Drawing.Size(63, 69);
            this.points_lbl.TabIndex = 3;
            this.points_lbl.Text = "0";
            this.points_lbl.Click += new System.EventHandler(this.Label2_Click);
            // 
            // score__lbl
            // 
            this.score__lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score__lbl.Location = new System.Drawing.Point(3, 9);
            this.score__lbl.Name = "score__lbl";
            this.score__lbl.Size = new System.Drawing.Size(265, 80);
            this.score__lbl.TabIndex = 2;
            this.score__lbl.Text = "SCORE:";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Yellow;
            this.ball.Location = new System.Drawing.Point(248, 215);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // raket
            // 
            this.raket.BackColor = System.Drawing.Color.LightSeaGreen;
            this.raket.Location = new System.Drawing.Point(113, 403);
            this.raket.Name = "raket";
            this.raket.Size = new System.Drawing.Size(200, 20);
            this.raket.TabIndex = 0;
            this.raket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.oyunekranı);
            this.Name = "form1";
            this.Text = "pin pon oyunu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form1_KeyDown);
            this.oyunekranı.ResumeLayout(false);
            this.oyunekranı.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel oyunekranı;
        private System.Windows.Forms.Label points_lbl;
        private System.Windows.Forms.Label score__lbl;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox raket;
        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.Timer timer1;
    }
}

