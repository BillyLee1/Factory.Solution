using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public string EngineerName { get; set; }
    public int EngineerId { get; set; }

    public List<EngineerMachine> JoinEntities { get;}
  }
}
