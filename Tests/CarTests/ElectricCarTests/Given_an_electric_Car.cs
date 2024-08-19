using Demo;
using Demo.CarWorld;
using NUnit.Framework;

namespace Tests.CarTests.ElectricCarTests;

[TestFixture]
public class Given_an_electric_Car
{
    protected Car SUT { get; set; }

    [SetUp]
    public virtual void SetUp()
    {
        SUT = new Car(new ElectricControlModule()); ;
    }
}
