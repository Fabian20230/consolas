using consolas.Data.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consolas.Data
{
    internal class CONSOLAS
    {
        internal class ConexionMYSQL
        {

            string connectionString = "server=localhost;database=catalogo_consultas;user=root;password=Fabian178_";
            private MySqlConnection connection;

            //constructor
            public ConexionMYSQL()
            {
                connection = new MySqlConnection(connectionString);
            }
            public void Insertar(string consola, string compañia, DateTime fechalanzamiento, string generacion)
            {
                try
                {
                    string query = "INSERT INTO catalogo_consolas (nombre_consola, compania, anio_lanzamiento, generacion) VALUES (@nombre_consola, @compania, @anio_lanzamiento, @generacion)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nombre_consola", consola);
                    cmd.Parameters.AddWithValue("@compania", compañia);
                    cmd.Parameters.AddWithValue("@anio_lanzamiento", fechalanzamiento);
                    cmd.Parameters.AddWithValue("@generacion", generacion);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el registro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                public void Insertar(consolasdd clsd)
                {
                    try
                    {
                        string query = "INSERT INTO catalogo_consolas (nombre_consola, compania, anio_lanzamiento, generacion) VALUES (@nombre_consola, @compania, @anio_lanzamiento, @generacion)";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@nombre_consola",clsd.nombre_consola);
                        cmd.Parameters.AddWithValue("@compania", clsd.compania);
                        cmd.Parameters.AddWithValue("@anio_lanzamiento", clsd.anio_lanzamiento);
                        cmd.Parameters.AddWithValue("@generacion", clsd.generacion);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar el registro: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }



















            }

            internal void Insertar(consolasdd clsd)
            {
                throw new NotImplementedException();
            }
        }
    }
}
