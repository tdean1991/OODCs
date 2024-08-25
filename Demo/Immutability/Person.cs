namespace Demo.Immutability;
public record Person
{
  public int Id { get; init; }
  public string FirstName { get; init; }
  public string LastName { get; init; }
  public Address Address { get; init; }

  public Person(string firstName, string lastName, Address address)
  {
    FirstName = firstName;
    LastName = lastName;
    Address = address;
  }

  
}
