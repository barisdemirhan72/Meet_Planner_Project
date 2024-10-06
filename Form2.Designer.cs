namespace Toplantı_Planlama
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.toplantibasligi = new System.Windows.Forms.TextBox();
            this.toplantikisi = new System.Windows.Forms.TextBox();
            this.toplantiaciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstTarihListesi = new System.Windows.Forms.ListBox();
            this.btnTarihEkle = new System.Windows.Forms.Button();
            this.btnTarihKaldir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 270);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(272, 30);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2023, 12, 3, 17, 16, 11, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(131, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "Toplantı Oluştur";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toplantibasligi
            // 
            this.toplantibasligi.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplantibasligi.Location = new System.Drawing.Point(273, 93);
            this.toplantibasligi.Name = "toplantibasligi";
            this.toplantibasligi.Size = new System.Drawing.Size(274, 45);
            this.toplantibasligi.TabIndex = 2;
            this.toplantibasligi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // toplantikisi
            // 
            this.toplantikisi.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplantikisi.Location = new System.Drawing.Point(273, 18);
            this.toplantikisi.Name = "toplantikisi";
            this.toplantikisi.Size = new System.Drawing.Size(274, 45);
            this.toplantikisi.TabIndex = 3;
            this.toplantikisi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // toplantiaciklama
            // 
            this.toplantiaciklama.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplantiaciklama.Location = new System.Drawing.Point(273, 165);
            this.toplantiaciklama.Name = "toplantiaciklama";
            this.toplantiaciklama.Size = new System.Drawing.Size(274, 45);
            this.toplantiaciklama.TabIndex = 4;
            this.toplantiaciklama.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(172, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kişi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(-5, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Toplantı Başlığı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(57, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "Açıklama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(172, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tarih ve Saat:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lstTarihListesi
            // 
            this.lstTarihListesi.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstTarihListesi.FormattingEnabled = true;
            this.lstTarihListesi.ItemHeight = 32;
            this.lstTarihListesi.Location = new System.Drawing.Point(297, 270);
            this.lstTarihListesi.Name = "lstTarihListesi";
            this.lstTarihListesi.Size = new System.Drawing.Size(250, 164);
            this.lstTarihListesi.TabIndex = 10;
            // 
            // btnTarihEkle
            // 
            this.btnTarihEkle.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTarihEkle.Location = new System.Drawing.Point(149, 306);
            this.btnTarihEkle.Name = "btnTarihEkle";
            this.btnTarihEkle.Size = new System.Drawing.Size(135, 57);
            this.btnTarihEkle.TabIndex = 11;
            this.btnTarihEkle.Text = "Ekle";
            this.btnTarihEkle.UseVisualStyleBackColor = true;
            this.btnTarihEkle.Click += new System.EventHandler(this.btnTarihEkle_Click);
            // 
            // btnTarihKaldir
            // 
            this.btnTarihKaldir.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTarihKaldir.Location = new System.Drawing.Point(149, 377);
            this.btnTarihKaldir.Name = "btnTarihKaldir";
            this.btnTarihKaldir.Size = new System.Drawing.Size(135, 57);
            this.btnTarihKaldir.TabIndex = 12;
            this.btnTarihKaldir.Text = "Kaldır";
            this.btnTarihKaldir.UseVisualStyleBackColor = true;
            this.btnTarihKaldir.Click += new System.EventHandler(this.btnTarihKaldir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 306);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(559, 553);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnTarihKaldir);
            this.Controls.Add(this.btnTarihEkle);
            this.Controls.Add(this.lstTarihListesi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toplantiaciklama);
            this.Controls.Add(this.toplantikisi);
            this.Controls.Add(this.toplantibasligi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Topantı Bilgileri";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox toplantibasligi;
        private System.Windows.Forms.TextBox toplantikisi;
        private System.Windows.Forms.TextBox toplantiaciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstTarihListesi;
        private System.Windows.Forms.Button btnTarihEkle;
        private System.Windows.Forms.Button btnTarihKaldir;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}