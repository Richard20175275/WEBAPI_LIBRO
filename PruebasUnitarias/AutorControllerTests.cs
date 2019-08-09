using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WEB_API_LIBRO.Controllers;
using WEB_API_LIBRO.Entities;

namespace PruebasUnitarias
{
    [TestClass]
    public class AutorControllerTests
    {
        [TestMethod]
        public void Get_SiElAutorNoExiste_SeNosRetornaUn404()
        {
            //Prepacion
            var idAutor = 1;
            var mock = new Mock<AutorController>();
            mock.Setup(x => x.Get(idAutor)).Returns(default(Autor));
            var autorController = new AutorController(mock.Object);

            // Prueba
            var resultado = autorController.Get(idAutor);

            // Ver
            Assert.IsInstanceOfType(resultado.Result, typeof(NotFoundResult));
        }
    }
}
