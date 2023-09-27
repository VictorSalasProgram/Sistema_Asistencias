namespace SIstemaAsistencias.Presentacion
{
    partial class TomarAsistencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TomarAsistencias));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_iniciar_sesion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_identificacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_aviso = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.Label();
            this.pnl_observaciones = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_observacion = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.timer_hora = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_observaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_iniciar_sesion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1328, 67);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(-6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema Asistencias";
            // 
            // btn_iniciar_sesion
            // 
            this.btn_iniciar_sesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btn_iniciar_sesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_iniciar_sesion.BackgroundImage")));
            this.btn_iniciar_sesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_iniciar_sesion.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_iniciar_sesion.FlatAppearance.BorderSize = 0;
            this.btn_iniciar_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciar_sesion.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar_sesion.ForeColor = System.Drawing.Color.Black;
            this.btn_iniciar_sesion.Location = new System.Drawing.Point(1171, 0);
            this.btn_iniciar_sesion.Name = "btn_iniciar_sesion";
            this.btn_iniciar_sesion.Size = new System.Drawing.Size(157, 67);
            this.btn_iniciar_sesion.TabIndex = 1;
            this.btn_iniciar_sesion.Text = "Iniciar Sesion";
            this.btn_iniciar_sesion.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_hora);
            this.panel2.Controls.Add(this.lbl_fecha);
            this.panel2.Controls.Add(this.txt_nombre);
            this.panel2.Controls.Add(this.txt_aviso);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.txt_identificacion);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(410, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 501);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(4, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(537, 43);
            this.label2.TabIndex = 0;
            this.label2.Text = "Registro de Asistencias";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(24, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 34);
            this.label3.TabIndex = 1;
            this.label3.Text = "Identificacion:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Aquamarine;
            this.panel5.Location = new System.Drawing.Point(196, 287);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(264, 1);
            this.panel5.TabIndex = 8;
            // 
            // txt_identificacion
            // 
            this.txt_identificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txt_identificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_identificacion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_identificacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_identificacion.Location = new System.Drawing.Point(197, 257);
            this.txt_identificacion.Name = "txt_identificacion";
            this.txt_identificacion.Size = new System.Drawing.Size(264, 24);
            this.txt_identificacion.TabIndex = 7;
            this.txt_identificacion.TextChanged += new System.EventHandler(this.txt_identificacion_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(24, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(24, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 34);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hora:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_aviso
            // 
            this.txt_aviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txt_aviso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_aviso.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_aviso.ForeColor = System.Drawing.Color.SandyBrown;
            this.txt_aviso.Location = new System.Drawing.Point(146, 413);
            this.txt_aviso.Name = "txt_aviso";
            this.txt_aviso.Size = new System.Drawing.Size(264, 24);
            this.txt_aviso.TabIndex = 11;
            this.txt_aviso.Text = "**************";
            this.txt_aviso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nombre.Location = new System.Drawing.Point(191, 440);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(180, 34);
            this.txt_nombre.TabIndex = 12;
            this.txt_nombre.Text = "*****";
            this.txt_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_observaciones
            // 
            this.pnl_observaciones.Controls.Add(this.button1);
            this.pnl_observaciones.Controls.Add(this.txt_observacion);
            this.pnl_observaciones.Controls.Add(this.label6);
            this.pnl_observaciones.Location = new System.Drawing.Point(43, 162);
            this.pnl_observaciones.Name = "pnl_observaciones";
            this.pnl_observaciones.Size = new System.Drawing.Size(341, 399);
            this.pnl_observaciones.TabIndex = 2;
            this.pnl_observaciones.Visible = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(338, 64);
            this.label6.TabIndex = 1;
            this.label6.Text = "Observacion:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_observacion
            // 
            this.txt_observacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txt_observacion.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_observacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_observacion.Location = new System.Drawing.Point(18, 77);
            this.txt_observacion.Name = "txt_observacion";
            this.txt_observacion.Size = new System.Drawing.Size(310, 224);
            this.txt_observacion.TabIndex = 2;
            this.txt_observacion.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(92, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_fecha.Location = new System.Drawing.Point(193, 305);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(180, 34);
            this.lbl_fecha.TabIndex = 13;
            this.lbl_fecha.Text = "Fecha";
            this.lbl_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_hora
            // 
            this.lbl_hora.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_hora.Location = new System.Drawing.Point(193, 350);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(180, 34);
            this.lbl_hora.TabIndex = 14;
            this.lbl_hora.Text = "Hora";
            this.lbl_hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_hora
            // 
            this.timer_hora.Enabled = true;
            this.timer_hora.Tick += new System.EventHandler(this.timer_hora_Tick);
            // 
            // TomarAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1328, 610);
            this.Controls.Add(this.pnl_observaciones);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TomarAsistencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TomarAsistencias";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_observaciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_iniciar_sesion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_nombre;
        private System.Windows.Forms.TextBox txt_aviso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_identificacion;
        private System.Windows.Forms.Panel pnl_observaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txt_observacion;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Timer timer_hora;
    }
}