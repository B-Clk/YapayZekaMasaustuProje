using System.Windows.Forms;

namespace YapayZeka
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblYas;
        private TextBox txtYas;
        private Label lblCinsiyet;
        private TextBox txtCinsiyet;
        private Label lblSevdikleri;
        private TextBox txtSevdikleri;
        private Label lblCocukSayisi;
        private TextBox txtCocukSayisi;
        private Label lblMekan;
        private TextBox txtMekan;
        private Button btnGonder;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblYas = new System.Windows.Forms.Label();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.txtCinsiyet = new System.Windows.Forms.TextBox();
            this.lblSevdikleri = new System.Windows.Forms.Label();
            this.txtSevdikleri = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.lblMekan = new System.Windows.Forms.Label();
            this.txtMekan = new System.Windows.Forms.TextBox();
            this.lblCocukSayisi = new System.Windows.Forms.Label();
            this.txtCocukSayisi = new System.Windows.Forms.TextBox();

            this.SuspendLayout();

          
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(27, 25);
            this.lblYas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(34, 16);
            this.lblYas.TabIndex = 0;
            this.lblYas.Text = "Yaş:";
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(133, 21);
            this.txtYas.Margin = new System.Windows.Forms.Padding(4);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(199, 22);
            this.txtYas.TabIndex = 1;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(27, 62);
            this.lblCinsiyet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(57, 16);
            this.lblCinsiyet.TabIndex = 2;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // txtCinsiyet
            // 
            this.txtCinsiyet.Location = new System.Drawing.Point(133, 58);
            this.txtCinsiyet.Margin = new System.Windows.Forms.Padding(4);
            this.txtCinsiyet.Name = "txtCinsiyet";
            this.txtCinsiyet.Size = new System.Drawing.Size(199, 22);
            this.txtCinsiyet.TabIndex = 3;
            // 
            // lblSevdikleri
            // 
            this.lblSevdikleri.AutoSize = true;
            this.lblSevdikleri.Location = new System.Drawing.Point(27, 98);
            this.lblSevdikleri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSevdikleri.Name = "lblSevdikleri";
            this.lblSevdikleri.Size = new System.Drawing.Size(97, 16);
            this.lblSevdikleri.TabIndex = 4;
            this.lblSevdikleri.Text = "Sevilen Şeyler:";
            // 
            // txtSevdikleri
            // 
            this.txtSevdikleri.Location = new System.Drawing.Point(133, 95);
            this.txtSevdikleri.Margin = new System.Windows.Forms.Padding(4);
            this.txtSevdikleri.Name = "txtSevdikleri";
            this.txtSevdikleri.Size = new System.Drawing.Size(199, 22);
            this.txtSevdikleri.TabIndex = 5;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(147, 285);
            this.btnGonder.Margin = new System.Windows.Forms.Padding(4);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(100, 28);
            this.btnGonder.TabIndex = 6;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sonuc:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(470, 62);
            this.txtSonuc.Multiline = true;
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(319, 324);
            this.txtSonuc.TabIndex = 8;
            // 
            // label2
            // 
            this.lblCocukSayisi.AutoSize = true;
            this.lblCocukSayisi.Location = new System.Drawing.Point(27, 135);
            this.lblCocukSayisi.Name = "lblCocukSayisi";
            this.lblCocukSayisi.Size = new System.Drawing.Size(88, 16);
            this.lblCocukSayisi.TabIndex = 9;
            this.lblCocukSayisi.Text = "Cocuk Sayisi:";
            this.lblCocukSayisi.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.lblMekan.AutoSize = true;
            this.lblMekan.Location = new System.Drawing.Point(29, 171);
            this.lblMekan.Name = "lblMekan";
            this.lblMekan.Size = new System.Drawing.Size(51, 16);
            this.lblMekan.TabIndex = 10;
            this.lblMekan.Text = "Mekan:";
            // 
            // textBox1
            // 
            this.txtCocukSayisi.Location = new System.Drawing.Point(133, 132);
            this.txtCocukSayisi.Name = "txtCocukSayisi";
            this.txtCocukSayisi.Size = new System.Drawing.Size(199, 22);
            this.txtCocukSayisi.TabIndex = 11;
            // 
            // textBox2
            // 
            this.txtMekan.Location = new System.Drawing.Point(133, 165);
            this.txtMekan.Name = "txtMekan";
            this.txtMekan.Size = new System.Drawing.Size(199, 22);
            this.txtMekan.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 478);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtSevdikleri);
            this.Controls.Add(this.lblSevdikleri);
            this.Controls.Add(this.txtCinsiyet);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.txtCocukSayisi);
            this.Controls.Add(this.lblCocukSayisi);
            this.Controls.Add(this.txtMekan);
            this.Controls.Add(this.lblMekan);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "YapayZeka - Etkinlik Önerisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private TextBox txtSonuc;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txtSayi;

    }
}