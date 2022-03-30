using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using WpfApp1;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOrdelier_Test001_SortTest001()
        {
            string caminho = "../../../Test001.txt";
            string txtordenado = Orderlier.Sorttxt(caminho);
            string caminhoNovoArquivo = caminho.Replace(".txt","Ordenado.txt");
           
            Assert.AreEqual(txtordenado, File.ReadAllText(caminhoNovoArquivo.Replace("../../../", "../../../ArquivosOrdenados/")));
        }
    }
}