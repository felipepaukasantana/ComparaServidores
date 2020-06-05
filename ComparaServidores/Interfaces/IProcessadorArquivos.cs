using System.Text;

namespace ComparaServidores.Interfaces
{
    public interface IProcessadorArquivos
    {
        void Processar();

        StringBuilder GetDados();
    }
}