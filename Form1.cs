using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImmobiliWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            listaImmobili.CellFormatting += ListaImmobili_CellFormatting;
            listaImmobili.CellContentClick += ListaImmobili_CellContentClick;
            SqlConnection cnn = DbUtils.GetConnection();
            cnn.Open();
            createDataTable(cnn);
            cnn.Close();
        }

        private void ListaImmobili_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            DataGridViewColumn column = this.listaImmobili.Columns[e.ColumnIndex];
                if (column.Name == "timm")
                {
                    TipoImmobile temp = e.Value as TipoImmobile;
                    if (temp != null)
                        e.Value = temp.Descrizione;
                }
                else
                {
                    if (column.Name == "cf" || column.Name == "nome_p" || column.Name == "cognome_p" || column.Name == "telefono_p")
                    {
                        Proprietario temp = e.Value as Proprietario;
                        if (column.Name == "cf")
                        {
                            if (temp != null)
                                e.Value = temp.Cf;

                        }
                        if (column.Name == "nome_p")
                        {
                            if (temp != null)
                                e.Value = temp.Nome;
                        }
                        if (column.Name == "cognome_p")
                        {
                            if (temp != null)
                                e.Value = temp.Cognome;
                        }
                        if (column.Name == "telefono_p")
                        {
                            if (temp != null)
                                e.Value = temp.Telefono;
                        }
                    }
                }
        }

        private void createDataTable(SqlConnection conn)
        {
            DataTable dt = new DataTable("Immobili");
            string sql = "SELECT i.id as id_imm,i.via, i.superfice, i.vani, i.prezzo, i.in_vendita,p.id as id_prop, p.CF, p.nome,p.cognome,p.telefono,tp.id as id_tp,tp.descrizione " +
                           "FROM Immobili i " +
                                "LEFT JOIN " +
                                "Proprietari p " +
                                "on " +
                                "i.id_proprietario = p.id " +
                                "LEFT JOIN TipiImmobile tp " +
                                "on " +
                                "i.id_tipo = tp.id";
            SqlDataReader rd = DbUtils.GetReader(conn, sql, null);
            List<Immobili> immo = new List<Immobili>();
            while (rd.Read())
            {
                TipoImmobile tp = null;
                Proprietario p = null;

                if (rd["id_tp"] != DBNull.Value && rd["descrizione"] != DBNull.Value)
                {
                    tp = new TipoImmobile(Convert.ToInt32(rd["id_tp"]), Convert.ToString(rd["descrizione"]));
                }
                if (rd["id_prop"] != DBNull.Value && rd["CF"] != DBNull.Value && rd["nome"] != DBNull.Value && rd["cognome"] != DBNull.Value && rd["telefono"] != DBNull.Value)
                {
                    p = new Proprietario(Convert.ToInt32(rd["id_prop"]), Convert.ToString(rd["CF"]), Convert.ToString(rd["nome"]), Convert.ToString(rd["cognome"]), Convert.ToString(rd["telefono"]));
                }
                immo.Add(new Immobili(Convert.ToInt32(rd["id_imm"]), tp, Convert.ToString(rd["via"]), Convert.ToString(rd["superfice"]), Convert.ToInt32(rd["vani"]), Convert.ToInt32(rd["prezzo"]), p, Convert.ToBoolean(rd["in_vendita"])));
            }
            var bindingList = new BindingList<Immobili>(immo);
            var source = new BindingSource(bindingList, null);

            listaImmobili.AutoGenerateColumns = false;

            listaImmobili.DataSource = source;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new NuovoImmobile();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
        private void ListaImmobili_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

            DataGridViewColumn column = this.listaImmobili.Columns[e.ColumnIndex];
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && column.Name == "modifica")
            {
                DataGridViewRow row = this.listaImmobili.Rows[e.RowIndex];
                Immobili imm = (Immobili)row.DataBoundItem;
                this.Hide();
                var form2 = new NuovoImmobile(imm);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            if(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && column.Name == "elimina")
            {
                DataGridViewRow row = this.listaImmobili.Rows[e.RowIndex];
                Immobili imm = (Immobili)row.DataBoundItem;
                SqlConnection conn = DbUtils.GetConnection();
                conn.Open();
                eliminaImmobile(imm, conn);
                //aggiorno la dataGridView
                createDataTable(conn);
                conn.Close();

            }
        }
        private void eliminaImmobile(Immobili imm, SqlConnection conn)
        {
            DbUtils.ExecCommand(conn, "DELETE FROM Immobili WHERE id = @id", new Dictionary<string, object>(){ { "id", imm.Id } });
        }

        private void nuovoProp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new FormProprietario();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void tipoProp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new FormTipoImmobile();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void statistiche_Click(object sender, EventArgs e)
        {
            List<Immobili> lista = new List<Immobili>();
            for (int i = 0; i < this.listaImmobili.RowCount; i++)
            {
                DataGridViewRow row = this.listaImmobili.Rows[i];
                Immobili imm = (Immobili)row.DataBoundItem;
                lista.Add(imm);
            }
            this.Hide();
            var form2 = new Charts(lista);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
