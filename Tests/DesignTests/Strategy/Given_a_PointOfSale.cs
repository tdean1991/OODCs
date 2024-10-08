﻿using Demo.Patterns.Strategy;
using NUnit.Framework;

namespace Tests.DesignTests.Strategy;

[TestFixture]
public class Given_a_PointOfSale
{
  [Test]
  public void Then_the_best_discount_if_chosen_for_the_order()
  {
    var order = new Order
    {
      Items =
      {
        new OrderItem { Quantity = 2, Price = 10.0m },
        new OrderItem { Quantity = 1, Price = 5.0m },
        new OrderItem { Quantity = 3, Price = 2.50m }
      }
    };
    var sut = new PointOfSale
    {
      Discounts =
      {
        new HighestPriceItemDiscount { Percentage = 0.5m },
        new WholeOrderDiscount { Percentage = 0.15m }
      }
    };

    Assert.That(sut.GetBestDiscount(order), Is.EqualTo(5m));
  }
}

