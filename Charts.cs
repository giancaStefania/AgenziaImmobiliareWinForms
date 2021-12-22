using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ImmobiliWinForms
{
    public partial class Charts : Form
    {
        public Charts(List<Immobili> imms)
        {
            InitializeComponent();
            fillChart(imms);
        }
        private void fillChart(List<Immobili> lists)
        {
            var query = from pippo in lists
                        group pippo by pippo.Prop.Nome + " "+pippo.Prop.Cognome into custGroup
                        select custGroup;
            var query2 = from pippo in lists
                         group pippo by pippo.Prop.Nome + " " + pippo.Prop.Cognome into custGroup
                         select new
                         {
                             Name = custGroup.Key,
                             Prize = custGroup.Max(x => x.Prezzo)
                         };
            foreach (var imm2 in query2)
            {
                chartPropHouse.Series["Prezzo Maggiore dell'Immobile"].Points.AddXY(imm2.Name, imm2.Prize);
            }
            foreach (var imm in query)
            {
                Console.WriteLine();
                int numero = imm.Count<Immobili>();
                chartPropHouse.Series["Numero Case"].Points.AddXY(imm.Key,numero );
               
              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form1();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
