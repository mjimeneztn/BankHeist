using System;
using System.Collections.Generic;

namespace bankHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            // ### Phase 1
            // The program should...

            // 1.Print the message "Plan Your Heist!".
            // 2.Create a way to store a single team member. A team member will have a _name_, a _skill Level_ and a _courage factor_.The _skill Level_ will be a positive integer and the _courage factor_ will be a decimal between 0.0 and 2.0.
            // 3.Prompt the user to enter a team member's name and save that name.
            // 4.Prompt the user to enter a team member's skill level and save that skill level with the name.
            // 5.Prompt the user to enter a team member's courage factor and save that courage factor with the name.
            // 6.Display the team member's information.
            //phase 2
            // 1.Create a way to store several team members.
            // 2.Collect several team members' information.
            // 3.Stop collecting team members when a blank name is entered.
            // 4.Display a message containing the number of members of the team.
            // 5.Display each team member's information.
            Console.WriteLine("Plan your Heist");

            List<Dictionary<string, string>> team = new List<Dictionary<string, string>>();
Console.Write("Bank Diffiuclty>");
int bankDifficulty = int.Parse(Console.ReadLine());
Console.WriteLine("");

            // Get the first team member's name
            Console.Write("Name> ");
            string name = Console.ReadLine();
            while (name != "")
            {
                Console.Write("Skill level> ");
                string skillLevel = Console.ReadLine();

                Console.Write("Courage factor> ");
                string courageFactor = Console.ReadLine();

                Dictionary<string, string> member = new Dictionary<string, string>() {
                    {"Name", name},
                    {"Skill", skillLevel},
                    {"Courage", courageFactor}
                    };
                Console.WriteLine("***Member added***");

                team.Add(member);
                Console.WriteLine();

                // Get the next team member's name
                Console.Write("Name> ");
                name = Console.ReadLine();
 }
 Console.WriteLine();
 Console.WriteLine("Number of Runs> ");
 int trialRunCount = int.Parse(Console.ReadLine());
 Console.WriteLine();

            Console.WriteLine($"Team Size: {team.Count}");

            int teamSkill = 0;
            foreach(Dictionary<string,string> member in team){
               string skillLevel = member["Skill"];
               teamSkill = teamSkill + int.Parse(skillLevel);
            }
         int successfulRuns = 0;
            for (int i = 0; i < trialRunCount; i++)
            {

            Random generator = new Random();
            int luckValue= generator.Next(-10,11);
           int trialRunBankDifficulty=  bankDifficulty += luckValue;


            Console.WriteLine($"Team Skill Lvel: {teamSkill}");
            Console.WriteLine($"Bank Difficulty: {bankDifficulty}");
            if (trialRunBankDifficulty > teamSkill){
                Console.WriteLine("Your hiest failed");

            } else {
                Console.WriteLine("You're in.");
                successfulRuns ++;
            }
            }
            // Console.WriteLine($"Team Members:");
            // foreach (Dictionary<string, string> member in team)
            // {
            //     Console.Write($"\nName: {member["Name"]} \nSkill: {member["Skill"]} \nCourage: {member["Courage"]}");
            // }
            Console.WriteLine();
            Console.WriteLine("Heist Results");
            Console.WriteLine("----------------");
            Console.WriteLine($"Successes: {successfulRuns}");
            Console.WriteLine($"Failures: {trialRunCount - successfulRuns}");
        }
    }
}

