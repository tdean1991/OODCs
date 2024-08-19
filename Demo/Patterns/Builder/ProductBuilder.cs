using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Patterns.Builder;

public class ProductBuilder : Builder<Product>
{
  public static ProductBuilder ForProduct(string type) =>
    type switch
    {
      "A" => ForProductA(),
      "B" => ForProductB(),
      _ => throw new NotSupportedException()
    };
  

  public override Product? Build()
  {
    return Value;
  }

  public static ProductBuilder ForProductA()
  {
    return new ProductBuilder
    {
      Value = new Product("Product A")
      {
        LeftComponent = new Component1(),
        RightComponent = new Component2()
      }
    };
  }

  public static ProductBuilder ForProductB()
  {
    return new ProductBuilder
    {
      Value = new Product("Product B")
      {
        LeftComponent = new Component2(),
        RightComponent = new Component1()
      }
    };
  }


}
