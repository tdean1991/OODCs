using Demo;
using NUnit.Framework;

namespace Tests.CarTests.ElectricCarTests;

[TestFixture]
public class Given_an_electric_Car
{
    protected Car SUT { get; set; }

    [SetUp]
    public void SetUp()
    {
        SUT = new Car(new ElectricControlModule()); ;
    }
}
