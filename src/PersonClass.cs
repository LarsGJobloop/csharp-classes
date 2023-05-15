// A fair share of the time we want
// to create multiple instances of the 
// same class but with some variation
// here the constructor method 
// comes into play
class Person
{
  public string FirstName;
  public string LastName;

  // The constructor is simply a public method on the
  // class with the same name as the class.
  // It will be called whenever we are creating a new
  // instance of this class with the "new" keyword
  // All instances will have their own, seperate, members
  public Person(string firstName, string lastName)
  {
    FirstName = firstName;
    LastName = lastName;
  }

  public void SayName()
  {
    System.Console.WriteLine($"My name is {FirstName} {LastName}");
  }
  
}