
namespace App_ARG
{
    partial class DatosEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosEmpleado));
            this.txtNombre = new ControlesWinform.TextBoxHint();
            this.txtApellidos = new ControlesWinform.TextBoxHint();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDNI = new ControlesWinform.TextBoxHint();
            this.buttonOk = new System.Windows.Forms.Button();
            this.btnDesbl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new ControlesWinform.TextBoxHint();
            this.txtError = new ControlesWinform.TextBoxHint();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecNa = new ControlesWinform.TextBoxHint();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFecCo = new ControlesWinform.TextBoxHint();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEquipo = new ControlesWinform.TextBoxHint();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.Hint = "";
            this.txtNombre.Location = new System.Drawing.Point(240, 63);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(240, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.ForeColor = System.Drawing.Color.Gray;
            this.txtApellidos.Hint = "";
            this.txtApellidos.Location = new System.Drawing.Point(486, 63);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(479, 26);
            this.txtApellidos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(123)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(123)))), ((int)(((byte)(110)))));
            this.label2.Location = new System.Drawing.Point(544, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDNI.ForeColor = System.Drawing.Color.Gray;
            this.txtDNI.Hint = "DNI";
            this.txtDNI.Location = new System.Drawing.Point(617, 20);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.ReadOnly = true;
            this.txtDNI.Size = new System.Drawing.Size(240, 26);
            this.txtDNI.TabIndex = 3;
            this.txtDNI.Text = "DNI";
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(123)))), ((int)(((byte)(110)))));
            this.buttonOk.Location = new System.Drawing.Point(879, 214);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(108, 38);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Aceptar";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // btnDesbl
            // 
            this.btnDesbl.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDesbl.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnDesbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(123)))), ((int)(((byte)(110)))));
            this.btnDesbl.Location = new System.Drawing.Point(558, 214);
            this.btnDesbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesbl.Name = "btnDesbl";
            this.btnDesbl.Size = new System.Drawing.Size(283, 38);
            this.btnDesbl.TabIndex = 6;
            this.btnDesbl.Text = "Desbloquear Cmd";
            this.btnDesbl.UseVisualStyleBackColor = true;
            this.btnDesbl.Visible = false;
            this.btnDesbl.Click += new System.EventHandler(this.btnDesbl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(123)))), ((int)(((byte)(110)))));
            this.label3.Location = new System.Drawing.Point(138, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCodigo.ForeColor = System.Drawing.Color.Gray;
            this.txtCodigo.Hint = "";
            this.txtCodigo.Location = new System.Drawing.Point(240, 20);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(240, 26);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.SystemColors.Control;
            this.txtError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtError.ForeColor = System.Drawing.Color.Gray;
            this.txtError.Hint = "";
            this.txtError.Location = new System.Drawing.Point(16, 207);
            this.txtError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(825, 45);
            this.txtError.TabIndex = 9;
            this.txtError.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(123)))), ((int)(((byte)(110)))));
            this.label4.Location = new System.Drawing.Point(8, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // txtFecNa
            // 
            this.txtFecNa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFecNa.ForeColor = System.Drawing.Color.Gray;
            this.txtFecNa.Hint = "";
            this.txtFecNa.Location = new System.Drawing.Point(240, 110);
            this.txtFecNa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFecNa.Name = "txtFecNa";
            this.txtFecNa.ReadOnly = true;
            this.txtFecNa.Size = new System.Drawing.Size(240, 26);
            this.txtFecNa.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(123)))), ((int)(((byte)(110)))));
            this.label5.Location = new System.Drawing.Point(498, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha contratación:";
            // 
            // txtFecCo
            // 
            this.txtFecCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFecCo.ForeColor = System.Drawing.Color.Gray;
            this.txtFecCo.Hint = "";
            this.txtFecCo.Location = new System.Drawing.Point(725, 110);
            this.txtFecCo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFecCo.Name = "txtFecCo";
            this.txtFecCo.ReadOnly = true;
            this.txtFecCo.Size = new System.Drawing.Size(240, 26);
            this.txtFecCo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(123)))), ((int)(((byte)(110)))));
            this.label6.Location = new System.Drawing.Point(58, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Departamento:";
            // 
            // txtEquipo
            // 
            this.txtEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEquipo.ForeColor = System.Drawing.Color.Gray;
            this.txtEquipo.Hint = "";
            this.txtEquipo.Location = new System.Drawing.Point(240, 156);
            this.txtEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.ReadOnly = true;
            this.txtEquipo.Size = new System.Drawing.Size(240, 26);
            this.txtEquipo.TabIndex = 14;
            // 
            // DatosEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(999, 267);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEquipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFecCo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFecNa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnDesbl);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "DatosEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del empleado";
            this.Click += new System.EventHandler(this.Ventana_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ControlesWinform.TextBoxHint txtNombre;
        public ControlesWinform.TextBoxHint txtApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public ControlesWinform.TextBoxHint txtDNI;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button btnDesbl;
        private System.Windows.Forms.Label label3;
        public ControlesWinform.TextBoxHint txtCodigo;
        public ControlesWinform.TextBoxHint txtError;
        private System.Windows.Forms.Label label4;
        public ControlesWinform.TextBoxHint txtFecNa;
        private System.Windows.Forms.Label label5;
        public ControlesWinform.TextBoxHint txtFecCo;
        private System.Windows.Forms.Label label6;
        public ControlesWinform.TextBoxHint txtEquipo;
    }
}