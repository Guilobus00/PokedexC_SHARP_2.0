﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexC_SHARP_2._0
{
    public partial class VentanaSeleccionPokemon : Form
    {
        public int idSeleccionado;
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();

        public VentanaSeleccionPokemon()
        {
            InitializeComponent();

            dataGridView1.DataSource = miConexion.getTodosPokemons();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idSeleccionado = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            this.Close();
        }
    }
}
