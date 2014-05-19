﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronMan.Gestores;
using IronMan.DTO;

namespace IronManWF
{
    public partial class frmEventos : Form
    {

        private readonly EventoGestor _eGestor;

        public frmEventos()
        {
            this._eGestor = new EventoGestor();
            InitializeComponent();
            LigarComponentes();

        }

        private void LigarComponentes()
        {
            this.btnCerrar.Click += OnCloseButtonClick;
            this.listBoxEventos.SelectedIndexChanged += OnEventoListBoxSelectedIndexChanged;

            this.listBoxEventos.DisplayMember = "Nombre";
            this.listBoxEventos.ValueMember = "Id";
            this.listBoxEventos.DataSource = this._eGestor.Listar();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void OnEventoListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var _eventoIdSeleccionado = (int)this.listBoxEventos.SelectedValue;

                var _eventoSeleccionado = _eGestor.Obtener(_eventoIdSeleccionado);

                this.txtNombre.Text = _eventoSeleccionado.Nombre;
                this.txtLugar.Text = _eventoSeleccionado.Lugar;
                this.txtFecha.Text = _eventoSeleccionado.Fecha.ToString();
                this.txtComentario.Text = _eventoSeleccionado.Comentario;
        }

        private void OnCloseButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
