using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WEB_API_LIBRO.Context;

namespace PPruebas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Get_SielAutorNoExiste_SeNosRetornaUn404()
        {
            var idAutor = 1;
            var mock = new Mock<ApplicatioDbContext>();
            mock.Setup(x => x.idAutor).Resturns(default(Autor));
        }
    }
}
