
namespace AbstractClass
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
            this.btn_Gitar = new System.Windows.Forms.Button();
            this.btnBateri = new System.Windows.Forms.Button();
            this.btnYanFulut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Gitar
            // 
            this.btn_Gitar.Location = new System.Drawing.Point(12, 12);
            this.btn_Gitar.Name = "btn_Gitar";
            this.btn_Gitar.Size = new System.Drawing.Size(512, 56);
            this.btn_Gitar.TabIndex = 0;
            this.btn_Gitar.Text = "Gitar";
            this.btn_Gitar.UseVisualStyleBackColor = true;
            this.btn_Gitar.Click += new System.EventHandler(this.btn_Gitar_Click);
            // 
            // btnBateri
            // 
            this.btnBateri.Location = new System.Drawing.Point(12, 74);
            this.btnBateri.Name = "btnBateri";
            this.btnBateri.Size = new System.Drawing.Size(512, 56);
            this.btnBateri.TabIndex = 0;
            this.btnBateri.Text = "Bateri";
            this.btnBateri.UseVisualStyleBackColor = true;
            this.btnBateri.Click += new System.EventHandler(this.btnBateri_Click);
            // 
            // btnYanFulut
            // 
            this.btnYanFulut.Location = new System.Drawing.Point(12, 136);
            this.btnYanFulut.Name = "btnYanFulut";
            this.btnYanFulut.Size = new System.Drawing.Size(512, 56);
            this.btnYanFulut.TabIndex = 0;
            this.btnYanFulut.Text = "YanFulut";
            this.btnYanFulut.UseVisualStyleBackColor = true;
            this.btnYanFulut.Click += new System.EventHandler(this.btnYanFulut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYanFulut);
            this.Controls.Add(this.btnBateri);
            this.Controls.Add(this.btn_Gitar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Gitar;
        private System.Windows.Forms.Button btnBateri;
        private System.Windows.Forms.Button btnYanFulut;
    }
}

