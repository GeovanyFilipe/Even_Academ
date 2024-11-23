using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Academ
{

    public static class EventoArquivoService
    {
        private static string _caminho = "eventos.txt";

        // Salva eventos em arquivo de texto
        public static async Task SalvarEventosAsync(List<Evento> eventos)
        {
            using (StreamWriter writer = new StreamWriter(_caminho, false))
            {
                foreach (var evento in eventos)
                {
                    var linha = $"{evento.Titulo};{evento.Descricao};{evento.DataHora:yyyy-MM-dd HH:mm};{evento.Criador}";
                    await writer.WriteLineAsync(linha);
                }
            }
        }

        // Carrega eventos do arquivo de texto
        public static async Task<List<Evento>> CarregarEventosAsync()
        {
            var eventos = new List<Evento>();

            if (!File.Exists(_caminho)) return eventos;

            using (StreamReader reader = new StreamReader(_caminho))
            {
                string linha;
                while ((linha = await reader.ReadLineAsync()) != null)
                {
                    var partes = linha.Split(';');
                    if (partes.Length == 4)
                    {
                        eventos.Add(new Evento
                        {
                            Titulo = partes[0],
                            Descricao = partes[1],
                            DataHora = DateTime.Parse(partes[2]),
                            Criador = partes[3]
                        });
                    }
                }
            }

            return eventos;
        }
    }
}
