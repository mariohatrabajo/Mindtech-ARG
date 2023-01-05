
namespace App_ARG
{
    partial class LoreTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoreTexto));
            this.tbLore = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbLore
            // 
            this.tbLore.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbLore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLore.Font = new System.Drawing.Font("Rockwell", 19.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLore.ForeColor = System.Drawing.Color.Firebrick;
            this.tbLore.Location = new System.Drawing.Point(0, 0);
            this.tbLore.Name = "tbLore";
            this.tbLore.Size = new System.Drawing.Size(800, 464);
            this.tbLore.TabIndex = 1;
            this.tbLore.Text = resources.GetString("tbLore.Text");
            // 
            // LoreTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.tbLore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoreTexto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbLore;
    }
}