using System;
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
    public partial class Ventana2 : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        public Ventana2()
        {
            InitializeComponent();

            dataGridView1.DataSource = miConexion.getTodosPokemons();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        public void cambiaNombrePokemon(String nombrePok)
        {
            
        }

        private void Ventana2_Load(object sender, EventArgs e)
        {

        }
        public Image convierteBlobAImagen(byte[] img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nombrePokemon.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            fotoPokemon2.Image = convierteBlobAImagen((byte[])dataGridView1.Rows[e.RowIndex].Cells["imagen"].Value);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            String nombre = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            String id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();

            MessageBox.Show(miConexion.actualizaPokemon(id, nombre));
        }
    }
}
