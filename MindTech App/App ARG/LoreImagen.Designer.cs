
namespace App_ARG
{
    partial class LoreImagen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoreImagen));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imagenLore = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenLore)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folleto1.png");
            this.imageList1.Images.SetKeyName(1, "GM.png");
            // 
            // imagenLore
            // 
            this.imagenLore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagenLore.Image = global::App_ARG.Properties.Resources.Folleto1;
            this.imagenLore.Location = new System.Drawing.Point(0, 0);
            this.imagenLore.Name = "imagenLore";
            this.imagenLore.Size = new System.Drawing.Size(977, 647);
            this.imagenLore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenLore.TabIndex = 0;
            this.imagenLore.TabStop = false;
            this.imagenLore.Click += new System.EventHandler(this.imagenLore_Click);
            // 
            // LoreImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(977, 647);
            this.Controls.Add(this.imagenLore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoreImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.imagenLore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagenLore;
        private System.Windows.Forms.ImageList imageList1;
    }
}