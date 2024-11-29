using Utils2;

[TestClass]
public class TestArea
{
    [TestMethod]
    // Valida el valor límit de AreaRec [>50] i AreaRec[>20] i el string de EvalueArea
    public void TestAreaRec()
    {
        // Arrange
        double height = 5;
        double width = 10;
        double expectedArea = 50;
        string expectedMessage = "L'àrea és entre 21 i 50";

        // Act
        double result = MyUtils.AreaRec(height, width);
        string resultMessage = MyUtils.EvalueArea((int)result);

        // Assert
        Assert.AreEqual(expectedArea, result);
        Assert.AreEqual(expectedMessage, resultMessage);
    }

    [TestMethod]
    // Valida el valor límit de AreaRec [>20] i Area[>50] i el string de EvalueArea
    public void TestAreaRec2()
    {
        // Arrange
        double height = 7;
        double width = 7;
        double expectedArea = 49;
        string expectedMessage = "L'àrea és entre 21 i 50";

        // Act
        double result = MyUtils.AreaRec(height, width);
        string resultMessage = MyUtils.EvalueArea((int)result);

        // Assert
        Assert.AreEqual(expectedArea, result);
        Assert.AreEqual(expectedMessage, resultMessage);
    }

    [TestMethod]
    // Valida el valor límit de AreaRec [>50] i el string de EvalueArea
    public void TestAreaRec3()
    {
        // Arrange
        double height = 3;
        double width = 17;
        double expectedArea = 51;
        string expectedMessage = "L'àrea és més gran de 50";

        // Act
        double result = MyUtils.AreaRec(height, width);
        string resultMessage = MyUtils.EvalueArea((int)result);

        // Assert
        Assert.AreEqual(expectedArea, result);
        Assert.AreEqual(expectedMessage, resultMessage);
    }

    [TestMethod]
    // Valida el valor límit de AreaRec [>20] i AreaRec [<= 20] i el string de EvalueArea
    public void TestAreaRec4()
    {
        // Arrange
        double height = 4;
        double width = 5;
        double expectedArea = 20;
        string expectedMessage = "L'àrea és menor o igual a 20";

        // Act
        double result = MyUtils.AreaRec(height, width);
        string resultMessage = MyUtils.EvalueArea((int)result);

        // Assert
        Assert.AreEqual(expectedArea, result);
        Assert.AreEqual(expectedMessage, resultMessage);
    }

    [TestMethod]
    // Valida el valor límit de AreaRec [>20] i AreaRec [<= 20] i el string de EvalueArea
    public void TestAreaRec5()
    {
        // Arrange
        double height = 7;
        double width = 3;
        double expectedArea = 21;
        string expectedMessage = "L'àrea és entre 21 i 50";

        // Act
        double result = MyUtils.AreaRec(height, width);
        string resultMessage = MyUtils.EvalueArea((int)result);

        // Assert
        Assert.AreEqual(expectedArea, result);
        Assert.AreEqual(expectedMessage, resultMessage);
    }

    [TestMethod]
    // Valida el valor límit de AreaRec [<= 20] i el string de EvalueArea
    public void TestAreaRec6()
    {
        // Arrange
        double height = 2.5;
        double width = 7.6;
        double expectedArea = 19;
        string expectedMessage = "L'àrea és menor o igual a 20";

        // Act
        double result = MyUtils.AreaRec(height, width);
        string resultMessage = MyUtils.EvalueArea((int)result);

        // Assert
        Assert.AreEqual(expectedArea, result);
        Assert.AreEqual(expectedMessage, resultMessage);
    }
}