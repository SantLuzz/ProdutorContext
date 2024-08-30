using Flunt.Validations;
using System.IO;

namespace Produtor.Domain.ValueObjects
{
    public class Endereco : ValueObject
    {
        public Endereco(string rua, string numero, string bairro, string cep)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cep = cep;

            AddNotifications(new Contract()
            .Requires()
                .HasMinLen(Rua, 3, "Address.Street", "A rua deve conter pelo menos 3 caracteres"));
        }

        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cep { get; private set; }

    }
}
