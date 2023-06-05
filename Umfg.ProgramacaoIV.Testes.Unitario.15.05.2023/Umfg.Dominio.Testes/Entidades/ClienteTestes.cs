using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Umfg.Dominio.Entidades;

namespace Umfg.Dominio.Testes.Entidades
{
    [TestClass]
    public sealed class ClienteTestes
    {
        private const string _firstOwner = "Vinicius Gabriel";
        private const string _secondOwner = "Elizete Rocha";
        private const string _category = "Cliente";

        [TestMethod]
        [Owner(_firstOwner)]
        [TestCategory(_category)]
        public void Cliente_Construtor_Sucesso()
        {
            try
            {
                var cliente = new Cliente("59958894204", "TESTE");
                Assert.AreEqual("TESTE", cliente.Nome);
                Assert.AreEqual("59958894204", cliente.Documento);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        [Owner(_firstOwner)]
        [TestCategory(_category)]
        public void Cliente_DocumentoNull_ThrowArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Cliente(null, "TESTE"));
        }


        [TestMethod]
        [Owner(_firstOwner)]
        [TestCategory(_category)]
        public void Cliente_NomeNull_ThrowArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Cliente("10494265922", null));
        }


        [TestMethod]
        [Owner(_firstOwner)]
        [TestCategory(_category)]
        public void Cliente_DocumentoVazio_ThrowArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Cliente("", "TESTE"));
        }

        [TestMethod]
        [Owner(_firstOwner)]
        [TestCategory(_category)]
        public void Cliente_NomeVazio_ThrowArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Cliente("10494265922", ""));
        }
    }
}
