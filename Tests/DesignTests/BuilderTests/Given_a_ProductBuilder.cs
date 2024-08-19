using Demo.Patterns.Builder;
using NUnit.Framework;

namespace Tests.DesignTests.BuilderTests;
[TestFixture]
public class Given_a_ProductBuilder
{
  private ProductBuilder _sut = new ProductBuilder();

  [Test]
  public void Then_Build_returns_null()
  {
    Assert.IsNull(_sut.Build());
  }
}
