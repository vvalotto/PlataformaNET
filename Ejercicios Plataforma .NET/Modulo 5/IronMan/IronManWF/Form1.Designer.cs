﻿namespace IronManWF
{
    partial class frmEventos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxEventos = new System.Windows.Forms.ListBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlEvento = new System.Windows.Forms.Panel();
            this.lblComentario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.pnlEvento.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxEventos
            // 
            this.listBoxEventos.FormattingEnabled = true;
            this.listBoxEventos.Location = new System.Drawing.Point(29, 46);
            this.listBoxEventos.Name = "listBoxEventos";
            this.listBoxEventos.Size = new System.Drawing.Size(190, 186);
            this.listBoxEventos.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(323, 284);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // pnlEvento
            // 
            this.pnlEvento.Controls.Add(this.txtComentario);
            this.pnlEvento.Controls.Add(this.txtFecha);
            this.pnlEvento.Controls.Add(this.txtLugar);
            this.pnlEvento.Controls.Add(this.txtNombre);
            this.pnlEvento.Controls.Add(this.lblComentario);
            this.pnlEvento.Controls.Add(this.lblFecha);
            this.pnlEvento.Controls.Add(this.lblLugar);
            this.pnlEvento.Controls.Add(this.lblNombre);
            this.pnlEvento.Location = new System.Drawing.Point(323, 46);
            this.pnlEvento.Name = "pnlEvento";
            this.pnlEvento.Size = new System.Drawing.Size(427, 189);
            this.pnlEvento.TabIndex = 2;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(24, 134);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(60, 13);
            this.lblComentario.TabIndex = 3;
            this.lblComentario.Text = "Comentario";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(24, 97);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(24, 61);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(34, 13);
            this.lblLugar.TabIndex = 1;
            this.lblLugar.Text = "Lugar";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(98, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del Evento";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(158, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(227, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(158, 61);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(227, 20);
            this.txtLugar.TabIndex = 5;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(158, 97);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 6;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(158, 134);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(227, 20);
            this.txtComentario.TabIndex = 7;
            // 
            // frmEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 334);
            this.Controls.Add(this.pnlEvento);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.listBoxEventos);
            this.Name = "frmEventos";
            this.Text = "Eventos";
            this.pnlEvento.ResumeLayout(false);
            this.pnlEvento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEventos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel pnlEvento;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

