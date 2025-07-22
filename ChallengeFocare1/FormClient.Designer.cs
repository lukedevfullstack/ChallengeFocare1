
namespace ChallengeFocare1
{
    partial class FormClient
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.ComboBox cmbSexy;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvClients;
        private System.Windows.Forms.CheckBox chkMasculine;
        private System.Windows.Forms.CheckBox chkFeminine;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textAge = new System.Windows.Forms.TextBox();
            this.cmbSexy = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvClients = new System.Windows.Forms.ListView();
            this.chkMasculine = new System.Windows.Forms.CheckBox();
            this.chkFeminine = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();

            this.textAge.Location = new System.Drawing.Point(12, 12);
            this.textAge.Name = "txtIdade";
            this.textAge.PlaceholderText = "Idade";
            this.textAge.Size = new System.Drawing.Size(100, 23);

            this.cmbSexy.Location = new System.Drawing.Point(118, 12);
            this.cmbSexy.Name = "cmbSexo";
            this.cmbSexy.Size = new System.Drawing.Size(50, 23);

            this.btnAdd.Location = new System.Drawing.Point(174, 12);
            this.btnAdd.Name = "btnAdicionar";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdicionar_Click);

            this.chkMasculine.Location = new System.Drawing.Point(12, 41);
            this.chkMasculine.Name = "chkMasculino";
            this.chkMasculine.Text = "Masculino";
            this.chkMasculine.AutoSize = true;

            this.chkFeminine.Location = new System.Drawing.Point(110, 41);
            this.chkFeminine.Name = "chkFeminino";
            this.chkFeminine.Text = "Feminino";
            this.chkFeminine.AutoSize = true;

            this.lvClients.Location = new System.Drawing.Point(12, 70);
            this.lvClients.Name = "lvClientes";
            this.lvClients.Size = new System.Drawing.Size(240, 150);

            this.ClientSize = new System.Drawing.Size(270, 230);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.cmbSexy);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkMasculine);
            this.Controls.Add(this.chkFeminine);
            this.Controls.Add(this.lvClients);
            this.Name = "Form";
            this.Text = "Cadastro de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}