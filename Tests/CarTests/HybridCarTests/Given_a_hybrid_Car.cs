using Demo;
using NUnit.Framework;

namespace Tests.CarTests.HybridCarTests;

[TestFixture]
public class Given_a_hybrid_Car
{
    protected Car SUT { get; set; }

    [SetUp]
    public void SetUp()
    {
    SUT = new Car(new HybridControlModule()); ;
    }
}
