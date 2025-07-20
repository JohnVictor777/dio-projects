using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using minimal_api.Dominio.Entidades;

namespace TestMinimalApi.Domain.Entidades;

[TestClass]
public class AdministradorTest
{
    [TestMethod]
    public void TestarGetSetPropriedade()
    {
        // Arrange

        var adm = new Administrador();

        // Act
        adm.Id = 1;
        adm.Email = "teste@exemplo.com";
        adm.Senha = "senha123";
        adm.Perfil = "Adm";
        // Assert
        Assert.AreEqual(1, adm.Id);
        Assert.AreEqual("teste@exemplo.com", adm.Email);
        Assert.AreEqual("senha123", adm.Senha);
        Assert.AreEqual("Adm", adm.Perfil);
    }
}
