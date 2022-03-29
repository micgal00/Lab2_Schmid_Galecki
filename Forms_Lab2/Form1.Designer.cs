namespace Forms_Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.AktualnaPogoda = new System.Windows.Forms.ListBox();
            this.getData = new System.Windows.Forms.Button();
            this.getCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AktualnaPogoda
            // 
            this.AktualnaPogoda.FormattingEnabled = true;
            this.AktualnaPogoda.Location = new System.Drawing.Point(11, 36);
            this.AktualnaPogoda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AktualnaPogoda.Name = "AktualnaPogoda";
            this.AktualnaPogoda.Size = new System.Drawing.Size(663, 290);
            this.AktualnaPogoda.TabIndex = 0;
            // 
            // getData
            // 
            this.getData.Location = new System.Drawing.Point(726, 273);
            this.getData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(82, 53);
            this.getData.TabIndex = 2;
            this.getData.Text = "Pobierz dane";
            this.getData.UseVisualStyleBackColor = true;
            this.getData.Click += new System.EventHandler(this.button2_Click);
            // 
            // getCity
            // 
            this.getCity.Location = new System.Drawing.Point(708, 225);
            this.getCity.Name = "getCity";
            this.getCity.Size = new System.Drawing.Size(100, 20);
            this.getCity.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(770, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Miasto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getCity);
            this.Controls.Add(this.getData);
            this.Controls.Add(this.AktualnaPogoda);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AktualnaPogoda;
        private System.Windows.Forms.Button getData;
        private System.Windows.Forms.TextBox getCity;
        private System.Windows.Forms.Label label1;
    }
}

