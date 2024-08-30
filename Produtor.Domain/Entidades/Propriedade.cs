using Produtor.Domain.ValueObjects;

namespace Produtor.Domain.Entidades
{
    public class Propriedade : Entity
    {
        public Propriedade(Nome nome, Documento documento, Endereco endereco)
        {
            Nome = nome;
            Documento = documento;
            Endereco = endereco;
            Ativa = true;
        }

        public Nome Nome { get; private set; }
        public Documento Documento { get; set; }
        public Endereco Endereco { get; private set; }
        public bool Ativa { get; private set; }


        public void Ativar()
        {
            Ativa = true;
        }

        public void Desativar()
        {
            Ativa = false;
        }
    }
}
