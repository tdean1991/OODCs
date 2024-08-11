using Demo;
using NUnit.Framework;

namespace Tests.CarTests;

[TestFixture]
public class Given_an_EC1
{
  protected Car SUT { get; set; }

  [SetUp]
  public void SetUp()
  {
    SUT = new EC1();
  }
}
