using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParqueoLorena 
{
    class Conexion
    {
        //declaracion de la variable conectar en el sql
        SqlConnection conn;
        
         
        // metodo para conectar a la base de datos
        public void Conectar()
        {
            conn = new SqlConnection("Data Source=DESKTOP-IO7SKIU\\SQLEXPRESS;Initial Catalog=ParqueoDB;Integrated Security=True");
            conn.Open();
        }

        //metodo para desconectar la base de datos
        public void Desconectar()
        {
            conn.Close();
        }

        // metodo para realizar la consulta si el dato fue agregado a la base de datos
        public void EjecutarSql(String consulta)
        {
     
     
             
            // se declara una variable llama con que ejecutara las lineas de comando de sql

            SqlCommand con = new SqlCommand(consulta, conn);


            //funcion para saber si el dato fue agregado correctamente
            int filasAfectadas = con.ExecuteNonQuery();
            //string a = "select *  from agendaTBL where nombre like '" + d.usuario + "%'; ";
            //if (true)
            //{

            //}

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Dato agregado correcto", "La Base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Dato no fue agregado", "La Base de Datos no ha sido Modificada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //se crea el metodo para actulizar el datagridview
        public void ActualizarGrid(DataGridView dg, string consulta)
        {
            //llamo al metodo conectar que me da la conexion con la base de datos
            this.Conectar();

            //se Crea una referencia para los datos 
            //Para que se tome los datos de la base de datos y los jale en datagridview
            System.Data.DataSet ds = new System.Data.DataSet();
                        
            //se crea un adaptador para los datos de la base de datos
            SqlDataAdapter da = new SqlDataAdapter(consulta, conn);
                       
            //Se realiza una funcion de llenado para la tabla del datagridview
            da.Fill(ds, "ParqueoTBL");

            //se agregan las propiedades al datagridview
            dg.DataSource = ds;

            //esta fucnion va a traer todo el contenido de la tabla que mecionamos arriba
            dg.DataMember = "ParqueoTBL";

            this.Desconectar();
        }

    }
}
