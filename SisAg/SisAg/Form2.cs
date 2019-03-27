using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.IO;

namespace SisAg
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        MySqlConnection Conectar()
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=localhost; user id=daherzl; database=sisag";
            return conexion;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox_misCultivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(100);
            textBox1.Text = num.ToString() + " %";

            DateTime today = DateTime.Today;
            double diff = 0;
            double porcentaje = 0;
            String rec = "";

            MySqlConnection conexion = Conectar();
            String sentencia = "SELECT fecha_siembra FROM mis_cultivos WHERE nombre = '" + comboBox_misCultivos.Text + "'";
            MySqlCommand comando = new MySqlCommand(sentencia, conexion);      
            conexion.Open();
            comando.ExecuteNonQuery();
            
            MySqlDataReader MyReader;
            MyReader = comando.ExecuteReader();
            while (MyReader.Read())
            {
                var dateString = MyReader.GetDateTime(MyReader.GetOrdinal("fecha_siembra")).ToString("yyyy/MM/dd");
                DateTime myDate = DateTime.Parse(dateString);
                diff = (today - myDate).TotalDays;       
            }
            MyReader.Close();

            String sentencia2 = "UPDATE mis_cultivos SET dias_transcurridos = " + diff + " WHERE nombre = '" + comboBox_misCultivos.Text + "'";
            MySqlCommand comando2 = new MySqlCommand(sentencia2, conexion);
            comando2.ExecuteNonQuery();

            String sentencia3 = "SELECT dias_desarrollo FROM mis_cultivos WHERE nombre = '" + comboBox_misCultivos.Text + "'";
            MySqlCommand comando3 = new MySqlCommand(sentencia3, conexion);
            comando3.ExecuteNonQuery();
            
            MyReader = comando3.ExecuteReader();
            while (MyReader.Read())
            {
                double dias = MyReader.GetDouble("dias_desarrollo");
                porcentaje = (diff * 100) / dias;
            }
            porcentaje = Math.Round(porcentaje, 2);
            int porcentaje_round = ((int)Math.Round(porcentaje/10.0)) * 10;
   
            MyReader.Close();

            String sentencia4 = "SELECT recomendacion FROM " + comboBox_misCultivos.Text + " WHERE crecimiento = " + porcentaje_round + ""; 
            MySqlCommand comando4 = new MySqlCommand(sentencia4, conexion);
            comando4.ExecuteNonQuery();
            MyReader = comando4.ExecuteReader();
            while (MyReader.Read())
            {
                rec = MyReader.GetString(0);
            }
            
            MyReader.Close();

            String sentencia5 = "SELECT imagen FROM " + comboBox_misCultivos.Text + " WHERE crecimiento = " + porcentaje_round + "";
            MySqlCommand comando5 = new MySqlCommand(sentencia5, conexion);
            comando5.ExecuteNonQuery();
            
            MyReader = comando5.ExecuteReader();
            while (MyReader.Read())
            {
                var bytes = (byte[])MyReader[0];
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    pictureBox_imagenCrecimiento.Image = Image.FromStream(ms);
                }
            }

            MyReader.Close();

            conexion.Close();

            descripcion.Text = "Su cultivo tiene " + diff.ToString() + " días de haberse sembrado, lo que corresponde a " + porcentaje + "% de su estación de crecimiento. " + rec + " Su cultivo debería parecerse a la siguiente imagen: ";
           // pictureBox_imagenCrecimiento.Show();
        }

        private void cargar_cultivos()
        {
            comboBox_misCultivos.Items.Clear();

            MySqlConnection conexion = Conectar();

            String sentencia = "SELECT nombre FROM mis_cultivos";

            MySqlCommand comando = new MySqlCommand(sentencia, conexion);

            conexion.Open();

            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox_misCultivos.Items.Add(dr["nombre"].ToString());
            }
            conexion.Close();

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox_misCultivos.Items.Clear();

            MySqlConnection conexion = Conectar();

            String sentencia = "SELECT nombre FROM mis_cultivos";

            MySqlCommand comando = new MySqlCommand(sentencia, conexion);

            conexion.Open();

            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox_misCultivos.Items.Add(dr["nombre"].ToString());
            }
            conexion.Close();

        }

        private void cuanto_regar_Btn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(100);
            textBox_CuantoRegar.Text = num.ToString() + " ml";

            //Calculo con el metodo Hargreaves ETc = Eto x Kc
        }

        private void textBox_cuanto_abonar_TextChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(100);
            textBox_cuanto_abonar.Text = num.ToString() + " kg";
        }

        private void cuanto_abonar_Btn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(100);
            textBox_cuanto_abonar.Text = num.ToString() + " kg";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrar_btn_Click(object sender, EventArgs e)
        {
            int diasDesarrollo = 0;

            if (comboBox_cultivos.Text == "Jitomate")
            {
                diasDesarrollo = 120;
            }
            else if (comboBox_cultivos.Text == "Maíz")
            {
                diasDesarrollo = 160;
            }
            else if (comboBox_cultivos.Text == "Chile Serrano")
            {
                diasDesarrollo = 95;
            }

            MySqlConnection conexion = Conectar();

            String sentencia = "INSERT INTO mis_cultivos (nombre, fecha_siembra, terreno, dias_desarrollo )VALUES " + "('" + comboBox_cultivos.Text + "'," + "'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'," + textBox_terreno.Text + "," + diasDesarrollo.ToString() + ")";

            MySqlCommand comando = new MySqlCommand(sentencia, conexion);

            conexion.Open();

            comando.ExecuteNonQuery();

            conexion.Close();

            MessageBox.Show("Se ha registrado el cultivo");

            cargar_cultivos();
        }
    }
}
