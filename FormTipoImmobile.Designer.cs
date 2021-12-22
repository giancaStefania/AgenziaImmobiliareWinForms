
namespace ImmobiliWinForms
{
    partial class FormTipoImmobile
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
            this.boxTipo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descrizione = new System.Windows.Forms.TextBox();
            this.invia = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.indietro = new System.Windows.Forms.Button();
            this.boxTipo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxTipo
            // 
            this.boxTipo.Controls.Add(this.invia);
            this.boxTipo.Controls.Add(this.descrizione);
            this.boxTipo.Controls.Add(this.label1);
            this.boxTipo.Location = new System.Drawing.Point(3, 3);
            this.boxTipo.Name = "boxTipo";
            this.boxTipo.Size = new System.Drawing.Size(396, 136);
            this.boxTipo.TabIndex = 0;
            this.boxTipo.TabStop = false;
            this.boxTipo.Text = "Nuovo Tipo Immobile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrizione";
            // 
            // descrizione
            // 
            this.descrizione.Location = new System.Drawing.Point(144, 49);
            this.descrizione.Name = "descrizione";
            this.descrizione.Size = new System.Drawing.Size(171, 20);
            this.descrizione.TabIndex = 1;
            // 
            // invia
            // 
            this.invia.Location = new System.Drawing.Point(62, 92);
            this.invia.Name = "invia";
            this.invia.Size = new System.Drawing.Size(253, 23);
            this.invia.TabIndex = 2;
            this.invia.Text = "Invia";
            this.invia.UseVisualStyleBackColor = true;
            this.invia.Click += new System.EventHandler(this.invia_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.boxTipo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(798, 425);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // indietro
            // 
            this.indietro.Location = new System.Drawing.Point(1, 0);
            this.indietro.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.indietro.Name = "indietro";
            this.indietro.Size = new System.Drawing.Size(75, 23);
            this.indietro.TabIndex = 1;
            this.indietro.Text = "<-";
            this.indietro.UseVisualStyleBackColor = true;
            this.indietro.Click += new System.EventHandler(this.indietro_Click_1);
            // 
            // FormTipoImmobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.indietro);
            this.Name = "FormTipoImmobile";
            this.Text = "FormTipoImmobile";
            this.boxTipo.ResumeLayout(false);
            this.boxTipo.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxTipo;
        private System.Windows.Forms.Button invia;
        private System.Windows.Forms.TextBox descrizione;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button indietro;
    }
}