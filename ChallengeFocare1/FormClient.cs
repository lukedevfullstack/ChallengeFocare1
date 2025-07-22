
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChallengeFocare1
{
    public partial class FormClient : System.Windows.Forms.Form
    {
        private List<Client> listClients = new();

        public FormClient()
        {
            InitializeComponent();

            cmbSexy.Items.AddRange(new string[] { "M", "F" });
            cmbSexy.DropDownStyle = ComboBoxStyle.DropDownList;

            lvClients.View = View.Details;
            lvClients.Columns.Add("Idade", 100);
            lvClients.Columns.Add("Sexo", 100);

            chkMasculine.CheckedChanged += Filtro_CheckedChanged;
            chkFeminine.CheckedChanged += Filtro_CheckedChanged;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textAge.Text, out int idade) && cmbSexy.SelectedItem != null)
            {
                string sexy = cmbSexy.SelectedItem.ToString();
                listClients.Add(new Client(idade, sexy));
                AtualizarListView();
            }
            else
            {
                MessageBox.Show("Preencha corretamente idade e sexo.");
            }
        }

        private void Filtro_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarListView();
        }

        private void AtualizarListView()
        {
            var clientesFiltrados = listClients
                .OrderBy(c => c.Age)
                .Where(c =>
                    (chkMasculine.Checked && c.Sexy == "M") ||
                    (chkFeminine.Checked && c.Sexy == "F") ||
                    (!chkMasculine.Checked && !chkFeminine.Checked)
                )
                .ToList();

            lvClients.Items.Clear();
            foreach (var cliente in clientesFiltrados)
            {
                var item = new ListViewItem(cliente.Age.ToString());
                item.SubItems.Add(cliente.Sexy);
                lvClients.Items.Add(item);
            }
        }
    }
}
