using Flunt.Validations;
using Produtor.Domain.ValueObjects;

namespace Produtor.Domain.Entidades
{
    public class Produtor : Entity
    {
        private IList<Propriedade> _propriedades;

        public Produtor(Nome nome, Documento documento, Endereco endereco)
        {
            Nome = nome;
            Documento = documento;
            Endereco = endereco;
            _propriedades = new List<Propriedade>();

            AddNotifications(nome, documento, endereco);
        }

        public Nome Nome { get; private set; }
        public Documento Documento { get; private set; }
        public Endereco Endereco { get; private set; }
        public IReadOnlyCollection<Propriedade> Propriedades => _propriedades.ToArray();

        public void AdicionarPropriedade(Propriedade propriedade)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsFalse(propriedade.Valid, "Produtor.Propriedades", "A propriedade está inválida")
                .IsTrue(propriedade.Ativa, "Produtor.Propriedades", "A propriedade precisa estar ativa"));

            if(Valid)
                _propriedades.Add(propriedade);
        }
    }
}
