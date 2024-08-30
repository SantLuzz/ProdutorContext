using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtor.Tests.ValueObjects
{
    [TestClass]
    public class ValueObjectTests
    {
        [TestMethod]
        [TestCategory("VOs")]
        public void Dado_um_novo_nome_deve_retornar_erro_ao_inserir_vazio_ou_menor_que_3_caracteres()
        {
            Assert.Fail();
        }

        [TestMethod]
        [TestCategory("VOs")]
        public void Dado_um_novo_nome_deve_retornar_sucesso_ao_inserir_maior_que_3_caracteres()
        {
            Assert.Fail();
        }

        [TestMethod]
        [TestCategory("VOs")]
        public void Dado_um_novo_cpf_retorna_erro_quando_invalido()
        {
            Assert.Fail();
        }

        [TestMethod]
        [TestCategory("VOs")]
        public void Dado_um_novo_cnpj_retorna_erro_quando_invalido()
        {
            Assert.Fail();
        }

        [TestMethod]
        [TestCategory("VOs")]
        public void Dado_uma_nova_ie_retorna_erro_quando_invalido()
        {
            Assert.Fail();
        }

        [TestMethod]
        [TestCategory("VOs")]
        public void Dado_um_novo_cpf_retorna_sucesso_quando_valido()
        {
            Assert.Fail();
        }

        [TestMethod]
        [TestCategory("VOs")]
        public void Dado_um_novo_cnpj_retorna_sucesso_quando_valido()
        {
            Assert.Fail();
        }

        [TestMethod]
        [TestCategory("VOs")]
        public void Dado_uma_nova_ie_retorna_sucesso_quando_valido()
        {
            Assert.Fail();
        }

        [TestMethod]
        [TestCategory("VOs")]
        public void Dado_um_novo_endereco_retorna_erro_se_rua_for_vazia()
        {
            Assert.Fail();
        }

        [TestMethod]
        [TestCategory("VOs")]
        public void Dado_um_novo_endereco_retorna_sucesso_se_rua_for_preenchida()
        {
            Assert.Fail();
        }
    }
}
