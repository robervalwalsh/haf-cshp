﻿namespace TaschenRechnerAufgabe3v1
{
    partial class Taschenrechner
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
            this.buttonBerechen = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.labelBeschreibung = new System.Windows.Forms.Label();
            this.labelAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBerechen
            // 
            this.buttonBerechen.Location = new System.Drawing.Point(13, 125);
            this.buttonBerechen.Name = "buttonBerechen";
            this.buttonBerechen.Size = new System.Drawing.Size(75, 23);
            this.buttonBerechen.TabIndex = 0;
            this.buttonBerechen.Text = "Berechen";
            this.buttonBerechen.UseVisualStyleBackColor = true;
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(297, 125);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(75, 23);
            this.buttonBeenden.TabIndex = 1;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            // 
            // labelBeschreibung
            // 
            this.labelBeschreibung.AutoSize = true;
            this.labelBeschreibung.Location = new System.Drawing.Point(13, 106);
            this.labelBeschreibung.Name = "labelBeschreibung";
            this.labelBeschreibung.Size = new System.Drawing.Size(51, 13);
            this.labelBeschreibung.TabIndex = 2;
            this.labelBeschreibung.Text = "Ergebnis:";
            // 
            // labelAnzeige
            // 
            this.labelAnzeige.AutoSize = true;
            this.labelAnzeige.Location = new System.Drawing.Point(70, 106);
            this.labelAnzeige.Name = "labelAnzeige";
            this.labelAnzeige.Size = new System.Drawing.Size(13, 13);
            this.labelAnzeige.TabIndex = 3;
            this.labelAnzeige.Text = "0";
            // 
            // Taschenrechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 160);
            this.Controls.Add(this.labelAnzeige);
            this.Controls.Add(this.labelBeschreibung);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonBerechen);
            this.Name = "Taschenrechner";
            this.Text = "Ein einfacher Taschenrechner";
            this.Load += new System.EventHandler(this.Taschenrechner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBerechen;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Label labelBeschreibung;
        private System.Windows.Forms.Label labelAnzeige;
    }
}

