using System;


class MainClass {
  public static void Main (string[] args) {
    
    /*Console.WriteLine("Testing Address");
    Address addr1 = new Address();
    addr1.AddressLine1="1234 Main St";
    addr1.AddressLine2="Apt 102";
    addr1.City = "Cleveland";
    addr1.State = "azzffdsfd";
    addr1.Zipcode = "44143";

    addr1.Display();*/

    /*Console.WriteLine("Testing Person");
    Person p1 = new Person();
    p1.FirstName = "John";
    p1.LastName = "Smith";
    p1.PermanentAddress.AddressLine1 = "1234 Main St";
    p1.PermanentAddress.City = "Cleveland";
    p1.PermanentAddress.State = "OH";
    p1.PermanentAddress.Zipcode = "44143";
    p1.DateOfBirth = Convert.ToDateTime("07/13/1994");
    p1.Intro();
    p1.IsBirthday();  */  

    /*Console.WriteLine("Testing Student 1");
    Student s1 = new Student();
    s1.FirstName = "Kara";
    s1.LastName="Kaiser";
    s1.DateOfBirth = Convert.ToDateTime("01/01/2020");
    s1.PermanentAddress.AddressLine1 = "999 Mallard Dr";
    s1.PermanentAddress.City = "Parma";
    s1.PermanentAddress.State = "OH";
    s1.PermanentAddress.Zipcode = "44143";
    s1.GPA = 2.1;
    s1.School = "Cleveland State University";
    s1.Intro();
    s1.IsBirthday();
    s1.SetAcademicStanding();
    Console.WriteLine(s1.AcademicStanding);


    Console.WriteLine("Testing Student 2");
    Student s2 = new Student("Andrew", "Peggman");    
    s2.DateOfBirth = Convert.ToDateTime("01/01/1989");
    s2.PermanentAddress.AddressLine1 = "999 Mallard Dr";
    s2.PermanentAddress.City = "Parma";
    s2.PermanentAddress.State = "OH";
    s2.PermanentAddress.Zipcode = "44143";
    s2.GPA = 2.75;
    s2.School = "Ohio State University";
    s2.Intro();
    s2.IsBirthday();
    s2.SetAcademicStanding();
    Console.WriteLine(s2.AcademicStanding); */
    
    Console.WriteLine("Testing Faculty 1");
    Faculty f1 = new Faculty();
    f1.FirstName = "Kara";
    f1.LastName="Kaiser";
    f1.DateOfEmployment = Convert.ToDateTime("01/01/2000");
    f1.PermanentAddress.AddressLine1 = "999 Mallard Dr";
    f1.PermanentAddress.City = "Parma";
    f1.PermanentAddress.State = "OH";
    f1.PermanentAddress.Zipcode = "44143";
    f1.Id = "212134";
    f1.Employer = "Cleveland State University";
    f1.Title = "Assistant Professor";
    f1.Intro();
    f1.GrantTenure();
    f1.Promote();
    Console.WriteLine(f1.Title);

    Console.WriteLine("Testing Faculty 2");
    Faculty f2 = new Faculty("Josh", "Walters");
    f2.DateOfEmployment = Convert.ToDateTime("01/01/2017");
    f2.PermanentAddress.AddressLine1 = "7654 Runway Rd";
    f2.PermanentAddress.City = "Cleveland";
    f2.PermanentAddress.State = "OH";
    f2.PermanentAddress.Zipcode = "44129";
    f2.Id = "01567";
    f2.Employer = "Tri-C";
    f2.Intro();
    f2.GrantTenure();
    f2.Promote();
  }
}
