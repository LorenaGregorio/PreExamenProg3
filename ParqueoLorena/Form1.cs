using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParqueoLorena
{
    public partial class Form1 : Form
    {
        // Se crea el objeto conexion para que se obtegan los datos
        Conexion con = new Conexion();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //llamo al metodo actualizargrid
            this.ActualizarGrid();
        }


        // Metodo para actualizar datagridview
        public void ActualizarGrid()
        {
            // Aca se hace una funcion (select) para mostrar los datos
            con.ActualizarGrid(this.dataGridView1, "Select * from ParqueoTBL");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //se crea el objeto dato


            Datos d = new Datos
           (
                textBox1.Text,
                // string '" + d.usuario + "',
                comboBox1.Text,
                textBox2.Text,
                comboBox2.Text,
                comboBox3.Text,
                Convert.ToInt32(textBox3.Text),
                //int  '" + d.usuario + "',
                Convert.ToInt32(textBox4.Text)
           );

               

          
                con.Conectar();

                //Se crea una consulta para insertar los datos (Guardar)
                string consulta = "insert into ParqueoTBL (Usuario,TipoVehiculo,Placa,TipoPago,TipoParqueo,TiempoParqueo,TotalPago) " +
                    "values ('" + d.usuario + "', '" + d.tipovehiculo + "','" + d.placa + "','" + d.tipopago + "','" + d.tipoparqueo + "'," + d.tiempoarqueo + "," + d.totalpago + " );";

                //con esta funcion ejecuto la consulta de arriba en codigo sql
                con.EjecutarSql(consulta);
                this.ActualizarGrid();
                con.Desconectar();

           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {


           

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem.Equals("Hora  Q 20"))
            {
                int tem = (20 * Convert.ToInt32(textBox3.Text));
                textBox4.Text = tem.ToString();
            }

            if (comboBox3.SelectedItem.Equals("Dia     Q 50"))
            {
                int tem = (50 * Convert.ToInt32(textBox3.Text));
                textBox4.Text = tem.ToString();
            }
            if (comboBox3.SelectedItem.Equals("Mes    Q 100"))
            {
                int tem = (100 * Convert.ToInt32(textBox3.Text));
                textBox4.Text = tem.ToString();
            }
            if (comboBox3.SelectedItem.Equals("Trimestre Q 200"))
            {
                int tem = (200 * Convert.ToInt32(textBox3.Text));
                textBox4.Text = tem.ToString();
            }
            if (comboBox3.SelectedItem.Equals("Año    Q 500"))
            {
                int tem = (500 * Convert.ToInt32(textBox3.Text));
                textBox4.Text = tem.ToString();
            }



        }
    }
}
