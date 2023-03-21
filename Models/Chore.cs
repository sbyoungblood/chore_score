using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chore_score.Models
{
  public class Chore
  {
    public Chore(Guid id, string name, bool done)
    {
      id = Guid.NewGuid();
      Name = name;
      Done = done;
    }

    public Guid id { get; private set; }

    public string Name { get; set; }

    public bool Done { get; set; }
  }
}