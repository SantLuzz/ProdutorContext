using Flunt.Validations;
using Produtor.Domain.Enums;

namespace Produtor.Domain.ValueObjects
{
    public class Documento : ValueObject
    {
        public Documento(string numero, ETipoDocumento tipo)
        {
            Numero = numero;
            Tipo = tipo;

            AddNotifications(new Contract()
                .Requires()
                .IsTrue(Validar(), "Numero", "Documento inválido"));
        }

        public string Numero { get; private set; }
        public ETipoDocumento Tipo { get; private set; }


        public bool Validar()
        {
            if(Tipo == ETipoDocumento.Cpf && Numero.Length == 11)
                return true;

            if (Tipo == ETipoDocumento.Cnpj && Numero.Length == 14)
                return true;

            if(Tipo == ETipoDocumento.Ie && Numero.Length > 0)
                return true;

            return false;
        }

    }
}
