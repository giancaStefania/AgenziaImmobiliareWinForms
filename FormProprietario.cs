using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ImmobiliWinForms
{
    public partial class FormProprietario : Form
    {
        public FormProprietario()
        {
            InitializeComponent();
            cf.Leave += field_Leave;
            nome.Leave += field_Leave;
            cognome.Leave += field_Leave;
            telefono.Leave += field_Leave;
            this.propBox.Margin = new Padding((this.ClientSize.Width - propBox.Width) / 2, (this.ClientSize.Height - propBox.Height) / 2, 0, 0);

        }
        private void invia_Click(object sender, EventArgs e)
        {
            if (checkValidity())
            {
                string cf_prop = cf.Text;
                string nome_p = nome.Text;
                string cognome_p = cognome.Text;
                string telefono_p = telefono.Text;
                SqlConnection conn = DbUtils.GetConnection();
                conn.Open();
                string sql = "INSERT INTO Proprietari (CF, nome, cognome, telefono) VALUES (@cf,@nome,@cognome,@telefono)";
                Dictionary<string, object> diz = new Dictionary<string, object>();
                diz.Add("cf", cf_prop);
                diz.Add("nome", nome_p);
                diz.Add("cognome", cognome_p);
                diz.Add("telefono", telefono_p);
                DbUtils.ExecCommand(conn, sql, diz);
                conn.Close();
                if (System.Windows.MessageBox.Show("Operazione riuscita", "Proprietario inserito con successo!!") == MessageBoxResult.OK)
                {
                    this.Hide();
                    var form2 = new Form1();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();

                }
            }
        }
        private bool checkValidity()
        {
            bool isValid = true;
            if (cf.Text == "" || cf.TextLength != 16)
                isValid = false;
            if (nome.Text == "")
                isValid = false;
            if (cognome.Text == "")
                isValid = false;
            if (telefono.Text == "")
                isValid = false;
            return isValid;
        }
        private void field_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
                ((TextBox)sender).BackColor = Color.Red;
            else
                ((TextBox)sender).BackColor = Color.White;
        }

        private void FormProprietario_Load(object sender, EventArgs e)
        {

        }

        private void indietro_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form1();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
