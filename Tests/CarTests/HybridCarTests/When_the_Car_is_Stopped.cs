using Demo.CarWorld;
using NUnit.Framework;

namespace Tests.CarTests.HybridCarTests;

[TestFixture]
public class When_the_Car_is_Stopped : Given_a_hybrid_Car
{
    private bool _result;

    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        var startable = (IStartable)SUT;
        startable.Stop();
        _result = SUT.IsRunning;
    }

    [Test]
    public void Then_the_return_value_is_false()
    {
        Assert.IsFalse(_result);
    }
}
