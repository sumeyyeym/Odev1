namespace degiskenler
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
            this.btnTamSayilar = new System.Windows.Forms.Button();
            this.btnOndalikliSayilar = new System.Windows.Forms.Button();
            this.btnMetinsel = new System.Windows.Forms.Button();
            this.btnMantiksal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTamSayilar
            // 
            this.btnTamSayilar.BackColor = System.Drawing.SystemColors.Info;
            this.btnTamSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamSayilar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTamSayilar.Location = new System.Drawing.Point(12, 12);
            this.btnTamSayilar.Name = "btnTamSayilar";
            this.btnTamSayilar.Size = new System.Drawing.Size(128, 41);
            this.btnTamSayilar.TabIndex = 0;
            this.btnTamSayilar.Text = "Tam Sayılar";
            this.btnTamSayilar.UseVisualStyleBackColor = false;
            this.btnTamSayilar.Click += new System.EventHandler(this.BtnTamSayilar_Click);
            // 
            // btnOndalikliSayilar
            // 
            this.btnOndalikliSayilar.BackColor = System.Drawing.SystemColors.Info;
            this.btnOndalikliSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOndalikliSayilar.Location = new System.Drawing.Point(12, 73);
            this.btnOndalikliSayilar.Name = "btnOndalikliSayilar";
            this.btnOndalikliSayilar.Size = new System.Drawing.Size(128, 42);
            this.btnOndalikliSayilar.TabIndex = 1;
            this.btnOndalikliSayilar.Text = "Ondalıklı Sayılar";
            this.btnOndalikliSayilar.UseVisualStyleBackColor = false;
            this.btnOndalikliSayilar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnMetinsel
            // 
            this.btnMetinsel.BackColor = System.Drawing.SystemColors.Info;
            this.btnMetinsel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetinsel.Location = new System.Drawing.Point(13, 133);
            this.btnMetinsel.Name = "btnMetinsel";
            this.btnMetinsel.Size = new System.Drawing.Size(127, 43);
            this.btnMetinsel.TabIndex = 2;
            this.btnMetinsel.Text = "Metinsel";
            this.btnMetinsel.UseVisualStyleBackColor = false;
            this.btnMetinsel.Click += new System.EventHandler(this.BtnMetinsel_Click);
            // 
            // btnMantiksal
            // 
            this.btnMantiksal.BackColor = System.Drawing.SystemColors.Info;
            this.btnMantiksal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantiksal.Location = new System.Drawing.Point(13, 196);
            this.btnMantiksal.Name = "btnMantiksal";
            this.btnMantiksal.Size = new System.Drawing.Size(127, 39);
            this.btnMantiksal.TabIndex = 3;
            this.btnMantiksal.Text = "Mantıksal";
            this.btnMantiksal.UseVisualStyleBackColor = false;
            this.btnMantiksal.Click += new System.EventHandler(this.BtnMantiksal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.btnMantiksal);
            this.Controls.Add(this.btnMetinsel);
            this.Controls.Add(this.btnOndalikliSayilar);
            this.Controls.Add(this.btnTamSayilar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTamSayilar;
        private System.Windows.Forms.Button btnOndalikliSayilar;
        private System.Windows.Forms.Button btnMetinsel;
        private System.Windows.Forms.Button btnMantiksal;
    }
}

