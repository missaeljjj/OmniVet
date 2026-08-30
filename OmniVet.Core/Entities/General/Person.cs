using OmniVet.Core.Shared;

namespace OmniVet.Core;

public abstract class Person : IEntity<int>
{
  public int Id {get;}

  public string FirstName
  {

    get;
    private set => field = !string.IsNullOrWhiteSpace(value) switch
    {
      true => throw new Exception(""),
      _ => field = value.Trim()
    };
    
  }

  public string SecondName{get; set;}

  public string FirstLastName
  {

    get;
    private set => field = !string.IsNullOrWhiteSpace(value) switch
    {
      true => throw new Exception(""),
      _ => field = value.Trim()
    }; 

  }

  public string SecondLastName{get; set;}

  public string Address{get; set;}

  public Person(string firstname,string secondname, string firstlastname, string secondlastname,string address)
  {
    FirstName = firstname;
    SecondName = secondname;
    FirstLastName = firstlastname;
    SecondLastName = secondlastname;
    Address = address;
    
  }
  
}