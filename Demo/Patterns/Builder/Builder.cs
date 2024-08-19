using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Patterns.Builder;

public abstract class Builder<T>
{
  protected T? Value { get; set; }

  public virtual T? Build() => Value;
}
