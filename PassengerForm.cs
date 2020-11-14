using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Insert_in_Database__MDI_
{
    public partial class PassengerForm : Form
    {
        string connection_String = ConfigurationManager.ConnectionStrings["mon_connection"].ConnectionString;
        SqlConnection connection;
        SqlCommand command;
        public PassengerForm()
        {
            InitializeComponent();
        }
        private void Inserer_Passanger_Click(object sender, EventArgs e)
        {      
            string query = string.Format("insert into passager values('{0}','{1}','{2}','{3}')",Passager_Pass.Text, Passager_Nom.Text, Passager_Prenom.Text, Passager_ville.Text);
            try
            {
                using (connection)
                {
                    connection = new SqlConnection(connection_String);
                    command = new SqlCommand(query, connection);
                    connection.Open();
                    int nombre_lignes_affecte = command.ExecuteNonQuery();
                    MessageBox.Show(nombre_lignes_affecte + " lignes a ete affecte.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
