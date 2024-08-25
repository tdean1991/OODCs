namespace Demo.Immutability;
public static class AddressHelper
{
  public static string FormatAddress(this Person person)
    =>
$"{person.FirstName} {person.LastName}\r\n{person.Address.Address1}\r\n{((person.Address.Address2 != null) ? person.Address.Address2 + "\r\n" : "")}{person.Address.City}, {person.Address.Region} {person.Address.PostalCode}\r\n{person.Address.Country}".ToUpperInvariant();

}