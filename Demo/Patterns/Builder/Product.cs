using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Patterns.Builder;
public class Product
{
  public string Name { get; set; }
  public Component? LeftComponent { get; set; }
  public Component? RightComponent { get; set; }
  public Product(string name)
  {
    Name = name;
  }
}
