using Demo.Immutability;
using NUnit.Framework;

namespace Tests.ImmutablityTest;

[TestFixture]
public class AddressHelperTests
{
  [Test]
  public void FormatAddress_returns_properly_formatted_address()
  {
    var person = new Person("John", "Doe", new Address("123 Any St.", null, "Anytown", "OH", "43210", "USA"));
    var expected = 
@"JOHN DOE
123 ANY ST.
ANYTOWN, OH 43210
USA";
    Assert.That(AddressHelper.FormatAddress(person), Is.EqualTo(expected));
  }
}
