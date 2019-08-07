using Moq;
using NUnit.Framework;
using WEB_API_LIBRO.Context;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Get_Sielautornoexiste_seretornaraun404()
        {
            var idAutor = 1;
            var mock = new Mock<ApplicatioDbContext>();
            mock.Setup(x=>x.ObtenerPorId(idAutor)).Returns(default(Autor));
        }
    }
}