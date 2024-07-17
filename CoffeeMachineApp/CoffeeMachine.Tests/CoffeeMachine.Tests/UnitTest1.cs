namespace CoffeeMachine.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var cafetera = new Cafetera(50);
            var vasoPequeno = new Vaso(5, 10);
            var vasoMediano = new Vaso(5, 20);
            var vasoGrande = new Vaso(5, 30);
            var azucarero = new Azucarero(20);
            var maquinaDeCafe = new MaquinaDeCafe();
            maquinaDeCafe.setCafetera(cafetera);
            maquinaDeCafe.setVasosPequeno(vasoPequeno);
            maquinaDeCafe.setVasosMediano(vasoMediano);
            maquinaDeCafe.setVasosGrande(vasoGrande);
            maquinaDeCafe.setAzucarero(azucarero);

            Assert.AreEqual("Felicitaciones", maquinaDeCafe.getVasoDeCafe(vasoPequeno, 1, 10));
            Assert.AreEqual(40, cafetera.getCantidadCafe());
            Assert.AreEqual(10, azucarero.getCantidadAzucar());
            Assert.AreEqual(4, vasoPequeno.getCantidadVasos());
    }
       [TestMethod]
        public void TestNoCafe()
        {
            var cafetera = new Cafetera(5);
            var vasoPequeno = new Vaso(5, 10);
            var azucarero = new Azucarero(20);
            var maquinaDeCafe = new MaquinaDeCafe();
            maquinaDeCafe.setCafetera(cafetera);
            maquinaDeCafe.setVasosPequeno(vasoPequeno);
            maquinaDeCafe.setAzucarero(azucarero);

            Assert.AreEqual("No hay Cafe", maquinaDeCafe.getVasoDeCafe(vasoPequeno, 1, 10));
        }
           [TestMethod]
        public void TestNoAzucar()
        {
            var cafetera = new Cafetera(50);
            var vasoPequeno = new Vaso(5, 10);
            var azucarero = new Azucarero(5);
            var maquinaDeCafe = new MaquinaDeCafe();
            maquinaDeCafe.setCafetera(cafetera);
            maquinaDeCafe.setVasosPequeno(vasoPequeno);
            maquinaDeCafe.setAzucarero(azucarero);

            Assert.AreEqual("No hay Azucar", maquinaDeCafe.getVasoDeCafe(vasoPequeno, 1, 10));
        }
}