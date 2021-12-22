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
    public partial class FormTipoImmobile : Form
    {
        public FormTipoImmobile()
        {
            InitializeComponent();
            descrizione.Leave += Descrizione_Leave;
            this.boxTipo.Margin = new Padding((this.ClientSize.Width - boxTipo.Width) / 2, (this.ClientSize.Height - boxTipo.Height) / 2, 0, 0);
            indietro.Location=new Point(0,0);

        }

        private void Descrizione_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
                ((TextBox)sender).BackColor = Color.Red;
            else
                ((TextBox)sender).BackColor = Color.White;
        }

        private void invia_Click(object sender, EventArgs e)
        {
            if(descrizione.Text != "")
            {
                string descrizione_tp = descrizione.Text;
                SqlConnection conn = DbUtils.GetConnection();
                conn.Open();
                string sql = "INSERT INTO TipiImmobile ( descrizione ) VALUES (@desc)";
                DbUtils.ExecCommand(conn, sql, new Dictionary<string, object>() { { "desc", descrizione_tp } });
                conn.Close();
                if (System.Windows.MessageBox.Show("Operazione riuscita", "Tipo Immobile inserito con successo!!") == MessageBoxResult.OK)
                {
                    this.Hide();
                    var form2 = new Form1();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();

                }
            }
        }
        private void indietro_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form1();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
