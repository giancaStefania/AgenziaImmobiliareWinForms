
namespace ImmobiliWinForms
{
    partial class FormProprietario
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
            this.propBox = new System.Windows.Forms.GroupBox();
            this.invia = new System.Windows.Forms.Button();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cognome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.indietro = new System.Windows.Forms.Button();
            this.propBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // propBox
            // 
            this.propBox.Controls.Add(this.invia);
            this.propBox.Controls.Add(this.telefono);
            this.propBox.Controls.Add(this.label4);
            this.propBox.Controls.Add(this.cognome);
            this.propBox.Controls.Add(this.label3);
            this.propBox.Controls.Add(this.nome);
            this.propBox.Controls.Add(this.label2);
            this.propBox.Controls.Add(this.cf);
            this.propBox.Controls.Add(this.label1);
            this.propBox.Location = new System.Drawing.Point(3, 3);
            this.propBox.Name = "propBox";
            this.propBox.Size = new System.Drawing.Size(385, 313);
            this.propBox.TabIndex = 0;
            this.propBox.TabStop = false;
            this.propBox.Text = "Dati Proprietario";
            // 
            // invia
            // 
            this.invia.Location = new System.Drawing.Point(71, 256);
            this.invia.Name = "invia";
            this.invia.Size = new System.Drawing.Size(259, 23);
            this.invia.TabIndex = 6;
            this.invia.Text = "invia";
            this.invia.UseVisualStyleBackColor = true;
            this.invia.Click += new System.EventHandler(this.invia_Click);
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(169, 199);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(161, 20);
            this.telefono.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Telefono";
            // 
            // cognome
            // 
            this.cognome.Location = new System.Drawing.Point(169, 147);
            this.cognome.Name = "cognome";
            this.cognome.Size = new System.Drawing.Size(161, 20);
            this.cognome.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cognome";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(169, 97);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(161, 20);
            this.nome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // cf
            // 
            this.cf.Location = new System.Drawing.Point(169, 49);
            this.cf.Name = "cf";
            this.cf.Size = new System.Drawing.Size(161, 20);
            this.cf.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codice Fiscale";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.propBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(758, 463);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // indietro
            // 
            this.indietro.Location = new System.Drawing.Point(0, 1);
            this.indietro.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.indietro.Name = "indietro";
            this.indietro.Size = new System.Drawing.Size(75, 23);
            this.indietro.TabIndex = 1;
            this.indietro.Text = "<-";
            this.indietro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.indietro.UseVisualStyleBackColor = true;
            this.indietro.Click += new System.EventHandler(this.indietro_Click);
            // 
            // FormProprietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 488);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.indietro);
            this.Name = "FormProprietario";
            this.Text = "FormProprietario";
            this.Load += new System.EventHandler(this.FormProprietario_Load);
            this.propBox.ResumeLayout(false);
            this.propBox.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox propBox;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cognome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button invia;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button indietro;
    }
}