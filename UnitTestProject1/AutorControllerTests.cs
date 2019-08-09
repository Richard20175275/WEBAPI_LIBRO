using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WEB_API_LIBRO.Controllers;
using WEB_API_LIBRO.Entities;
using WEB_API_LIBRO.Services;

namespace UnitTestProject1
{
    [TestClass]
    public class AutorControllerTests
    {
        [TestMethod]
        public void Prueba_GET_ID()
        {
            // preparación
            var idAutor = 1;
            var mock = new Mock<IRepAutor>();
            mock.Setup(x => x.ObtenerPorId(idAutor)).Returns(default(Autor));
            var autoresController = new AutorController(mock.Object);

            // prueba
            var resultado = autoresController.Get(idAutor);

            // Verificación
            Assert.IsInstanceOfType(resultado.Result, typeof(NotFoundResult));
        }
    }
}
