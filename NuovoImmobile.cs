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
    public partial class NuovoImmobile : Form
    {
        public NuovoImmobile()
        {
            InitializeComponent();
            via.Leave += Via_Leave;
            superficie.Leave += Via_Leave;
            nvani.Leave += Via_Leave;
            prezzo.Leave += Via_Leave;
            this.formImmobili.Margin = new Padding((this.ClientSize.Width - formImmobili.Width) / 2, (this.ClientSize.Height - formImmobili.Height) / 2, 0, 0);
            SqlConnection conn = DbUtils.GetConnection();
            conn.Open();
            fillComboBoxes(conn);
            conn.Close();
        }

        private void Via_Leave(object sender, EventArgs e)
        {
            if(((TextBox)sender).Text == "")
                ((TextBox)sender).BackColor = Color.Red;
            else
                ((TextBox)sender).BackColor = Color.White;
        }
        public NuovoImmobile(Immobili imm)
        {
            InitializeComponent();
            this.formImmobili.Margin = new Padding((this.ClientSize.Width - formImmobili.Width) / 2, (this.ClientSize.Height - formImmobili.Height) / 2, 0, 0);
            SqlConnection conn = DbUtils.GetConnection();
            conn.Open();
            fillComboBoxes(conn);
            via.Text = imm.Via;
            superficie.Text = imm.Superfice;
            nvani.Text = imm.Vani.ToString();
            prezzo.Text = imm.Prezzo.ToString();
            if (imm.Prop != null)
            {
                prop.Text = imm.Prop.Nome + " " + imm.Prop.Cognome;
            }
            if (imm.Tipo_imm != null)
            {
                tipo.Text = imm.Tipo_imm.Descrizione;
            }
            in_vendita.SelectedItem = imm.In_vendita == true ? "Si" : "No";
            button1.Tag = imm.Id;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                string via_box = via.Text;
                string sup = superficie.Text;
                int vani = Convert.ToInt32(nvani.Text);
                int price = Convert.ToInt32(prezzo.Text);
                KeyValuePair<string, string> cbProp = (KeyValuePair<string, string>)prop.SelectedItem;
                KeyValuePair<string, string> cBImm = (KeyValuePair<string, string>)tipo.SelectedItem;
                bool vendita = in_vendita.Text == "Si" ? vendita = true : vendita = false;
                int id_tipo_imm = (String)cBImm.Value == "Nessun Tipo" ? -1 : Convert.ToInt32(cBImm.Key);
                int id_proprietario = (String)cbProp.Value == "Nessun Proprietario" ? -1 : Convert.ToInt32(cbProp.Key);
                SqlConnection conn = DbUtils.GetConnection();
                conn.Open();
                string sql;
                Dictionary<string, object> dict = new Dictionary<string, object>();
                if (((Button)sender).Tag != null)
                {
                    sql = "UPDATE Immobili" +
                             "   SET id_tipo = @idt,via = @via, superfice=@sup, vani=@vani,prezzo=@prezzo,id_proprietario=@idp,in_vendita=@ven " +
                             " WHERE id = @id";
                    dict.Add("id", ((Button)sender).Tag);
                }
                else
                {
                    sql = "INSERT INTO Immobili (id_tipo,via,superfice,vani,prezzo,id_proprietario,in_vendita) VALUES(@idt,@via,@sup,@vani,@prezzo,@idp,@ven)";
                }
                
                if (id_tipo_imm == -1)
                    dict.Add("idt", null);
                else
                    dict.Add("idt", id_tipo_imm);
                dict.Add("via", via_box);
                dict.Add("sup", sup);
                dict.Add("vani", vani);
                dict.Add("prezzo", price);
                if (id_proprietario == -1)
                    dict.Add("idp", null);
                else
                    dict.Add("idp", id_proprietario);
                dict.Add("ven", vendita);
                DbUtils.ExecCommand(conn, sql, dict);
                conn.Close();
                if (System.Windows.MessageBox.Show("Operazione riuscita", "Immobile inserito con successo!!") == MessageBoxResult.OK)
                {
                    this.Hide();
                    var form2 = new Form1();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();

                }
            }
        }
        private void fillComboBoxes(SqlConnection conn)
        {
            SqlDataReader rd = DbUtils.GetReader(conn, "SELECT * FROM Proprietari", null);

            Dictionary<string, string> propDiz = new Dictionary<string, string>();
            propDiz.Add("-1", "Nessun Proprietario");
           
            while (rd.Read())
            {
                propDiz.Add(rd["id"].ToString(), rd["nome"].ToString() + " " + rd["cognome"].ToString());
            }
            rd.Close();
            prop.DataSource = new BindingSource(propDiz, null);
            prop.DisplayMember = "Value";
            prop.ValueMember = "Key";

            Dictionary<string, string> tipoDiz = new Dictionary<string, string>();
            rd = DbUtils.GetReader(conn, "SELECT * FROM TipiImmobile", null);
            tipoDiz.Add("-1", "Nessun Tipo");
            while (rd.Read())
            {
                tipoDiz.Add(rd["id"].ToString(), rd["descrizione"].ToString());
            }
            tipo.DataSource = new BindingSource(tipoDiz, null);
            tipo.DisplayMember = "Value";
            tipo.ValueMember = "Key";
            rd.Close();
        }
        private bool checkFields()
        {
            bool check = true;
            if (via.Text == "" || superficie.Text == "" || nvani.Text == "" || prezzo.Text == "")
                check = false;
            if (!check)
                errore.Text = "Campi Obbligatori";
            return check;
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
