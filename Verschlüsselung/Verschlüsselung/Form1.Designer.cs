namespace WindowsFormsApplication1
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
            this.btn1Verschlüsseln = new System.Windows.Forms.Button();
            this.txtEinagbe = new System.Windows.Forms.RichTextBox();
            this.txtAusgabe = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1Verschlüsseln
            // 
            this.btn1Verschlüsseln.Location = new System.Drawing.Point(197, 177);
            this.btn1Verschlüsseln.Name = "btn1Verschlüsseln";
            this.btn1Verschlüsseln.Size = new System.Drawing.Size(75, 23);
            this.btn1Verschlüsseln.TabIndex = 0;
            this.btn1Verschlüsseln.Text = "Verschlüsseln";
            this.btn1Verschlüsseln.UseVisualStyleBackColor = true;
            this.btn1Verschlüsseln.Click += new System.EventHandler(this.btn1Verschlüsseln_Click);
            // 
            // txtEinagbe
            // 
            this.txtEinagbe.Location = new System.Drawing.Point(37, 64);
            this.txtEinagbe.Name = "txtEinagbe";
            this.txtEinagbe.Size = new System.Drawing.Size(154, 97);
            this.txtEinagbe.TabIndex = 1;
            this.txtEinagbe.Text = "";
            this.txtEinagbe.TextChanged += new System.EventHandler(this.txtEinagbe_TextChanged);
            // 
            // txtAusgabe
            // 
            this.txtAusgabe.Enabled = false;
            this.txtAusgabe.Location = new System.Drawing.Point(37, 217);
            this.txtAusgabe.Name = "txtAusgabe";
            this.txtAusgabe.Size = new System.Drawing.Size(154, 96);
            this.txtAusgabe.TabIndex = 2;
            this.txtAusgabe.Text = "";
            this.txtAusgabe.TextChanged += new System.EventHandler(this.txtAusgabe_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hier den Text eingeben";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hier der Verschlüsselte Text";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(296, 64);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 5;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Verschlüsselungskode eingaben";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAusgabe);
            this.Controls.Add(this.txtEinagbe);
            this.Controls.Add(this.btn1Verschlüsseln);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1Verschlüsseln;
        private System.Windows.Forms.RichTextBox txtEinagbe;
        private System.Windows.Forms.RichTextBox txtAusgabe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label3;
    }
}

