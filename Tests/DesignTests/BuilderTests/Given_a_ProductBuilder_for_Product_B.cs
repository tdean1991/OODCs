using Demo.Patterns.Builder;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.DesignTests;

[TestFixture]
public class Given_a_ProductBuilder_for_Product_B
{
  private ProductBuilder _sut = ProductBuilder.ForProduct("B");

  [Test]
  public void Then_Build_returns_ProductB()
  {
    Assert.That(_sut?.Build()?.Name, Is.EqualTo("Product B"));
  }
}