using System;
using System.Collections.Generic;

abstract class Member
{
    public int MemberID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public abstract double CalculateMonthlyFee();
    public abstract void DisplayDetails();
}

class RegularMember : Member
{
    public double WorkoutPlanFee { get; set; }

    public override double CalculateMonthlyFee()
    {
        return 50 + WorkoutPlanFee;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"MemberID: {MemberID}, Name: {Name}, Age: {Age}, Monthly Fee: ${CalculateMonthlyFee()}");
    }
}

class PremiumMember : Member
{
    public double PersonalTrainerFee { get; set; }
    public double DietPlanFee { get; set; }

    public override double CalculateMonthlyFee()
    {
        return 100 + PersonalTrainerFee + DietPlanFee;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"MemberID: {MemberID}, Name: {Name}, Age: {Age}, Monthly Fee: ${CalculateMonthlyFee()}");
    }
}

interface IGymManagement
{
    void AddMember(Member member);
    void DisplayAllMembers();
}

class Gym : IGymManagement
{
    private List<Member> members = new List<Member>();

    public void AddMember(Member member)
    {
        members.Add(member);
    }

    public void DisplayAllMembers()
    {
        foreach (var member in members)
        {
            member.DisplayDetails();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Gym gym = new Gym();

        gym.AddMember(new RegularMember { MemberID = 1, Name = "John Doe", Age = 25, WorkoutPlanFee = 20 });
        gym.AddMember(new RegularMember { MemberID = 2, Name = "Jane Smith", Age = 30, WorkoutPlanFee = 15 });

        gym.AddMember(new PremiumMember { MemberID = 3, Name = "Mike Brown", Age = 35, PersonalTrainerFee = 50, DietPlanFee = 30 });
        gym.AddMember(new PremiumMember { MemberID = 4, Name = "Anna White", Age = 28, PersonalTrainerFee = 60, DietPlanFee = 25 });

        gym.DisplayAllMembers();
    }
}
