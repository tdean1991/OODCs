using Demo;
using Demo.CarWorld;
using NUnit.Framework;

namespace Tests.CarTests.GasolineCarTests;

[TestFixture]
public class Given_a_gasoline_Car
{
    protected Car SUT { get; set; }

    [SetUp]
    public virtual void SetUp()
    {
    SUT = new Car(new ICEngineControlModule()); ;
    }
}
