
namespace App_ARG
{
    partial class Informe
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
            this.txtLore = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLore
            // 
            this.txtLore.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtLore.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.txtLore.Location = new System.Drawing.Point(0, 0);
            this.txtLore.Multiline = true;
            this.txtLore.Name = "txtLore";
            this.txtLore.ReadOnly = true;
            this.txtLore.Size = new System.Drawing.Size(471, 758);
            this.txtLore.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_ARG.Properties.Resources.Artefacto;
            this.pictureBox1.Location = new System.Drawing.Point(473, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 465);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Informe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(994, 758);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLore);
            this.Name = "Informe";
            this.Text = "Informe";
            this.Load += new System.EventHandler(this.Informe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLore;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}