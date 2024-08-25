namespace Demo.Immutability;
public record Address
{

  public string Address1 { get; init; }
  public string? Address2 { get; init; } = null;
  public string City { get; init; }
  public string Region { get; init; }
  public string PostalCode { get; init; }
  public string Country { get; init; }

  public Address(string address1, string city, string region, string postalCode, string country)
  {
    Address1 = address1;
    City = city;
    Region = region;
    PostalCode = postalCode;
    Country = country;
  }
  

}
