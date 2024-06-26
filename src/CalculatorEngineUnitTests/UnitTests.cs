using CalculatorEngine;

namespace CalculatorEngineUnitTests;


public class UnitTests
{

    private const float Epsilon = 0.00001f;

    //private CalculatorEngineImplementation CalcTest;
    [SetUp]
    public void Setup()
    {
        //CalcTest = new CalculatorEngineImplementation();
    }



    [Test]
    public void Add_NumberPlusZero_ReturnsNumber()
    {
        //arrange
        float TestFloat = 13.0f;

        //act
        float Actual = CalculatorEngineImplementation.Add(TestFloat, 0);

        //assert
        Assert.That(Actual, Is.EqualTo(TestFloat).Within(Epsilon));
    }

    [Test]
    public void Add_TwoFloats_ReturnsCorrectAnswer()
    {
        //arrange
        float TestFloatOne = 23.5f;
        float TestFloatTwo = 176.5f;

        //act
        float Actual = CalculatorEngineImplementation.Add(TestFloatOne, TestFloatTwo);

        //assert
        Assert.That(Actual, Is.EqualTo(200f).Within(Epsilon));
    }

    [Test]
    public void Subtract_ZeroFromNumber_ReturnsSameNumber()
    {
        //arrange
        float TestFloat = 24.0001f;

        //act
        float Actual = CalculatorEngineImplementation.Subtract(TestFloat, 0);

        //assert
        Assert.That(Actual, Is.EqualTo(TestFloat).Within(Epsilon));
    }

    [Test]
    public void Subtract_EpsilonFromNumber_ReturnsCorrectAnswer()
    {
        //arrange
        float TestFloat = 100000.00001f;

        //act
        float Actual = CalculatorEngineImplementation.Subtract(TestFloat, Epsilon);

        //assert
        Assert.That(Actual, Is.EqualTo(100000).Within(Epsilon));
    }

    [Test]
    public void Multiply_NumberByZero_ReturnsZero()
    {
        //arrange
        float TestFloat = 25f;

        //act
        float Actual = CalculatorEngineImplementation.Multiply(TestFloat, 0);

        //assert
        Assert.That(Actual, Is.EqualTo(0));
    }

    [Test]
    public void Multiply_TwoNegativeNumbers_ReturnsPositive()
    {
        //arrange
        float TestFloatOne = -25f;
        float TestFloatTwo = -5f;

        //act
        float Actual = CalculatorEngineImplementation.Multiply(TestFloatOne, TestFloatTwo);

        //assert
        Assert.That(Actual, Is.EqualTo(125f).Within(Epsilon));
    }

    [Test]
    public void Divide_NumberByZero_ThrowsException()
    {
        //arrange
        float TestFloat = 1f;

        //act
        //CalculatorEngineImplementation.Divide(TestFloat, 0);

        //assert
        Assert.Throws<DivideByZeroException>(() =>
            CalculatorEngineImplementation.Divide(TestFloat, 0));
    }

    [Test]
    public void Divide_TwoNumbers_ReturnsCorrrectAnswer()
    {
        //arrange
        float TestFloatOne = 25f;
        float TestFloatTwo = 10f;

        //act
        float Actual = CalculatorEngineImplementation.Divide(TestFloatOne, TestFloatTwo);

        //assert
        Assert.That(Actual, Is.EqualTo(2.5f).Within(Epsilon));
    }

    [Test]
    public void Factorial_NonIntegerValue_ReturnsNextIntegerFactorial()
    {
        //arrange
        float TestFloat = 5.4f;

        //act
        float Actual = CalculatorEngineImplementation.Factorial(TestFloat);

        //assert
        Assert.That(Actual, Is.EqualTo(120).Within(Epsilon));
    }

    [Test]
    public void Factorial_NegativeValue_ReturnsOne()
    {
        //arrange
        float Testfloat = -14f;

        //act
        float Actual = CalculatorEngineImplementation.Factorial(Testfloat);

        //assert
        Assert.That(Actual, Is.EqualTo(1).Within(Epsilon));
    }

    [Test]
    public void Factorial_Zero_ReturnsOne()
    {
        //arrange
        float TestFloat = 0f;

        //act
        float Actual = CalculatorEngineImplementation.Factorial(TestFloat);

        //assert
        Assert.That(Actual, Is.EqualTo(1).Within(Epsilon));
    }

    [Test]
    public void Exponent_ZeroPower_ReturnsOne()
    {
        //arrange
        float TestFloatA = 10f;
        float TestFloatB = 0f;

        //act
        float Actual = CalculatorEngineImplementation.Exponent(TestFloatA, TestFloatB);

        //assert
        Assert.That(Actual, Is.EqualTo(1).Within(Epsilon));
    }

    [Test]
    public void Exponent_NegativeNumberRaisedToOddPower_ReturnsNegativeValue()
    {
        //arrange
        float TestFloatA = -2f;
        float TestFloatB = 5f;

        //act
        float Actual = CalculatorEngineImplementation.Exponent(TestFloatA, TestFloatB);

        //assert
        Assert.That(Actual, Is.EqualTo(-32).Within(Epsilon));
    }

    [Test]
    public void Sin_UnitCircleValue_ReturnsCorrectly()
    {
        //Math.Sin uses Radians not degrees

        //arrange
        float TestFloat = (float)Math.PI / 2;

        //act
        float Actual = CalculatorEngineImplementation.Sin(TestFloat);

        //assert
        Assert.That(Actual, Is.EqualTo(1).Within(Epsilon));
    }

    [Test]
    public void Sin_NegativeAngle_ReturnsCorrectly()
    {
        //arrange
        float TestFloat = -(float)Math.PI / 6;

        //act
        float Actual = CalculatorEngineImplementation.Sin(TestFloat);

        //assert
        Assert.That(Actual, Is.EqualTo(-.5).Within(Epsilon));
    }

    [Test]
    public void Cos_UnitCircleValue_ReturnsCorrectly()
    {
        //Math.Cos uses Radians not degrees

        //arrange
        float TestFloat = (float)Math.PI;

        //act
        float Actual = CalculatorEngineImplementation.Cos(TestFloat);

        //assert
        Assert.That(Actual, Is.EqualTo(-1).Within(Epsilon));
    }

    [Test]
    public void Cos_NegativeAngle_ReturnsCorrectly()
    {
        //arrange
        float TestFloat = -(float)Math.PI / 3;

        //act
        float Actual = CalculatorEngineImplementation.Cos(TestFloat);

        //assert
        Assert.That(Actual, Is.EqualTo(.5).Within(Epsilon));
    }

    [Test]
    public void Tan_PiOverTwoAngle_ThrowsException()
    {
        //Tan is undefined at PI/2 because Cos = 0 and Division by zero is impossible
        //Tan uses Radians 

        //arrange
        float TestFloat = (float)Math.PI / 2;

        //assert
        Assert.Throws<DivideByZeroException>(() =>
            CalculatorEngineImplementation.Tan(TestFloat));
    }

    [Test]
    public void Tan_NormalValue_ReturnsCorrectly()
    {
        //arrange
        float TestFloat = (float)Math.PI / 4;

        //act
        float Actual = CalculatorEngineImplementation.Tan(TestFloat);

        //assert
        Assert.That(Actual, Is.EqualTo(1).Within(Epsilon));
    }

    [Test]
    public void Reciprocal_Zero_ThrowsException()
    {
        //Reciprocal of 0 should throw error because division by 0 is impossible
        //arrange
        float TestFloat = 0f;

        //assert
        Assert.Throws<DivideByZeroException>(() =>
            CalculatorEngineImplementation.Reciprocal(TestFloat));

    }

    [Test]
    public void Reciprocal_NormalValue_ThrowsException()
    {
        //arrange
        float TestFloat = 5f;

        //act
        float Actual = CalculatorEngineImplementation.Reciprocal(TestFloat);

        //assert
        Assert.That(Actual, Is.EqualTo(.2f).Within(Epsilon));
    }

    [Test]
    public void Root_NormalValue_ReturnsCorrectly()
    {
        //arrange
        float TestFloatA = 25f;
        float TestFloatB = 2f;

        //act
        float Actual = CalculatorEngineImplementation.Root(TestFloatA, TestFloatB);

        //assert
        Assert.That(Actual, Is.EqualTo(5).Within(Epsilon));
    }

    [Test]
    public void Root_ZeroPower_ThrowsException()
    {
        //arrange
        float TestFloatA = 64f;
        float TestFloatB = 0f;

        //assert
        Assert.Throws<DivideByZeroException>(() =>
            CalculatorEngineImplementation.Root(TestFloatA, TestFloatB));
    }

    [Test]
    public void Equals_DiffDecimalValues_ReturnsFalse()
    {
        //arrange
        float TestFloatA = 3.33333335f;
        float TestFloatB = 3.333333f;
        
        //act
        bool Actual = CalculatorEngineImplementation.Equals(TestFloatA, TestFloatB);
        
        //assert
        Assert.That(Actual, Is.EqualTo(false));
    }
    
    [Test]
    public void Equals_DecimalValues_ReturnsTrue()
    {
        //arrange
        float TestFloatA = 3.33333333f;
        float TestFloatB = 3.33333333f;
        
        //act
        bool Actual = CalculatorEngineImplementation.Equals(TestFloatA, TestFloatB);
        
        //assert
        Assert.That(Actual, Is.EqualTo(true));
    }

    [Test]
    public void Log_OfZero_ThrowsException()
    {
        //arrange
        float TestFloatA = 4f;
        float TestFloatB = 0f;
        
        //assert
        Assert.Throws<Exception>(() =>
            CalculatorEngineImplementation.Log(TestFloatA, TestFloatB));
    }
    
    [Test]
    public void Log_OfOne_ThrowsException()
    {
        //arrange
        float TestFloatA = 4f;
        float TestFloatB = 1f;
        
        //assert
        Assert.Throws<Exception>(() =>
            CalculatorEngineImplementation.Log(TestFloatA, TestFloatB));
    }

    [Test]
    public void Log_NormalValues_ReturnsCorrectly()
    {
        //arrange
        float TestFloatA = 8f;
        float TestFloatB = 2f;
        
        //act
        float Actual = CalculatorEngineImplementation.Log(TestFloatA, TestFloatB);
        
        //assert
        Assert.That(Actual, Is.EqualTo(3f));
    }
}