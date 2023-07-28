using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T4_E2
{
    public partial class Form1 : Form
    {
        public const string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\AutoLote.accdb";
        public OleDbConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new OleDbConnection(connectionString);

        }


        public void Form1_Load(object sender, EventArgs e)
        {
            LoadMarcas();

        }

        public void LoadMarcas()
        {
            
            try
            {
                connection.Open();
                string query = "SELECT Id, Marca FROM Marcas";
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["Id"]);
                    string marca = reader["Marca"].ToString();
                    listBoxMarcas.Items.Add(new ListaMarcas(id, marca));
                }                

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        public void listBoxMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpia los datos anteriores en la segunda ListBox
            listBoxModelos.Items.Clear();

            if (listBoxMarcas.SelectedItem != null)
            {
                ListaMarcas selectedItem = (ListaMarcas)listBoxMarcas.SelectedItem;

                try
                {
                    connection.Open();
                    string query = "SELECT Id, Modelo FROM Modelos WHERE IDRelacion = @IdMarca";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@IdMarca", selectedItem.Id);
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["Id"]);
                        string modelo = reader["Modelo"].ToString();
                        listBoxModelos.Items.Add(new ListaModelos(id, modelo));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //this.marcaTableAdapter.Fill(this.autoLoteDataSet.Marca);

        }
    }
}
