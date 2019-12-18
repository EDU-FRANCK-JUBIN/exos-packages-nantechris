namespace Packages
{
    partial class QRCoder
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
            this.picBoxQRCode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxQRCode
            // 
            this.picBoxQRCode.Location = new System.Drawing.Point(13, 13);
            this.picBoxQRCode.Name = "picBoxQRCode";
            this.picBoxQRCode.Size = new System.Drawing.Size(471, 375);
            this.picBoxQRCode.TabIndex = 0;
            this.picBoxQRCode.TabStop = false;
            // 
            // QRCoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 403);
            this.Controls.Add(this.picBoxQRCode);
            this.Name = "QRCoder";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.QRCoder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQRCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxQRCode;
    }
}

