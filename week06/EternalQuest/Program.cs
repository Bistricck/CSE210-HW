using System;

class Program
{
    static void Main(string[] args)
    {
 GoalManager manager = new GoalManager();
        manager.LoadGoals();

        while (true)
        {
            Console.WriteLine("\n1. Display Score\n2. List Goals\n3. Create Goal\n4. Record Event\n5. Save & Exit");
            Console.Write("Select an option: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1) manager.DisplayPlayerInfo();
            else if (choice == 2) manager.ListGoalNames();
            else if (choice == 3) manager.CreateGoal();
            else if (choice == 4) manager.RecordEvent();
            else if (choice == 5) { manager.SaveGoals(); break; }
        }
    }
}