namespace _2___itext7
{
    partial class itext7
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTxtBox = new System.Windows.Forms.RichTextBox();
            this.btnGeneratePDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTxtBox
            // 
            this.richTxtBox.Location = new System.Drawing.Point(12, 12);
            this.richTxtBox.Name = "richTxtBox";
            this.richTxtBox.Size = new System.Drawing.Size(366, 172);
            this.richTxtBox.TabIndex = 0;
            this.richTxtBox.Text = "";
            // 
            // btnGeneratePDF
            // 
            this.btnGeneratePDF.Location = new System.Drawing.Point(251, 209);
            this.btnGeneratePDF.Name = "btnGeneratePDF";
            this.btnGeneratePDF.Size = new System.Drawing.Size(127, 34);
            this.btnGeneratePDF.TabIndex = 1;
            this.btnGeneratePDF.Text = "Generate PDF";
            this.btnGeneratePDF.UseVisualStyleBackColor = true;
            this.btnGeneratePDF.Click += new System.EventHandler(this.btnGeneratePDF_Click);
            // 
            // itext7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 269);
            this.Controls.Add(this.btnGeneratePDF);
            this.Controls.Add(this.richTxtBox);
            this.Name = "itext7";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtBox;
        private System.Windows.Forms.Button btnGeneratePDF;
    }
}

