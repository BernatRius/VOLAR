namespace Pruebas_GUI_Volar
{
    partial class _03_Espacio_Aereo
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
            this.EspAereo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CicloBut = new System.Windows.Forms.Button();
            this.LoadBut = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.simulacionTimer = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.IniciarAutoSim = new System.Windows.Forms.Button();
            this.DetenerAutoSim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EspAereo
            // 
            this.EspAereo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EspAereo.Location = new System.Drawing.Point(444, 62);
            this.EspAereo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EspAereo.Name = "EspAereo";
            this.EspAereo.Size = new System.Drawing.Size(844, 938);
            this.EspAereo.TabIndex = 0;
            this.EspAereo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EspAereo_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 955);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "599";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1239, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(446, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1223, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "599";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Chartreuse;
            this.label7.Location = new System.Drawing.Point(726, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(282, 46);
            this.label7.TabIndex = 8;
            this.label7.Text = "Espacio Aereo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Chartreuse;
            this.label8.Location = new System.Drawing.Point(118, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 46);
            this.label8.TabIndex = 9;
            this.label8.Text = "Acciones";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Un ciclo de accion";
            // 
            // CicloBut
            // 
            this.CicloBut.Location = new System.Drawing.Point(215, 208);
            this.CicloBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CicloBut.Name = "CicloBut";
            this.CicloBut.Size = new System.Drawing.Size(84, 29);
            this.CicloBut.TabIndex = 11;
            this.CicloBut.Text = "Accion!";
            this.CicloBut.UseVisualStyleBackColor = true;
            this.CicloBut.Click += new System.EventHandler(this.CicloBut_Click);
            // 
            // LoadBut
            // 
            this.LoadBut.Location = new System.Drawing.Point(215, 142);
            this.LoadBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoadBut.Name = "LoadBut";
            this.LoadBut.Size = new System.Drawing.Size(84, 29);
            this.LoadBut.TabIndex = 13;
            this.LoadBut.Text = "Accion!";
            this.LoadBut.UseVisualStyleBackColor = true;
            this.LoadBut.Click += new System.EventHandler(this.LoadBut_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Cargar datos de vuelo";
            // 
            // simulacionTimer
            // 
            this.simulacionTimer.Tick += new System.EventHandler(this.SimulacionTimer_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Simulación Automática";
            // 
            // IniciarAutoSim
            // 
            this.IniciarAutoSim.Location = new System.Drawing.Point(215, 268);
            this.IniciarAutoSim.Name = "IniciarAutoSim";
            this.IniciarAutoSim.Size = new System.Drawing.Size(162, 34);
            this.IniciarAutoSim.TabIndex = 15;
            this.IniciarAutoSim.Text = "Iniciar Simulación";
            this.IniciarAutoSim.UseVisualStyleBackColor = true;
            this.IniciarAutoSim.Click += new System.EventHandler(this.IniciarAutoSim_Click);
            // 
            // DetenerAutoSim
            // 
            this.DetenerAutoSim.Location = new System.Drawing.Point(215, 328);
            this.DetenerAutoSim.Name = "DetenerAutoSim";
            this.DetenerAutoSim.Size = new System.Drawing.Size(162, 34);
            this.DetenerAutoSim.TabIndex = 16;
            this.DetenerAutoSim.Text = "Detener Simulación";
            this.DetenerAutoSim.UseVisualStyleBackColor = true;
            // 
            // _03_Espacio_Aereo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1299, 1021);
            this.Controls.Add(this.IniciarAutoSim);
            this.Controls.Add(this.DetenerAutoSim);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LoadBut);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CicloBut);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EspAereo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "_03_Espacio_Aereo";
            this.Text = "_03_Espacio_Aereo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel EspAereo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button CicloBut;
        private System.Windows.Forms.Button LoadBut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer simulacionTimer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button IniciarAutoSim;
        private System.Windows.Forms.Button DetenerAutoSim;
    }
}