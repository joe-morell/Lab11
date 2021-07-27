using System;

class Faculty : Person {
  public string Id{get; set;}
  public string Title {get; set;}
  public string Employer {get; set;}
  public double YearlySalary {get; set;}
  public bool Tenured {get; set;}
  public DateTime DateOfEmployment {get; set;}

  public Faculty() : base() {
    Title = "Instructor";
    Console.WriteLine("Faculty constructor");
  }

  public Faculty(string fname, string lname) : base(fname, lname) {
    Title = "Instructor";
    Console.WriteLine("Faculty constructor");
  }

  public void Promote() {
    if (Title == "Instructor" && (DateTime.Today.Year - DateOfEmployment.Year) > 2)
    {
      Title = "Assistant Professor";
      Console.WriteLine("Faculty promoted to Assistant Professor rank");
    }
    else if (Title == "Assistant Professor" && (DateTime.Today.Year - DateOfEmployment.Year) > 5)
    {
      Title = "Associate Professor";
      Console.WriteLine("Faculty promoted to Associate Professor rank");
    }
    else if (Title == "Associate Professor" && (DateTime.Today.Year - DateOfEmployment.Year) > 10)
    {
      Title = "Professor";
      Console.WriteLine("Faculty promoted to Professor rank");
    }
    else if (Title == "Professor")
      Console.WriteLine("No more promotion possible");
  }

  public bool GrantTenure() {
    int yearsWorked = DateTime.Today.Year - DateOfEmployment.Year;

    if (yearsWorked >= 5)
    {
      Console.WriteLine("Tenure Granted!");
      return Tenured = true;
    }
    else
    {
      Console.WriteLine("Tenure Denied.");
      return Tenured = false;
    }
  }

  public override void Intro()
  {
    base.Intro();
    Console.WriteLine("I work as a " + Title + " at " + Employer + " since " + DateOfEmployment);
  }

}
