using Demo;
using NUnit.Framework;

namespace Tests.CarTests.GasolineCarTests;

[TestFixture]
public class When_the_Car_is_Started : Given_a_gasoline_Car
{
    private bool _result;

    [SetUp]
    public void SetUp()
    {
        base.SetUp();
        var startable = (IStartable)SUT;
        startable.Start();
        _result = SUT.IsRunning;
    }

    [Test]
    public void Then_the_return_value_is_true()
    {
        Assert.IsTrue(_result);
    }
}
