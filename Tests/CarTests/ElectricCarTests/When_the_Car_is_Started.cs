using Demo.CarWorld;
using NUnit.Framework;

namespace Tests.CarTests.ElectricCarTests;

[TestFixture]
public class When_the_Car_is_Started : Given_an_electric_Car
{
    private bool _result;

    [SetUp]
    public override void SetUp()
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
