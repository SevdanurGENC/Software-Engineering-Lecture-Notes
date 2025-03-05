
namespace OOP_Class
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnisimGetir = new System.Windows.Forms.Button();
            this.btnPersonelBilgileri = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Age = new System.Windows.Forms.TextBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPersonelBilgileri);
            this.groupBox1.Controls.Add(this.btnisimGetir);
            this.groupBox1.Location = new System.Drawing.Point(35, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye";
            // 
            // btnisimGetir
            // 
            this.btnisimGetir.Location = new System.Drawing.Point(35, 22);
            this.btnisimGetir.Name = "btnisimGetir";
            this.btnisimGetir.Size = new System.Drawing.Size(402, 32);
            this.btnisimGetir.TabIndex = 0;
            this.btnisimGetir.Text = "İsim Getir";
            this.btnisimGetir.UseVisualStyleBackColor = true;
            this.btnisimGetir.Click += new System.EventHandler(this.btnisimGetir_Click);
            // 
            // btnPersonelBilgileri
            // 
            this.btnPersonelBilgileri.Location = new System.Drawing.Point(35, 74);
            this.btnPersonelBilgileri.Name = "btnPersonelBilgileri";
            this.btnPersonelBilgileri.Size = new System.Drawing.Size(402, 32);
            this.btnPersonelBilgileri.TabIndex = 0;
            this.btnPersonelBilgileri.Text = "Kişisel Bilgileri Getir";
            this.btnPersonelBilgileri.UseVisualStyleBackColor = true;
            this.btnPersonelBilgileri.Click += new System.EventHandler(this.btnPersonelBilgileri_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnGetir);
            this.groupBox2.Controls.Add(this.txt_Age);
            this.groupBox2.Location = new System.Drawing.Point(35, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Üye  Sorgula";
            // 
            // txt_Age
            // 
            this.txt_Age.Location = new System.Drawing.Point(35, 55);
            this.txt_Age.Name = "txt_Age";
            this.txt_Age.Size = new System.Drawing.Size(142, 22);
            this.txt_Age.TabIndex = 0;
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(35, 109);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(402, 35);
            this.btnGetir.TabIndex = 1;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yaşa gore";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 619);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "+";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPersonelBilgileri;
        private System.Windows.Forms.Button btnisimGetir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.TextBox txt_Age;
        private System.Windows.Forms.Label label1;
    }
}

