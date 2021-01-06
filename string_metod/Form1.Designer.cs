namespace string_metod
{
    partial class Form1
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
            this.textBox_metin = new System.Windows.Forms.TextBox();
            this.checkBox_kelime_ayır = new System.Windows.Forms.CheckBox();
            this.checkBox_cümleleri_ayır = new System.Windows.Forms.CheckBox();
            this.checkBox_kelime_toplam_sayı = new System.Windows.Forms.CheckBox();
            this.checkBox_cümlelerin_toplam_sayısı = new System.Windows.Forms.CheckBox();
            this.checkBox_kücük_yazdır = new System.Windows.Forms.CheckBox();
            this.checkBox_büyük_yazdır = new System.Windows.Forms.CheckBox();
            this.checkBox_toplam_harf_sayısı = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_ayrı_kelimeler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_ayrı_cümleler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox_metin
            // 
            this.textBox_metin.Location = new System.Drawing.Point(28, 51);
            this.textBox_metin.Multiline = true;
            this.textBox_metin.Name = "textBox_metin";
            this.textBox_metin.Size = new System.Drawing.Size(905, 178);
            this.textBox_metin.TabIndex = 0;
            // 
            // checkBox_kelime_ayır
            // 
            this.checkBox_kelime_ayır.AutoSize = true;
            this.checkBox_kelime_ayır.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_kelime_ayır.Location = new System.Drawing.Point(58, 252);
            this.checkBox_kelime_ayır.Name = "checkBox_kelime_ayır";
            this.checkBox_kelime_ayır.Size = new System.Drawing.Size(133, 21);
            this.checkBox_kelime_ayır.TabIndex = 1;
            this.checkBox_kelime_ayır.Text = "Kelimeleri ayır";
            this.checkBox_kelime_ayır.UseVisualStyleBackColor = true;
            this.checkBox_kelime_ayır.CheckedChanged += new System.EventHandler(this.checkBox_kelime_ayır_CheckedChanged);
            // 
            // checkBox_cümleleri_ayır
            // 
            this.checkBox_cümleleri_ayır.AutoSize = true;
            this.checkBox_cümleleri_ayır.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_cümleleri_ayır.Location = new System.Drawing.Point(360, 252);
            this.checkBox_cümleleri_ayır.Name = "checkBox_cümleleri_ayır";
            this.checkBox_cümleleri_ayır.Size = new System.Drawing.Size(129, 21);
            this.checkBox_cümleleri_ayır.TabIndex = 2;
            this.checkBox_cümleleri_ayır.Text = "Cümleleri ayır";
            this.checkBox_cümleleri_ayır.UseVisualStyleBackColor = true;
            this.checkBox_cümleleri_ayır.CheckedChanged += new System.EventHandler(this.checkBox_cümleleri_ayır_CheckedChanged);
            // 
            // checkBox_kelime_toplam_sayı
            // 
            this.checkBox_kelime_toplam_sayı.AutoSize = true;
            this.checkBox_kelime_toplam_sayı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_kelime_toplam_sayı.Location = new System.Drawing.Point(958, 25);
            this.checkBox_kelime_toplam_sayı.Name = "checkBox_kelime_toplam_sayı";
            this.checkBox_kelime_toplam_sayı.Size = new System.Drawing.Size(207, 24);
            this.checkBox_kelime_toplam_sayı.TabIndex = 3;
            this.checkBox_kelime_toplam_sayı.Text = "Toplam kelime sayısı";
            this.checkBox_kelime_toplam_sayı.UseVisualStyleBackColor = true;
            this.checkBox_kelime_toplam_sayı.CheckedChanged += new System.EventHandler(this.checkBox_kelime_toplam_sayı_CheckedChanged);
            // 
            // checkBox_cümlelerin_toplam_sayısı
            // 
            this.checkBox_cümlelerin_toplam_sayısı.AutoSize = true;
            this.checkBox_cümlelerin_toplam_sayısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_cümlelerin_toplam_sayısı.Location = new System.Drawing.Point(958, 74);
            this.checkBox_cümlelerin_toplam_sayısı.Name = "checkBox_cümlelerin_toplam_sayısı";
            this.checkBox_cümlelerin_toplam_sayısı.Size = new System.Drawing.Size(203, 24);
            this.checkBox_cümlelerin_toplam_sayısı.TabIndex = 4;
            this.checkBox_cümlelerin_toplam_sayısı.Text = "Toplam cümle sayısı";
            this.checkBox_cümlelerin_toplam_sayısı.UseVisualStyleBackColor = true;
            this.checkBox_cümlelerin_toplam_sayısı.CheckedChanged += new System.EventHandler(this.checkBox_cümlelerin_toplam_sayısı_CheckedChanged);
            // 
            // checkBox_kücük_yazdır
            // 
            this.checkBox_kücük_yazdır.AutoSize = true;
            this.checkBox_kücük_yazdır.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_kücük_yazdır.Location = new System.Drawing.Point(958, 136);
            this.checkBox_kücük_yazdır.Name = "checkBox_kücük_yazdır";
            this.checkBox_kücük_yazdır.Size = new System.Drawing.Size(368, 22);
            this.checkBox_kücük_yazdır.TabIndex = 5;
            this.checkBox_kücük_yazdır.Text = "Girilen metni tamamen KÜÇÜK harf ile yazdır";
            this.checkBox_kücük_yazdır.UseVisualStyleBackColor = true;
            this.checkBox_kücük_yazdır.CheckedChanged += new System.EventHandler(this.checkBox_kücük_yazdır_CheckedChanged);
            // 
            // checkBox_büyük_yazdır
            // 
            this.checkBox_büyük_yazdır.AutoSize = true;
            this.checkBox_büyük_yazdır.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_büyük_yazdır.Location = new System.Drawing.Point(958, 203);
            this.checkBox_büyük_yazdır.Name = "checkBox_büyük_yazdır";
            this.checkBox_büyük_yazdır.Size = new System.Drawing.Size(366, 22);
            this.checkBox_büyük_yazdır.TabIndex = 6;
            this.checkBox_büyük_yazdır.Text = "Girilen metni tamamen BÜYÜK harf ile yazdır";
            this.checkBox_büyük_yazdır.UseVisualStyleBackColor = true;
            this.checkBox_büyük_yazdır.CheckedChanged += new System.EventHandler(this.checkBox_büyük_yazdır_CheckedChanged);
            // 
            // checkBox_toplam_harf_sayısı
            // 
            this.checkBox_toplam_harf_sayısı.AutoSize = true;
            this.checkBox_toplam_harf_sayısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_toplam_harf_sayısı.Location = new System.Drawing.Point(958, 264);
            this.checkBox_toplam_harf_sayısı.Name = "checkBox_toplam_harf_sayısı";
            this.checkBox_toplam_harf_sayısı.Size = new System.Drawing.Size(309, 21);
            this.checkBox_toplam_harf_sayısı.TabIndex = 7;
            this.checkBox_toplam_harf_sayısı.Text = "Girilen metinde ki harf saysı kaç tane?";
            this.checkBox_toplam_harf_sayısı.UseVisualStyleBackColor = true;
            this.checkBox_toplam_harf_sayısı.CheckedChanged += new System.EventHandler(this.checkBox_toplam_harf_sayısı_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Metin Girişi :";
            // 
            // lst_ayrı_kelimeler
            // 
            this.lst_ayrı_kelimeler.FormattingEnabled = true;
            this.lst_ayrı_kelimeler.ItemHeight = 16;
            this.lst_ayrı_kelimeler.Location = new System.Drawing.Point(41, 339);
            this.lst_ayrı_kelimeler.Name = "lst_ayrı_kelimeler";
            this.lst_ayrı_kelimeler.Size = new System.Drawing.Size(228, 260);
            this.lst_ayrı_kelimeler.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(38, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "Girilen tüm kelimeleri \r\nayrı ayrı yazdır\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(306, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 51);
            this.label3.TabIndex = 11;
            this.label3.Text = "Girilen tüm cümleleri\r\n ayrı ayrı yazdır\r\n\r\n";
            // 
            // lst_ayrı_cümleler
            // 
            this.lst_ayrı_cümleler.FormattingEnabled = true;
            this.lst_ayrı_cümleler.ItemHeight = 16;
            this.lst_ayrı_cümleler.Location = new System.Drawing.Point(309, 339);
            this.lst_ayrı_cümleler.Name = "lst_ayrı_cümleler";
            this.lst_ayrı_cümleler.Size = new System.Drawing.Size(624, 260);
            this.lst_ayrı_cümleler.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 632);
            this.Controls.Add(this.lst_ayrı_cümleler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_ayrı_kelimeler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_toplam_harf_sayısı);
            this.Controls.Add(this.checkBox_büyük_yazdır);
            this.Controls.Add(this.checkBox_kücük_yazdır);
            this.Controls.Add(this.checkBox_cümlelerin_toplam_sayısı);
            this.Controls.Add(this.checkBox_kelime_toplam_sayı);
            this.Controls.Add(this.checkBox_cümleleri_ayır);
            this.Controls.Add(this.checkBox_kelime_ayır);
            this.Controls.Add(this.textBox_metin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_metin;
        private System.Windows.Forms.CheckBox checkBox_kelime_ayır;
        private System.Windows.Forms.CheckBox checkBox_cümleleri_ayır;
        private System.Windows.Forms.CheckBox checkBox_kelime_toplam_sayı;
        private System.Windows.Forms.CheckBox checkBox_cümlelerin_toplam_sayısı;
        private System.Windows.Forms.CheckBox checkBox_kücük_yazdır;
        private System.Windows.Forms.CheckBox checkBox_büyük_yazdır;
        private System.Windows.Forms.CheckBox checkBox_toplam_harf_sayısı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_ayrı_kelimeler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_ayrı_cümleler;
    }
}

