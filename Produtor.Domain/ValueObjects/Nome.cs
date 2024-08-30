

using Flunt.Validations;

namespace Produtor.Domain.ValueObjects
{
    public class Nome : ValueObject
    {
        public Nome(string descricao)
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(descricao, 3, "Descricao", "nome deve conter ao menos 3 caractéres"));

            Descricao = descricao;
        }

        public string Descricao { get; private set; }
    }
}
