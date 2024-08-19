namespace Demo.Nullabiliy;
public class Person
{
  public Person(string emailAddress, string firstName, string lastName)
  {
    EmailAddress = emailAddress;
    FirstName = firstName;
    LastName = lastName;
  }
  private string _emailAddress = null!;

  /// <summary>Gets or sets the <see cref="Person"/>'s email address
  /// </summary>
  /// <exception cref="ArgumentNullException">Thrown if the property is set to null</exception>
  public string EmailAddress
  {
    get => _emailAddress; 
    set
    {
      ArgumentNullException.ThrowIfNull(value, nameof(value));
      _emailAddress = value;
    }
  }
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public string MiddleName { get; set; } = string.Empty;
  public float Height { get; set; }
  public CreditCard? CreditCard { get; set; } = null;
}

public class CreditCard
{
  public string CardNumber { get; set; }
  public CreditCard(string cardNumber)
  {
    CardNumber = cardNumber;
  }
}
