using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexC_SHARP_2._0
{
    public partial class VentanaPrincipal : Form
    {

        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        int idActual = 1; //El pokemon que estamos viendo.


        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        public Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void izq_Click(object sender, EventArgs e)
        {
            idActual--;
            if (idActual <= 0) { idActual = 1; }

            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            altura.Text = misPokemons.Rows[0]["altura"].ToString();
            peso.Text = misPokemons.Rows[0]["peso"].ToString();
            especie.Text = misPokemons.Rows[0]["especie"].ToString();
            habitat.Text = misPokemons.Rows[0]["habitat"].ToString();
            tipo1.Text = misPokemons.Rows[0]["tipo1"].ToString();
            tipo2.Text = misPokemons.Rows[0]["tipo2"].ToString();
            habilidad.Text = misPokemons.Rows[0]["habilidad"].ToString();
            movimiento1.Text = misPokemons.Rows[0]["movimiento1"].ToString();
            movimiento2.Text = misPokemons.Rows[0]["movimiento2"].ToString();
            movimiento3.Text = misPokemons.Rows[0]["movimiento3"].ToString();
            movimiento4.Text = misPokemons.Rows[0]["movimiento4"].ToString();
            descripcion.Text = misPokemons.Rows[0]["descripcion"].ToString();

            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private void der_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual >= 151) { idActual = 151; }

            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            altura.Text = misPokemons.Rows[0]["altura"].ToString();
            peso.Text = misPokemons.Rows[0]["peso"].ToString();
            especie.Text = misPokemons.Rows[0]["especie"].ToString();
            habitat.Text = misPokemons.Rows[0]["habitat"].ToString();
            tipo1.Text = misPokemons.Rows[0]["tipo1"].ToString();
            tipo2.Text = misPokemons.Rows[0]["tipo2"].ToString();
            habilidad.Text = misPokemons.Rows[0]["habilidad"].ToString();
            movimiento1.Text = misPokemons.Rows[0]["movimiento1"].ToString();
            movimiento2.Text = misPokemons.Rows[0]["movimiento2"].ToString();
            movimiento3.Text = misPokemons.Rows[0]["movimiento3"].ToString();
            movimiento4.Text = misPokemons.Rows[0]["movimiento4"].ToString();
            descripcion.Text = misPokemons.Rows[0]["descripcion"].ToString();

            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventana2 v = new Ventana2();
            v.Show();
        }
    }
}
