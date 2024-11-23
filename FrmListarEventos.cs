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
    public partial class FrmListarEventos : Form
    {
        private List<Evento> _eventos;

        public FrmListarEventos(List<Evento> eventos)
        {
            InitializeComponent();
            _eventos = eventos;
            CarregarEventos();
        }

        private void CarregarEventos()
        {
            dataGridView1.DataSource = _eventos.Select(e => new
            {
                e.Titulo,
                e.Descricao,
                DataHora = e.DataHora.ToString("dd/MM/yyyy HH:mm"),
                e.Criador
            }).ToList(); // Apenas os campos necessários para exibição
        }
    }
}

