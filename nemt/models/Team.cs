using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nemt.models;

public class Team
{
    public int TeamId { get; set; }

    public string Name { get; set; }
    public List<TeamWorker> Workers { get; set; }

    public int CurrentTaskId { get; set; }
    public Task? CurrentTask { get; set; }

    public List<Task>? tasks { get; set; }
}

