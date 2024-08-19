using Demo.Patterns.Builder;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.DesignTests;

[TestFixture]
public class Given_a_ProductBuilder_for_Product_A
{
  private ProductBuilder _sut = ProductBuilder.ForProduct("A");

  [Test]
  public void Then_Build_returns_ProductA()
  {
    Assert.That(_sut?.Build()?.Name, Is.EqualTo("Product A"));
  }
}