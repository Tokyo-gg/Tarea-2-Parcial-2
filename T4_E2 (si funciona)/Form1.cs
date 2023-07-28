using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace T4_E2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPrecio.Text = "";
            pbxFoto.Hide();
            string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" +
            Application.StartupPath + "\\AutoLote.accdb'";
            OleDbConnection con = new OleDbConnection(strCon);

            string consultaMarca = "select * from Marcas";

            OleDbCommand comandoMarca = new OleDbCommand(consultaMarca, con);

            con.Open();
            comandoMarca.CommandType = CommandType.Text;

            OleDbDataReader drMarca = comandoMarca.ExecuteReader();


            while (drMarca.Read())
            {
                listBoxMarcas.Items.Add(drMarca["Marca"].ToString());
            }
            con.Close();
            

        }

        private void listBoxMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxModelos.Items.Clear();
            listBoxModelos.ResetText();
            listBoxAños.Items.Clear();
            listBoxAños.ResetText();
            lblPrecio.Text = "";
            pbxFoto.Hide();

            string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" +
            Application.StartupPath + "\\AutoLote.accdb'";
            OleDbConnection con = new OleDbConnection(strCon);

            string consultaModelo = "select * from Modelos";
            string consultaMarca = "select * from Marcas";

            OleDbCommand comandoModelo = new OleDbCommand(consultaModelo, con);
            OleDbCommand comandoMarca = new OleDbCommand(consultaMarca, con);


            con.Open();
            comandoModelo.CommandType = CommandType.Text;
            comandoMarca.CommandType = CommandType.Text;

            OleDbDataReader drModelo = comandoModelo.ExecuteReader();
            OleDbDataReader drMarca = comandoMarca.ExecuteReader();



            string MarcaActual = listBoxMarcas.Text;
            int IdMarcaActual = -1;

            while (drMarca.Read())
            {
                if (MarcaActual == drMarca["Marca"].ToString())
                {
                    IdMarcaActual = int.Parse(drMarca["IdMarca"].ToString());
                }

            }

            while (drModelo.Read())
            {
                int idTemp = int.Parse(drModelo["IdMarca"].ToString());
                if (IdMarcaActual == idTemp)
                {
                    listBoxModelos.Items.Add(drModelo["Modelo"].ToString());
                }
            }


            con.Close();
        }

        private void listBoxModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxAños.Items.Clear();
            listBoxAños.ResetText();
            lblPrecio.Text = "";
            pbxFoto.Hide();

            string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" +
            Application.StartupPath + "\\AutoLote.accdb'";
            OleDbConnection con = new OleDbConnection(strCon);

            string consultaModelo = "select * from Modelos";
            string consultaAno = "select * from Vehiculos";

            OleDbCommand comandoModelo = new OleDbCommand(consultaModelo, con);
            OleDbCommand comandoAno = new OleDbCommand(consultaAno, con);


            con.Open();
            comandoModelo.CommandType = CommandType.Text;
            comandoAno.CommandType = CommandType.Text;

            OleDbDataReader drModelo = comandoModelo.ExecuteReader();
            OleDbDataReader drAno = comandoAno.ExecuteReader();



            string ModeloActual = listBoxModelos.Text;
            int IdModeloActual = -1;

            while (drModelo.Read())
            {
                if (ModeloActual == drModelo["Modelo"].ToString())
                {
                    IdModeloActual = int.Parse(drModelo["IdModelo"].ToString());
                }

            }

            while (drAno.Read())
            {
                int idTemp = int.Parse(drAno["IdModelo"].ToString());
                if (IdModeloActual == idTemp)
                {
                    listBoxAños.Items.Add(drAno["Año"].ToString());
                }
            }


            con.Close();
        }

        private void listBoxAños_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPrecio.Text = "";
            pbxFoto.Hide();

            string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" +
            Application.StartupPath + "\\AutoLote.accdb'";
            OleDbConnection con = new OleDbConnection(strCon);

            string consultaModelo = "select * from Modelos";
            string consultaAno = "select * from Vehiculos";

            OleDbCommand comandoModelo = new OleDbCommand(consultaModelo, con);
            OleDbCommand comandoAno = new OleDbCommand(consultaAno, con);


            con.Open();
            comandoModelo.CommandType = CommandType.Text;
            comandoAno.CommandType = CommandType.Text;

            OleDbDataReader drModelo = comandoModelo.ExecuteReader();
            OleDbDataReader drAno = comandoAno.ExecuteReader();



            string ModeloActual = listBoxModelos.Text;
            int IdModeloActual = -1;

            while (drModelo.Read())
            {
                if (ModeloActual == drModelo["Modelo"].ToString())
                {
                    IdModeloActual = int.Parse(drModelo["IdModelo"].ToString());
                }

            }

            while (drAno.Read())
            {
                int idTemp = int.Parse(drAno["IdModelo"].ToString());
                if (IdModeloActual == idTemp)
                {
                    string AnoActual = listBoxAños.Text;
                    int IdAnoActual = -1;
                    if (AnoActual == drAno["Año"].ToString())
                    {
                        IdAnoActual = int.Parse(drAno["IdAño"].ToString());
                    }

                    int idTemp1 = int.Parse(drAno["IdAño"].ToString());
                    if (IdAnoActual == idTemp1)
                    {
                        lblPrecio.Text = "$" + drAno["Precio"].ToString();
                        pbxFoto.Visible = true;
                        pbxFoto.Image = new Bitmap(drAno["Imagen"].ToString());
                    }
                }
            }


            con.Close();
        }

    
    }
    
}
