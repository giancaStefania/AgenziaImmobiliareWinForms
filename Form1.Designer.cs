
namespace ImmobiliWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaImmobili = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.via = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superficie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.in_vendita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognome_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifica = new System.Windows.Forms.DataGridViewButtonColumn();
            this.elimina = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nuovoProp = new System.Windows.Forms.Button();
            this.tipoProp = new System.Windows.Forms.Button();
            this.statistiche = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaImmobili)).BeginInit();
            this.SuspendLayout();
            // 
            // listaImmobili
            // 
            this.listaImmobili.AllowUserToAddRows = false;
            this.listaImmobili.AllowUserToDeleteRows = false;
            this.listaImmobili.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaImmobili.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timm,
            this.via,
            this.superficie,
            this.vani,
            this.prezzo,
            this.in_vendita,
            this.cf,
            this.nome_p,
            this.cognome_p,
            this.telefono_p,
            this.modifica,
            this.elimina});
            this.listaImmobili.Location = new System.Drawing.Point(12, 87);
            this.listaImmobili.Name = "listaImmobili";
            this.listaImmobili.ReadOnly = true;
            this.listaImmobili.Size = new System.Drawing.Size(1234, 387);
            this.listaImmobili.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elenco Immobili";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aggiungi Nuovo Immobile";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timm
            // 
            this.timm.DataPropertyName = "Tipo_imm";
            this.timm.HeaderText = "Tipo Immobile";
            this.timm.Name = "timm";
            this.timm.ReadOnly = true;
            // 
            // via
            // 
            this.via.DataPropertyName = "Via";
            this.via.HeaderText = "Via";
            this.via.Name = "via";
            this.via.ReadOnly = true;
            // 
            // superficie
            // 
            this.superficie.DataPropertyName = "Superfice";
            this.superficie.HeaderText = "Superficie";
            this.superficie.Name = "superficie";
            this.superficie.ReadOnly = true;
            // 
            // vani
            // 
            this.vani.DataPropertyName = "Vani";
            this.vani.HeaderText = "Vani";
            this.vani.Name = "vani";
            this.vani.ReadOnly = true;
            // 
            // prezzo
            // 
            this.prezzo.DataPropertyName = "Prezzo";
            this.prezzo.HeaderText = "Prezzo";
            this.prezzo.Name = "prezzo";
            this.prezzo.ReadOnly = true;
            // 
            // in_vendita
            // 
            this.in_vendita.DataPropertyName = "In_Vendita";
            this.in_vendita.HeaderText = "In Vendita";
            this.in_vendita.Name = "in_vendita";
            this.in_vendita.ReadOnly = true;
            // 
            // cf
            // 
            this.cf.DataPropertyName = "Prop";
            this.cf.HeaderText = "CF_Prop";
            this.cf.Name = "cf";
            this.cf.ReadOnly = true;
            // 
            // nome_p
            // 
            this.nome_p.DataPropertyName = "Prop";
            this.nome_p.HeaderText = "Nome Prop";
            this.nome_p.Name = "nome_p";
            this.nome_p.ReadOnly = true;
            // 
            // cognome_p
            // 
            this.cognome_p.DataPropertyName = "Prop";
            this.cognome_p.HeaderText = "Cognome Prop";
            this.cognome_p.Name = "cognome_p";
            this.cognome_p.ReadOnly = true;
            // 
            // telefono_p
            // 
            this.telefono_p.DataPropertyName = "Prop";
            this.telefono_p.HeaderText = "Telefono Prop";
            this.telefono_p.Name = "telefono_p";
            this.telefono_p.ReadOnly = true;
            // 
            // modifica
            // 
            this.modifica.DataPropertyName = "Modifica";
            this.modifica.HeaderText = "Modifica";
            this.modifica.Name = "modifica";
            this.modifica.ReadOnly = true;
            this.modifica.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modifica.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.modifica.Text = "Modifica";
            this.modifica.UseColumnTextForButtonValue = true;
            // 
            // elimina
            // 
            this.elimina.HeaderText = "Elimina";
            this.elimina.Name = "elimina";
            this.elimina.ReadOnly = true;
            this.elimina.Text = "Elimina";
            this.elimina.UseColumnTextForButtonValue = true;
            // 
            // nuovoProp
            // 
            this.nuovoProp.Location = new System.Drawing.Point(534, 536);
            this.nuovoProp.Name = "nuovoProp";
            this.nuovoProp.Size = new System.Drawing.Size(200, 23);
            this.nuovoProp.TabIndex = 3;
            this.nuovoProp.Text = "Aggiungi Nuovo Proprietario";
            this.nuovoProp.UseVisualStyleBackColor = true;
            this.nuovoProp.Click += new System.EventHandler(this.nuovoProp_Click);
            // 
            // tipoProp
            // 
            this.tipoProp.Location = new System.Drawing.Point(534, 575);
            this.tipoProp.Name = "tipoProp";
            this.tipoProp.Size = new System.Drawing.Size(200, 23);
            this.tipoProp.TabIndex = 4;
            this.tipoProp.Text = "Aggiungi Tipo Immobile";
            this.tipoProp.UseVisualStyleBackColor = true;
            this.tipoProp.Click += new System.EventHandler(this.tipoProp_Click);
            // 
            // statistiche
            // 
            this.statistiche.Location = new System.Drawing.Point(534, 611);
            this.statistiche.Name = "statistiche";
            this.statistiche.Size = new System.Drawing.Size(200, 23);
            this.statistiche.TabIndex = 5;
            this.statistiche.Text = "Visualizza Statistiche";
            this.statistiche.UseVisualStyleBackColor = true;
            this.statistiche.Click += new System.EventHandler(this.statistiche_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 646);
            this.Controls.Add(this.statistiche);
            this.Controls.Add(this.tipoProp);
            this.Controls.Add(this.nuovoProp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaImmobili);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.listaImmobili)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

   

        #endregion

        private System.Windows.Forms.DataGridView listaImmobili;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timm;
        private System.Windows.Forms.DataGridViewTextBoxColumn via;
        private System.Windows.Forms.DataGridViewTextBoxColumn superficie;
        private System.Windows.Forms.DataGridViewTextBoxColumn vani;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezzo;
        private System.Windows.Forms.DataGridViewTextBoxColumn in_vendita;
        private System.Windows.Forms.DataGridViewTextBoxColumn cf;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognome_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_p;
        private System.Windows.Forms.DataGridViewButtonColumn modifica;
        private System.Windows.Forms.DataGridViewButtonColumn elimina;
        private System.Windows.Forms.Button nuovoProp;
        private System.Windows.Forms.Button tipoProp;
        private System.Windows.Forms.Button statistiche;
    }
}

