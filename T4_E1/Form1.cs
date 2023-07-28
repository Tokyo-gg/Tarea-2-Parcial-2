using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace T4_E1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" +
            Application.StartupPath + "\\bdHabitantes.accdb'";
            OleDbConnection con = new OleDbConnection(strCon);


            string consultaPais = "select * from tblPaises";
            string consultaDepartamento = "select * from tblDepartamentos";
            string consultaMunicipio = "select * from tblMunicipios";
            string consultaHabitante = "select * from tblHabitantes";

            OleDbCommand comandoDepartamento = new OleDbCommand(consultaDepartamento, con);
            OleDbCommand comandoPais = new OleDbCommand(consultaPais, con);
            OleDbCommand comandoMunicipio = new OleDbCommand(consultaMunicipio, con);
            OleDbCommand comandoHabitante = new OleDbCommand(consultaHabitante, con);

            con.Open();
            comandoPais.CommandType = CommandType.Text;
            comandoDepartamento.CommandType = CommandType.Text;
            comandoMunicipio.CommandType = CommandType.Text;
            comandoHabitante.CommandType = CommandType.Text;


            OleDbDataReader drPais = comandoPais.ExecuteReader();
            OleDbDataReader drDepartamento = comandoDepartamento.ExecuteReader();
            OleDbDataReader drMunicipio = comandoMunicipio.ExecuteReader();
            OleDbDataReader drHabitante = comandoHabitante.ExecuteReader();


            Paises paises = new Paises();
            Departamento departamento = new Departamento();
            Municipio municipio = new Municipio();
            Habitante habitante = new Habitante();


            while (drPais.Read())
            {
                paises.IdPais = int.Parse(drPais["IdPais"].ToString());
                paises.nombrePais = drPais["nombrePais"].ToString();
                cmbPais.Items.Add(paises.nombrePais);
            }

            con.Close();

        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDepto.Items.Clear();
            cmbDepto.ResetText();
            cmbMunicipio.Items.Clear();
            cmbMunicipio.ResetText();
            listBoxHabitantes.Items.Clear();
            listBoxHabitantes.ResetText();

            string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" +
            Application.StartupPath + "\\bdHabitantes.accdb'";
            OleDbConnection con = new OleDbConnection(strCon);

            string consultaDepartamento = "select * from tblDepartamentos";
            string consultaPais = "select * from tblPaises";

            OleDbCommand comandoDepartamento = new OleDbCommand(consultaDepartamento, con);
            OleDbCommand comandoPais = new OleDbCommand(consultaPais, con);


            con.Open();
            comandoDepartamento.CommandType = CommandType.Text;
            comandoPais.CommandType = CommandType.Text;

            OleDbDataReader drDepartamento = comandoDepartamento.ExecuteReader();
            OleDbDataReader drPais = comandoPais.ExecuteReader();

            Departamento departamento = new Departamento();
            Paises paises = new Paises();


            string PaisActual = cmbPais.Text;
            int IdPaisActual = -1;

            while (drPais.Read())
            {
                if (PaisActual == drPais["nombrePais"].ToString())
                {
                    IdPaisActual = int.Parse(drPais["IdPais"].ToString());
                }

            }

            while (drDepartamento.Read())
            {
                int idTemp = int.Parse(drDepartamento["IdPais"].ToString());
                if (IdPaisActual == idTemp)
                {
                    departamento.IdDepartamento = int.Parse(drDepartamento["IdDepartamento"].ToString());
                    departamento.nombreDepartamento = drDepartamento["nombreDepartamento"].ToString();
                    cmbDepto.Items.Add(departamento.nombreDepartamento);
                }
            }


            con.Close();
        }


        private void cmbDepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMunicipio.Items.Clear();
            cmbMunicipio.ResetText();
            listBoxHabitantes.Items.Clear();
            listBoxHabitantes.ResetText();
            string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" +
            Application.StartupPath + "\\bdHabitantes.accdb'";
            OleDbConnection con = new OleDbConnection(strCon);
            string consultaDepartamento = "select * from tblDepartamentos";
            string consultaMunicipio = "select * from tblMunicipios";
            OleDbCommand comandoDepartamento = new OleDbCommand(consultaDepartamento, con);
            OleDbCommand comandoMunicipio = new OleDbCommand(consultaMunicipio, con);


            con.Open();
            comandoDepartamento.CommandType = CommandType.Text;
            comandoMunicipio.CommandType = CommandType.Text;


            OleDbDataReader drDepartamento = comandoDepartamento.ExecuteReader();
            OleDbDataReader drMunicipio = comandoMunicipio.ExecuteReader();

            Municipio municipio = new Municipio();


            string DepartamentoActual = cmbDepto.Text;
            int IdDepartamentoActual = -1;

            while (drDepartamento.Read())
            {
                if (DepartamentoActual == drDepartamento["nombreDepartamento"].ToString())
                {
                    IdDepartamentoActual = int.Parse(drDepartamento["IdDepartamento"].ToString());
                }

            }



            while (drMunicipio.Read())
            {
                int idTemp = int.Parse(drMunicipio["IdDepartamento"].ToString());
                if (IdDepartamentoActual == idTemp)
                {
                    municipio.IdMunicipio = int.Parse(drMunicipio["IdMunicipio"].ToString());
                    municipio.nombreMunicipio = drMunicipio["nombreMunicipio"].ToString();
                    cmbMunicipio.Items.Add(municipio.nombreMunicipio);
                }
            }


            con.Close();
        }

        private void cmbMunicipio_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listBoxHabitantes.Items.Clear();
            listBoxHabitantes.ResetText();
            string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" +
            Application.StartupPath + "\\bdHabitantes.accdb'";
            OleDbConnection con = new OleDbConnection(strCon);

            string consultaMunicipio = "select * from tblMunicipios";
            string consultaHabitante = "select * from tblHabitantes";

            OleDbCommand comandoMunicipio = new OleDbCommand(consultaMunicipio, con);
            OleDbCommand comandoHabitante = new OleDbCommand(consultaHabitante, con);

            con.Open();

            comandoMunicipio.CommandType = CommandType.Text;
            comandoHabitante.CommandType = CommandType.Text;

            OleDbDataReader drMunicipio = comandoMunicipio.ExecuteReader();
            OleDbDataReader drHabitante = comandoHabitante.ExecuteReader();

            Habitante habitante = new Habitante();

            string MunicipioActual = cmbMunicipio.Text;
            int IdMunicipioActual = -1;

            while (drMunicipio.Read())
            {
                if (MunicipioActual == drMunicipio["nombreMunicipio"].ToString())
                {
                    IdMunicipioActual = int.Parse(drMunicipio["IdMunicipio"].ToString());
                }

            }

            while (drHabitante.Read())
            {
                int idTemp = int.Parse(drHabitante["IdMunicipio"].ToString());
                if (IdMunicipioActual == idTemp)
                {
                    habitante.IdHabitante = int.Parse(drHabitante["IdHabitante"].ToString());
                    habitante.nombreHabitante = drHabitante["nombreHabitante"].ToString();
                    listBoxHabitantes.Items.Add(habitante.nombreHabitante);
                }
            }
            con.Close();
        }

        
        private bool EliminarHabitante(int idHabitante) //funcion para eliminar habitante de la base de datos
        {


            string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Application.StartupPath + "\\bdHabitantes.accdb'";
            using (OleDbConnection con = new OleDbConnection(strCon))
            {
                string consultaDelete = "DELETE FROM tblHabitantes WHERE IdHabitante = @idHabitante";
                using (OleDbCommand comandoDelete = new OleDbCommand(consultaDelete, con))
                {
                    comandoDelete.Parameters.AddWithValue("@idHabitante", idHabitante);

                    try
                    {
                        con.Open();
                        int filasAfectadas = comandoDelete.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el habitante de la base de datos: " + ex.Message, "Error");
                        return false;
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" +
            Application.StartupPath + "\\bdHabitantes.accdb'";
            OleDbConnection con = new OleDbConnection(strCon);
            string consultaHabitante = "select * from tblHabitantes";
            OleDbCommand comandoHabitante = new OleDbCommand(consultaHabitante, con);

            con.Open();
            comandoHabitante.CommandType = CommandType.Text;
            OleDbDataReader drHabitante = comandoHabitante.ExecuteReader();


            int indiceSeleccionado = listBoxHabitantes.SelectedIndex;
            if (indiceSeleccionado >= 0)
            {
                DialogResult confirmResult = MessageBox.Show("¿Está seguro que desea eliminar al habitante de la base de datos?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    int idHabitante = -1;
                    while (drHabitante.Read())
                    {
                        if (listBoxHabitantes.Text == drHabitante["nombreHabitante"].ToString())
                        {
                            idHabitante = int.Parse(drHabitante["IdHabitante"].ToString());
                        }
                    }


                    if (EliminarHabitante(idHabitante))
                    {
                        listBoxHabitantes.Items.RemoveAt(indiceSeleccionado);
                        listBoxHabitantes.Refresh();
                        MessageBox.Show("Se ha eliminado el habitante de la base de datos.", "COMPLETADO");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el habitante de la base de datos.", "ERROR");
                    }
                }
            }
        }
    }
}
