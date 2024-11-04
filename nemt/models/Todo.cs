    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nemt.models;

public class Todo
{
    public int TodoId { get; set; }
    public string Name { get; set; }
    public bool IsDone { get; set; }
    public Task task { get; set; }
    public int TaskId { get; set; }

}
