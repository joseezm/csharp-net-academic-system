﻿namespace Sistema_de_Gestión_de_Cursos_y_Exámenes
{
    partial class programarExamen
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
            this.titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SeleccionarTipo = new System.Windows.Forms.ComboBox();
            this.EtiquetaGrupo = new System.Windows.Forms.Label();
            this.SeleccionarCurso = new System.Windows.Forms.ComboBox();
            this.EtiquetaCurso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guardarConfExamen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.titulo.ForeColor = System.Drawing.Color.Black;
            this.titulo.Location = new System.Drawing.Point(12, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(366, 46);
            this.titulo.TabIndex = 2;
            this.titulo.Text = "Programar Examen";
            this.titulo.Click += new System.EventHandler(this.titulo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.SeleccionarTipo);
            this.panel1.Controls.Add(this.EtiquetaGrupo);
            this.panel1.Controls.Add(this.SeleccionarCurso);
            this.panel1.Controls.Add(this.EtiquetaCurso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guardarConfExamen);
            this.panel1.Location = new System.Drawing.Point(20, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 584);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SeleccionarTipo
            // 
            this.SeleccionarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SeleccionarTipo.FormattingEnabled = true;
            this.SeleccionarTipo.Location = new System.Drawing.Point(19, 145);
            this.SeleccionarTipo.Name = "SeleccionarTipo";
            this.SeleccionarTipo.Size = new System.Drawing.Size(329, 33);
            this.SeleccionarTipo.TabIndex = 16;
            this.SeleccionarTipo.SelectedIndexChanged += new System.EventHandler(this.SeleccionarTipo_SelectedIndexChanged);
            // 
            // EtiquetaGrupo
            // 
            this.EtiquetaGrupo.AutoSize = true;
            this.EtiquetaGrupo.BackColor = System.Drawing.Color.Transparent;
            this.EtiquetaGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EtiquetaGrupo.ForeColor = System.Drawing.Color.Black;
            this.EtiquetaGrupo.Location = new System.Drawing.Point(14, 117);
            this.EtiquetaGrupo.Name = "EtiquetaGrupo";
            this.EtiquetaGrupo.Size = new System.Drawing.Size(66, 25);
            this.EtiquetaGrupo.TabIndex = 15;
            this.EtiquetaGrupo.Text = "Grupo";
            // 
            // SeleccionarCurso
            // 
            this.SeleccionarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SeleccionarCurso.FormattingEnabled = true;
            this.SeleccionarCurso.Location = new System.Drawing.Point(19, 81);
            this.SeleccionarCurso.Name = "SeleccionarCurso";
            this.SeleccionarCurso.Size = new System.Drawing.Size(329, 33);
            this.SeleccionarCurso.TabIndex = 14;
            this.SeleccionarCurso.SelectedIndexChanged += new System.EventHandler(this.SeleccionarCurso_SelectedIndexChanged);
            // 
            // EtiquetaCurso
            // 
            this.EtiquetaCurso.AutoSize = true;
            this.EtiquetaCurso.BackColor = System.Drawing.Color.Transparent;
            this.EtiquetaCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EtiquetaCurso.ForeColor = System.Drawing.Color.Black;
            this.EtiquetaCurso.Location = new System.Drawing.Point(14, 53);
            this.EtiquetaCurso.Name = "EtiquetaCurso";
            this.EtiquetaCurso.Size = new System.Drawing.Size(213, 25);
            this.EtiquetaCurso.TabIndex = 5;
            this.EtiquetaCurso.Text = "Seleccione un Examen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Programa un Examen";
            // 
            // guardarConfExamen
            // 
            this.guardarConfExamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.guardarConfExamen.Location = new System.Drawing.Point(58, 227);
            this.guardarConfExamen.Name = "guardarConfExamen";
            this.guardarConfExamen.Size = new System.Drawing.Size(265, 47);
            this.guardarConfExamen.TabIndex = 11;
            this.guardarConfExamen.Text = "Programa Examen";
            this.guardarConfExamen.UseVisualStyleBackColor = true;
            this.guardarConfExamen.Click += new System.EventHandler(this.guardarConfExamen_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(466, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Retroceder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // programarExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titulo);
            this.Name = "programarExamen";
            this.Text = "programarExamen";
            this.Load += new System.EventHandler(this.programarExamen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox SeleccionarTipo;
        private System.Windows.Forms.Label EtiquetaGrupo;
        private System.Windows.Forms.ComboBox SeleccionarCurso;
        private System.Windows.Forms.Label EtiquetaCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guardarConfExamen;
        private System.Windows.Forms.Button button1;
    }
}