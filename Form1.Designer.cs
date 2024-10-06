namespace Toplantı_Planlama
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.logo = new System.Windows.Forms.PictureBox();
            this.toplantiplanlama = new System.Windows.Forms.Label();
            this.toplantiOlustur = new System.Windows.Forms.Button();
            this.Sonraki = new System.Windows.Forms.Button();
            this.onceki = new System.Windows.Forms.Button();
            this.Pazartesi = new System.Windows.Forms.Label();
            this.Salı = new System.Windows.Forms.Label();
            this.Çarşamba = new System.Windows.Forms.Label();
            this.Perşembe = new System.Windows.Forms.Label();
            this.Cuma = new System.Windows.Forms.Label();
            this.Cumartesi = new System.Windows.Forms.Label();
            this.Pazar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 8);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(108, 94);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // toplantiplanlama
            // 
            this.toplantiplanlama.AutoSize = true;
            this.toplantiplanlama.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toplantiplanlama.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplantiplanlama.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toplantiplanlama.Location = new System.Drawing.Point(117, 18);
            this.toplantiplanlama.Name = "toplantiplanlama";
            this.toplantiplanlama.Size = new System.Drawing.Size(146, 82);
            this.toplantiplanlama.TabIndex = 1;
            this.toplantiplanlama.Text = "Toplantı\r\nPlanlama\r\n";
            this.toplantiplanlama.Click += new System.EventHandler(this.toplantiplanlama_Click);
            // 
            // toplantiOlustur
            // 
            this.toplantiOlustur.BackColor = System.Drawing.Color.DodgerBlue;
            this.toplantiOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toplantiOlustur.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplantiOlustur.ForeColor = System.Drawing.Color.White;
            this.toplantiOlustur.Location = new System.Drawing.Point(12, 108);
            this.toplantiOlustur.Name = "toplantiOlustur";
            this.toplantiOlustur.Size = new System.Drawing.Size(262, 77);
            this.toplantiOlustur.TabIndex = 3;
            this.toplantiOlustur.Text = "Toplantı Oluştur";
            this.toplantiOlustur.UseVisualStyleBackColor = false;
            this.toplantiOlustur.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sonraki
            // 
            this.Sonraki.BackColor = System.Drawing.Color.Crimson;
            this.Sonraki.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sonraki.ForeColor = System.Drawing.Color.White;
            this.Sonraki.Location = new System.Drawing.Point(1288, 756);
            this.Sonraki.Name = "Sonraki";
            this.Sonraki.Size = new System.Drawing.Size(134, 42);
            this.Sonraki.TabIndex = 6;
            this.Sonraki.Text = "Sonraki";
            this.Sonraki.UseVisualStyleBackColor = false;
            this.Sonraki.Click += new System.EventHandler(this.Sonraki_Click);
            // 
            // onceki
            // 
            this.onceki.BackColor = System.Drawing.Color.Crimson;
            this.onceki.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onceki.ForeColor = System.Drawing.Color.White;
            this.onceki.Location = new System.Drawing.Point(280, 756);
            this.onceki.Name = "onceki";
            this.onceki.Size = new System.Drawing.Size(134, 42);
            this.onceki.TabIndex = 7;
            this.onceki.Text = "Önceki";
            this.onceki.UseVisualStyleBackColor = false;
            this.onceki.Click += new System.EventHandler(this.button4_Click);
            // 
            // Pazartesi
            // 
            this.Pazartesi.AutoSize = true;
            this.Pazartesi.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Pazartesi.ForeColor = System.Drawing.Color.White;
            this.Pazartesi.Location = new System.Drawing.Point(280, 64);
            this.Pazartesi.Name = "Pazartesi";
            this.Pazartesi.Size = new System.Drawing.Size(146, 41);
            this.Pazartesi.TabIndex = 8;
            this.Pazartesi.Text = "Pazartesi";
            this.Pazartesi.Click += new System.EventHandler(this.Pazartesi_Click);
            // 
            // Salı
            // 
            this.Salı.AutoSize = true;
            this.Salı.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Salı.ForeColor = System.Drawing.Color.White;
            this.Salı.Location = new System.Drawing.Point(479, 64);
            this.Salı.Name = "Salı";
            this.Salı.Size = new System.Drawing.Size(70, 41);
            this.Salı.TabIndex = 9;
            this.Salı.Text = "Salı";
            // 
            // Çarşamba
            // 
            this.Çarşamba.AutoSize = true;
            this.Çarşamba.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Çarşamba.ForeColor = System.Drawing.Color.White;
            this.Çarşamba.Location = new System.Drawing.Point(599, 64);
            this.Çarşamba.Name = "Çarşamba";
            this.Çarşamba.Size = new System.Drawing.Size(157, 41);
            this.Çarşamba.TabIndex = 10;
            this.Çarşamba.Text = "Çarşamba";
            // 
            // Perşembe
            // 
            this.Perşembe.AutoSize = true;
            this.Perşembe.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Perşembe.ForeColor = System.Drawing.Color.White;
            this.Perşembe.Location = new System.Drawing.Point(762, 64);
            this.Perşembe.Name = "Perşembe";
            this.Perşembe.Size = new System.Drawing.Size(156, 41);
            this.Perşembe.TabIndex = 11;
            this.Perşembe.Text = "Perşembe";
            // 
            // Cuma
            // 
            this.Cuma.AutoSize = true;
            this.Cuma.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cuma.ForeColor = System.Drawing.Color.White;
            this.Cuma.Location = new System.Drawing.Point(953, 64);
            this.Cuma.Name = "Cuma";
            this.Cuma.Size = new System.Drawing.Size(95, 41);
            this.Cuma.TabIndex = 12;
            this.Cuma.Text = "Cuma";
            // 
            // Cumartesi
            // 
            this.Cumartesi.AutoSize = true;
            this.Cumartesi.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cumartesi.ForeColor = System.Drawing.Color.White;
            this.Cumartesi.Location = new System.Drawing.Point(1087, 64);
            this.Cumartesi.Name = "Cumartesi";
            this.Cumartesi.Size = new System.Drawing.Size(160, 41);
            this.Cumartesi.TabIndex = 13;
            this.Cumartesi.Text = "Cumartesi";
            // 
            // Pazar
            // 
            this.Pazar.AutoSize = true;
            this.Pazar.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Pazar.ForeColor = System.Drawing.Color.White;
            this.Pazar.Location = new System.Drawing.Point(1281, 64);
            this.Pazar.Name = "Pazar";
            this.Pazar.Size = new System.Drawing.Size(93, 41);
            this.Pazar.TabIndex = 14;
            this.Pazar.Text = "Pazar";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(280, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 647);
            this.panel1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 77);
            this.button2.TabIndex = 5;
            this.button2.Text = "Toplantıya Katıl";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(727, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 41);
            this.label1.TabIndex = 17;
            this.label1.Text = "Month";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 737);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(190, 654);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.OrangeRed;
            this.label2.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 654);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 77);
            this.label2.TabIndex = 20;
            this.label2.Text = "Çıkış";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Impact", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(63, 737);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 61);
            this.label3.TabIndex = 21;
            this.label3.Text = "Geri <--";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1432, 805);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pazar);
            this.Controls.Add(this.Cumartesi);
            this.Controls.Add(this.Cuma);
            this.Controls.Add(this.Perşembe);
            this.Controls.Add(this.Çarşamba);
            this.Controls.Add(this.Salı);
            this.Controls.Add(this.Pazartesi);
            this.Controls.Add(this.onceki);
            this.Controls.Add(this.Sonraki);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.toplantiOlustur);
            this.Controls.Add(this.toplantiplanlama);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplantı Planlama";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label toplantiplanlama;
        private System.Windows.Forms.Button toplantiOlustur;
        private System.Windows.Forms.Button Sonraki;
        private System.Windows.Forms.Button onceki;
        private System.Windows.Forms.Label Pazartesi;
        private System.Windows.Forms.Label Salı;
        private System.Windows.Forms.Label Çarşamba;
        private System.Windows.Forms.Label Perşembe;
        private System.Windows.Forms.Label Cuma;
        private System.Windows.Forms.Label Cumartesi;
        private System.Windows.Forms.Label Pazar;
        private System.Windows.Forms.FlowLayoutPanel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

