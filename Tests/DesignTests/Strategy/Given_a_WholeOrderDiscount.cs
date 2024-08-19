using Demo.Patterns.Strategy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.DesignTests.Strategy;
public class Given_a_WholeOrderDiscount
{
  [Test]
  public void Then_the_discount_is_based_on()
  {
    var order = new Order
    {
      Items =
      {
        new OrderItem {Quantity = 2, Price = 10.0m},
        new OrderItem {Quantity = 1, Price = 5.0m},
        new OrderItem {Quantity = 3, Price = 4m}
      }
    };
    var sut = new WholeOrderDiscount
    {
      Percentage = 0.50m
    };
    Assert.That(sut.GetDiscount(order), Is.EqualTo(18.5m));
  }
}
