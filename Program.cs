// This class is a little bit special
// Visual Studio and VS Code is essentially looking
// for a single class which implements a 
// "static public void Main()" method
// Which it will then start executing
// This is what we call the "entrypoint" of
// an application
class Program
{
  // The static keyword is related to classes
  // and how memebers and methods are created and
  // stored under the hood
  // In this case it is simply there to allow 
  // calling the method without actually having to
  // create an instance of this class
  static public void Main()
  {
    System.Console.WriteLine("Starting Program");

    // Classes are blueprints and we need to create an instance
    // if we want to use or access members on them
    // We do this by calling them with the new keyword
    // and storing the result
    ExampleClass example = new ExampleClass();

    // Public members can be accessed directly
    System.Console.WriteLine(example.publicFacing);

    // If you try to uncomment this line here you will see
    // that you get an inaccessible error
    // System.Console.WriteLine(example.secret);

    System.Console.WriteLine(example.getSecrets());
    example.printSecrets();

    // Classes grouped by a namespace
    // Notice how we access these
    ExampleGrouping.ClassA classA = new ExampleGrouping.ClassA();
    classA.Print();

    ExampleGrouping.ClassB classB = new ExampleGrouping.ClassB();
    classB.Print();


    // Using the class constructor for variation

    Person John = new Person("Jhon", "Doe");
    Person Vincent = new Person("Vincent", "van Gogh");
    Person Ada = new Person("Ada", "Lovelace");

    John.SayName();
    Vincent.SayName();
    Ada.SayName();
  }
}

// A class consists of a number of
// members (these are variables or data)
// and a set of
// methods (these are functions that does some
// operations on the data)
// the methods might also do some operation on
// data you pass to them
class ExampleClass
{
  // Members can either be
  // private (not accessible outside this class)
  // or
  // public (accessible from the outside)
  private string secret = "This is a secret know only to this class";
  public string publicFacing = "Every one can access this variable here";
  
  // Functions defined on a class are called methods of that class
  // they can also be both private or public
  private string getSecret()
  {
    return "I am a secret";
  }

  // Public function have access to any privately
  // defined members
  public string getSecrets()
  {
    return secret;
  }
  
  // They can also access any private metohds as well
  public void printSecrets()
  {
    System.Console.WriteLine(secret);
    System.Console.WriteLine(getSecret());
  }
}

// Namespaces are a way to group similar or related classes
namespace ExampleGrouping
{
  class ClassA
  {
    public void Print()
    {
      System.Console.WriteLine("Whoo I am inside a namespace");
    } 
  }

  class ClassB
  {
    public void Print()
    {
      System.Console.WriteLine("Hey! I am inside the same namespace");
    } 
  }
}