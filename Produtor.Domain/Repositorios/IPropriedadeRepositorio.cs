using Produtor.Domain.Entidades;

namespace Produtor.Domain.Repositorios
{
    public interface IPropriedadeRepositorio
    {
        void Salvar(IEnumerable<Propriedade> propriedades);
        IEnumerable<Propriedade> Obter(string ie);
    }
}
