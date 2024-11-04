using Microsoft.EntityFrameworkCore;
using nemt.models;
using System.Reflection.Emit;
using Task = nemt.models.Task;
namespace nemt;

internal class nemtContext : DbContext
{
    public DbSet<models.Task> Tasks { get; set; }
    public DbSet<Todo> Todos { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Group> groups { get; set; }
    public DbSet<GroupUser> GroupUsers { get; set; }
    public DbSet<TeamWorker> TeamWorkers { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Worker> Workers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=H52114\\MYLOCALSQLSERVER;Initial Catalog=Efcore;Trusted_Connection=False;User Id=sa;Password=IamBornTobeWild11+!;TrustServerCertificate=True");
    }
    public Task SeedTasks()
    {
        var thetask = new Task
        {
            TaskId = 100,
            Name = "MySuperAmazingTask"
        };
        return thetask;
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var seedTodos = modelBuilder.Entity<Todo>().HasData(new Todo
        {
            IsDone = true,
            Name = "Produce Software",
            TodoId = 2,
            TaskId = 100
        }, new Todo
        {
            IsDone = false,
            Name = "Brew coffee",
            TodoId = 1,
            TaskId = 100
        });

        var seedTasks = SeedTasks();

        modelBuilder.Entity<Task>().HasData(seedTasks);
        modelBuilder.Entity<Task>()
             .HasMany(task => task.Todos)
             .WithOne(todo => todo.task)
             .HasForeignKey(todo => todo.TaskId);
        var Seedworkers = SeedWorkers();
        modelBuilder.Entity<Worker>().HasData(Seedworkers);
        var Seedteams = SeedTeams();
        modelBuilder.Entity<Team>().HasData(Seedteams);
        modelBuilder.Entity<TeamWorker>().HasData(new List<TeamWorker>
        {
            new TeamWorker
            {
                WorkerId = 1,
                TeamId = 1,
            },
            new TeamWorker
            {
                WorkerId = 1,
                TeamId = 3,
            },
            new TeamWorker
            {
                WorkerId= 2,
                TeamId= 1,
            },
            new TeamWorker
            {
                WorkerId = 3,
                TeamId= 1,

            },
            new TeamWorker
            {
                WorkerId = 3,
                TeamId= 2
            },
            new TeamWorker
            {
                 WorkerId = 4,
                 TeamId= 2,
            },
            new TeamWorker
            {
                WorkerId = 5,
                TeamId= 2,
            },
            new TeamWorker
            {
                WorkerId = 6,
                TeamId= 3,
            },
            new TeamWorker
            {
                WorkerId = 7,
                TeamId= 3,
            }
        });

        modelBuilder.Entity<TeamWorker>().HasKey(t => new { t.TeamId, t.WorkerId });
    }

    public List<Worker> SeedWorkers()
    {
        return new List<Worker>
        {
            new Worker
            {
              WorkerId = 1,
             WorkerName = "Steen Secher"
            },
          new Worker
          {
              WorkerId = 2,
              WorkerName = "Ejvind Møller"
          },
          new Worker
          {
              WorkerId = 3,
              WorkerName = "Konrad Sommer"
          },
          new Worker
          {
              WorkerId = 4,
              WorkerName = "Sofus Lotus"
          },
          new Worker
          {
              WorkerId = 5,
              WorkerName = "Remo Lademann"
          },
          new Worker
          {
              WorkerId = 6,
              WorkerName = "Ella Fanth"

          },
          new Worker
          {
              WorkerId = 7,
              WorkerName = "Anne Dam"
          },

        };
    }
    public List<Team> SeedTeams()
    {
        return new List<Team>
        {
            new Team
            {
                 Name = "FrontEnd",
                 TeamId = 1,

            },
            new Team
            {
                Name = "BackEnd",
                TeamId = 2
            },
            new Team
            {
                Name = "Testers",
                TeamId = 3,

            }
        };


    }

}


