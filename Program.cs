using System;
using System.Collections.Generic;

namespace assignment1
{
  class Program
  {
    static void Main (string[] args)
    {
      Console.WriteLine("Goodmorning");
      List<Member> lsMember = SeedingData();
      MaleMember(lsMember);
      OldestMember(lsMember);
    }
    static void MaleMember(List<Member> members){
      foreach( var member in members)
      {
        if (member.Gender == true)
        {
          Console.WriteLine(member.LastName + " " + member.FirstName + "is male");
        }
      }
    }
    static void OldestMember(List<Member> members){
      maxAge = 0;
      foreach( var member in members)
      {
        if(member.Age > maxAge)
        {
          maxAge = member.Age;
        }
        if(member.Age = maxAge)
        {
          Console.WriteLine(member.LastName + " " + member.FirstName + " is " + member.Age + " Years old");
        }
      }
    }
    static void FullName(List<Member> members){
      foreach( var member in members)
      {
     Console.WriteLine(members.LastName + " " + member.FirstName);
      }
    }
    static List<Member> SeedingData(){
      List<Member> members = new List<Member>();
      Member.Add( new Member{
        FirstName = "Hoc",
        LastName = "Nguyen",
        Gender = true,
        DateOfBirth = 1999,05,01,
        PhoneNumber = "0862916198",
        BirthPlace = "Thai Nguyen",
        Age = 22,
        IsGraduated = true
      });
      Member.Add( new Member{
        FirstName = "Ngan",
        LastName = "Nguyen",
        Gender = false,
        DateOfBirth = 2001,05,08,
        PhoneNumber = "08621574512",
        BirthPlace = "Ha Noi",
        Age = 20,
        IsGraduated = true
      });
      Member.Add( new Member{
        FirstName = "Thien",
        LastName = "Ha",
        Gender = true,
        DateOfBirth = 2000,04,04,
        PhoneNumber = "086157841",
        BirthPlace = "Thanh Hoa",
        Age = 22,
        IsGraduated = false
      });
      
      return members;
    }
  }
}