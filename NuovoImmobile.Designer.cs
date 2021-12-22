

namespace ImmobiliWinForms
{
    partial class NuovoImmobile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.formImmobili = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.in_vendita = new System.Windows.Forms.ComboBox();
            this.errore = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.prop = new System.Windows.Forms.ComboBox();
            this.prezzo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nvani = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.superficie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.via = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.indietro = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.formImmobili.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.formImmobili);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, -1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(802, 452);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // formImmobili
            // 
            this.formImmobili.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.formImmobili.Controls.Add(this.button1);
            this.formImmobili.Controls.Add(this.in_vendita);
            this.formImmobili.Controls.Add(this.errore);
            this.formImmobili.Controls.Add(this.label8);
            this.formImmobili.Controls.Add(this.tipo);
            this.formImmobili.Controls.Add(this.label7);
            this.formImmobili.Controls.Add(this.prop);
            this.formImmobili.Controls.Add(this.prezzo);
            this.formImmobili.Controls.Add(this.label5);
            this.formImmobili.Controls.Add(this.label6);
            this.formImmobili.Controls.Add(this.nvani);
            this.formImmobili.Controls.Add(this.label4);
            this.formImmobili.Controls.Add(this.superficie);
            this.formImmobili.Controls.Add(this.label3);
            this.formImmobili.Controls.Add(this.via);
            this.formImmobili.Controls.Add(this.label2);
            this.formImmobili.Location = new System.Drawing.Point(9, 3);
            this.formImmobili.Name = "formImmobili";
            this.formImmobili.Size = new System.Drawing.Size(501, 385);
            this.formImmobili.TabIndex = 1;
            this.formImmobili.TabStop = false;
            this.formImmobili.Text = "Dati Immobile";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Invia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // in_vendita
            // 
            this.in_vendita.FormattingEnabled = true;
            this.in_vendita.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.in_vendita.Location = new System.Drawing.Point(183, 287);
            this.in_vendita.Name = "in_vendita";
            this.in_vendita.Size = new System.Drawing.Size(238, 21);
            this.in_vendita.TabIndex = 12;
            this.in_vendita.Text = "Si";
            // 
            // errore
            // 
            this.errore.AutoSize = true;
            this.errore.ForeColor = System.Drawing.Color.Red;
            this.errore.Location = new System.Drawing.Point(421, 369);
            this.errore.Name = "errore";
            this.errore.Size = new System.Drawing.Size(0, 13);
            this.errore.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "In vendita?";
            // 
            // tipo
            // 
            this.tipo.FormattingEnabled = true;
            this.tipo.Items.AddRange(new object[] {
            "Nessun Tipo"});
            this.tipo.Location = new System.Drawing.Point(183, 243);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(238, 21);
            this.tipo.TabIndex = 10;
            this.tipo.Text = "Nessun Tipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tipo Immobile";
            // 
            // prop
            // 
            this.prop.FormattingEnabled = true;
            this.prop.Items.AddRange(new object[] {
            "Nessun Proprietario"});
            this.prop.Location = new System.Drawing.Point(183, 199);
            this.prop.Name = "prop";
            this.prop.Size = new System.Drawing.Size(238, 21);
            this.prop.TabIndex = 8;
            this.prop.Text = "Nessun Proprietario";
            // 
            // prezzo
            // 
            this.prezzo.Location = new System.Drawing.Point(183, 154);
            this.prezzo.Name = "prezzo";
            this.prezzo.Size = new System.Drawing.Size(238, 20);
            this.prezzo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Prezzo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Proprietario";
            // 
            // nvani
            // 
            this.nvani.Location = new System.Drawing.Point(183, 107);
            this.nvani.Name = "nvani";
            this.nvani.Size = new System.Drawing.Size(238, 20);
            this.nvani.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numero Vani";
            // 
            // superficie
            // 
            this.superficie.Location = new System.Drawing.Point(183, 63);
            this.superficie.Name = "superficie";
            this.superficie.Size = new System.Drawing.Size(238, 20);
            this.superficie.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Superficie";
            // 
            // via
            // 
            this.via.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.via.Location = new System.Drawing.Point(183, 20);
            this.via.Name = "via";
            this.via.Size = new System.Drawing.Size(238, 20);
            this.via.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Via";
            // 
            // indietro
            // 
            this.indietro.Location = new System.Drawing.Point(0, 0);
            this.indietro.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.indietro.Name = "indietro";
            this.indietro.Size = new System.Drawing.Size(75, 23);
            this.indietro.TabIndex = 1;
            this.indietro.Text = "<-";
            this.indietro.UseVisualStyleBackColor = true;
            this.indietro.Click += new System.EventHandler(this.indietro_Click);
            // 
            // NuovoImmobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.indietro);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "NuovoImmobile";
            this.Text = "NuovoImmobile";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.formImmobili.ResumeLayout(false);
            this.formImmobili.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox formImmobili;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nvani;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox superficie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox via;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox prop;
        private System.Windows.Forms.TextBox prezzo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox in_vendita;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label errore;
        private System.Windows.Forms.Button indietro;
    }
}