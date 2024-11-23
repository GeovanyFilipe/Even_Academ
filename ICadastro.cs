using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Academ
{
    public interface ICadastro<T>
    {
        void Adicionar(T entidade);
        List<T> Listar();
        T BuscarPorNome(string nome);
    }
}
