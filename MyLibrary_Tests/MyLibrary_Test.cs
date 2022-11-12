using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLibrary_Tests
{
    [TestClass]
    public class MyLibrary_Test
    {
        [TestMethod]
        public void AreaFigure_10_314returned()
        {
            double Argument1 = 10;
            double Expected = 314;

            MyLibrary.Figure TestFigure = new MyLibrary.Figure();
            double Actual = TestFigure.AreaFigure(Argument1);

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void AreaFigure_3and4and5_6returned()
        {
            double Argument1 = 3;
            double Argument2 = 4;
            double Argument3 = 5;
            double Expected = 6;

            MyLibrary.Figure TestFigure = new MyLibrary.Figure();
            double Actual = TestFigure.AreaFigure(Argument1, Argument2, Argument3);

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void AreaTriangle_3and4and5_6returned()
        {
            double Argument1 = 3;
            double Argument2 = 4;
            double Argument3 = 5;
            double Expected = 6;

            MyLibrary.Figure TestFigure = new MyLibrary.Figure();
            double Actual = TestFigure.AreaFigure(Argument1, Argument2, Argument3);

            Assert.AreEqual(Expected, Actual);
        }
    }
}
