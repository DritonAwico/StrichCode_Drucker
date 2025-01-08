namespace StrichCode_Drucker
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCodeGenerate = new System.Windows.Forms.Button();
            this.tBoxEbNummer = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCodeGenerate
            // 
            this.btnCodeGenerate.Location = new System.Drawing.Point(357, 172);
            this.btnCodeGenerate.Name = "btnCodeGenerate";
            this.btnCodeGenerate.Size = new System.Drawing.Size(112, 52);
            this.btnCodeGenerate.TabIndex = 0;
            this.btnCodeGenerate.Text = "Barcode Generieren";
            this.btnCodeGenerate.UseVisualStyleBackColor = true;
            this.btnCodeGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBoxEbNummer
            // 
            this.tBoxEbNummer.Location = new System.Drawing.Point(219, 91);
            this.tBoxEbNummer.Name = "tBoxEbNummer";
            this.tBoxEbNummer.Size = new System.Drawing.Size(250, 22);
            this.tBoxEbNummer.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(357, 283);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(112, 52);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Barcode Drucken";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Barcode",
            "Barcode mit EB-Nummer",
            "Barcode mit Logo und EB-Nummer"});
            this.comboBox1.Location = new System.Drawing.Point(65, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "PDF erstellen",
            "Technik Büro Drucker",
            "Etiketten Drucker"});
            this.comboBox2.Location = new System.Drawing.Point(65, 298);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(265, 24);
            this.comboBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "EB-Nummer:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 687);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.tBoxEbNummer);
            this.Controls.Add(this.btnCodeGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCodeGenerate;
        private System.Windows.Forms.TextBox tBoxEbNummer;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
    }
}

