namespace Produtor.Domain.Repositorios
{
    public interface IProdutorRepositorio
    {
        void Salvar(Produtor.Domain.Entidades.Produtor produtor);

        Produtor.Domain.Entidades.Produtor Recuperar(string documento);
    }
}
