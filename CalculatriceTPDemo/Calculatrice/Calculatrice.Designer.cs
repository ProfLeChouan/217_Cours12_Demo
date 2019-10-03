namespace Calculatrice
{
    partial class Calculatrice
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
            this.checkedListOperation = new System.Windows.Forms.CheckedListBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListOperation
            // 
            this.checkedListOperation.FormattingEnabled = true;
            this.checkedListOperation.Location = new System.Drawing.Point(13, 13);
            this.checkedListOperation.Name = "checkedListOperation";
            this.checkedListOperation.Size = new System.Drawing.Size(120, 94);
            this.checkedListOperation.TabIndex = 0;
            this.checkedListOperation.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListOperation_ItemCheck);
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(12, 110);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(0, 13);
            this.lblResultat.TabIndex = 1;
            // 
            // Calculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.checkedListOperation);
            this.Name = "Calculatrice";
            this.Text = "Calculatrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListOperation;
        private System.Windows.Forms.Label lblResultat;
    }
}

