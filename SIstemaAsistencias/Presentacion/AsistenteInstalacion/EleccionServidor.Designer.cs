namespace SIstemaAsistencias.Presentacion.AsistenteInstalacion
{
    partial class EleccionServidor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_principal = new System.Windows.Forms.Button();
            this.btn_puntoC = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 71);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Consolas", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Asistencias";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_puntoC);
            this.panel2.Controls.Add(this.btn_principal);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(71, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1275, 505);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1275, 71);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(359, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(566, 71);
            this.label2.TabIndex = 0;
            this.label2.Text = "¿Esta computadora es ?";
            // 
            // btn_principal
            // 
            this.btn_principal.FlatAppearance.BorderSize = 0;
            this.btn_principal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_principal.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_principal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_principal.Location = new System.Drawing.Point(413, 118);
            this.btn_principal.Name = "btn_principal";
            this.btn_principal.Size = new System.Drawing.Size(468, 120);
            this.btn_principal.TabIndex = 19;
            this.btn_principal.Text = "Principal";
            this.btn_principal.UseVisualStyleBackColor = true;
            this.btn_principal.Click += new System.EventHandler(this.btn_principal_Click);
            // 
            // btn_puntoC
            // 
            this.btn_puntoC.FlatAppearance.BorderSize = 0;
            this.btn_puntoC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_puntoC.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_puntoC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_puntoC.Location = new System.Drawing.Point(413, 322);
            this.btn_puntoC.Name = "btn_puntoC";
            this.btn_puntoC.Size = new System.Drawing.Size(468, 120);
            this.btn_puntoC.TabIndex = 20;
            this.btn_puntoC.Text = "Punto de Control";
            this.btn_puntoC.UseVisualStyleBackColor = true;
            this.btn_puntoC.Click += new System.EventHandler(this.btn_puntoC_Click);
            // 
            // EleccionServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1405, 637);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EleccionServidor";
            this.Text = "EleccionServidor";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_puntoC;
        private System.Windows.Forms.Button btn_principal;
    }
}