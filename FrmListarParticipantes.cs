using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Even_Academ
{
    public partial class FrmListarParticipantes : Form
    {
        private List<Evento> _eventos;

        public FrmListarParticipantes(List<Evento> eventos)
        {
            InitializeComponent();
            _eventos = eventos;
            CarregarEventos();
        }

        private void CarregarEventos()
        {
            comboBox1.DataSource = _eventos;
            comboBox1.DisplayMember = "Titulo";
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            var eventoSelecionado = comboBox1.SelectedItem as Evento;

            // Listar participantes inscritos no evento
            var participantes = eventoSelecionado.Participantes
                .Where(p => p.Tipo == "Estudante") // Apenas estudantes
                .Select(p => new { p.Nome, p.Email })
                .ToList();

            dataGridView1.DataSource = participantes;

            if (participantes.Count == 0)
            {
                MessageBox.Show("Nenhum estudante inscrito neste evento.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
