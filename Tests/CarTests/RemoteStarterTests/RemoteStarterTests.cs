using Demo;
using NUnit.Framework;
namespace Tests.CarTests.RemoteStarterTests;

[TestFixture]
public class RemoteStarterTests
{
    [Test]
    public void TestCarStarter()
    {
        var sut = new Car(new ElectricControlModule());
        var starter = new RemoteStarter(sut);
        starter.Start();
        Assert.IsTrue(sut.IsRunning);
        starter.Stop();
        Assert.IsFalse(sut.IsRunning);
    }
}
