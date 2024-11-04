using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nemt.models;

class Printer
{

    public static void PrintTeamsWithoutTasks()
    {

        using (nemtContext context = new())
        {
            var teamsWithNoTasks = context.Teams.Where(x => x.CurrentTask == null && x.tasks.Count() == 0);
            foreach (var team in teamsWithNoTasks) 
            {
                Console.WriteLine(team.Name + " Skam JER LAV NOGET !");
            }

        }
    }
    public static void PrintTeamCurrentTask() 
    {
        using (nemtContext context = new())
        {
            var teamsWithNoTasks = context.Teams.Where(x => x.CurrentTask != null && x.tasks.Count() > 0);
            foreach (var team in teamsWithNoTasks)
            {
                Console.WriteLine("Navn: " + team.Name + " Opgave: " + team.CurrentTask.Name);
            }

        }


    }
    public static void PrintTeamProgress()
    {
        using (nemtContext context = new())
        {
            var teamsWithNoTasks = context.Teams.Where(x => x.CurrentTask != null && x.tasks.Count() > 0);
            foreach (var team in teamsWithNoTasks)
            {
                var CurrentDonestate = Convert.ToDecimal(team.CurrentTask.Todos.Where(x => x.IsDone == true).Count() / team.CurrentTask.Todos.Count() );
                Console.WriteLine("Nuværende Progression: " + CurrentDonestate+ " På Team : " + team.Name);

            }

        }


    }

}
