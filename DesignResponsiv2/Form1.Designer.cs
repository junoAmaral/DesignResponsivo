namespace DesignResponsiv2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.menuEsquerdo = new System.Windows.Forms.Panel();
            this.menuEmCima = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(457, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(200, 100);
            this.panel.TabIndex = 0;
            // 
            // menuEsquerdo
            // 
            this.menuEsquerdo.BackColor = System.Drawing.Color.IndianRed;
            this.menuEsquerdo.Location = new System.Drawing.Point(663, 0);
            this.menuEsquerdo.Name = "menuEsquerdo";
            this.menuEsquerdo.Size = new System.Drawing.Size(144, 457);
            this.menuEsquerdo.TabIndex = 1;
            // 
            // menuEmCima
            // 
            this.menuEmCima.BackColor = System.Drawing.Color.Maroon;
            this.menuEmCima.Location = new System.Drawing.Point(14, 40);
            this.menuEmCima.Name = "menuEmCima";
            this.menuEmCima.Size = new System.Drawing.Size(523, 107);
            this.menuEmCima.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuEmCima);
            this.Controls.Add(this.menuEsquerdo);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel;
        private Panel menuEsquerdo;
        private Panel menuEmCima;
    }
}