using Demo.Nullabiliy;
using NUnit.Framework;

namespace Tests.Nullability;

[TestFixture]
public class NullableReferenceTypeTests
{
  [Test]
  public void Setting_EmailAddress_to_null()
  {
    var person = new Person("", "John", "Doe");

  }
}
