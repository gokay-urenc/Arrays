namespace Array_Diziler
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
            this.btnSonEleman = new System.Windows.Forms.Button();
            this.btnRastgeleEleman = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSonEleman
            // 
            this.btnSonEleman.Location = new System.Drawing.Point(8, 12);
            this.btnSonEleman.Name = "btnSonEleman";
            this.btnSonEleman.Size = new System.Drawing.Size(334, 39);
            this.btnSonEleman.TabIndex = 0;
            this.btnSonEleman.Text = "Son Elemanı Göster";
            this.btnSonEleman.UseVisualStyleBackColor = true;
            this.btnSonEleman.Click += new System.EventHandler(this.btnSonEleman_Click);
            // 
            // btnRastgeleEleman
            // 
            this.btnRastgeleEleman.Location = new System.Drawing.Point(8, 57);
            this.btnRastgeleEleman.Name = "btnRastgeleEleman";
            this.btnRastgeleEleman.Size = new System.Drawing.Size(334, 39);
            this.btnRastgeleEleman.TabIndex = 1;
            this.btnRastgeleEleman.Text = "Rastgele Eleman Göster";
            this.btnRastgeleEleman.UseVisualStyleBackColor = true;
            this.btnRastgeleEleman.Click += new System.EventHandler(this.btnRastgeleEleman_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(8, 102);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(334, 39);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Elemanları Listeye Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 147);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(334, 290);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(366, 57);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(334, 39);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dizide aramak istediğiniz değeri giriniz";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(367, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(367, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(333, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seçilen değeri değiştir";
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(366, 193);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(334, 39);
            this.btnDegistir.TabIndex = 7;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 449);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnRastgeleEleman);
            this.Controls.Add(this.btnSonEleman);
            this.Name = "Form2";
            this.Text = "Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSonEleman;
        private System.Windows.Forms.Button btnRastgeleEleman;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDegistir;
    }
}