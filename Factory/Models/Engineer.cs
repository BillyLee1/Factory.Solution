using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public string EngineerName { get; set; }
    public int EngineerId { get; set; }
    public int MachineId { get; set; }
    public Machine Machine { get; set; }
    public List<EngineerLicense> JoinEntities { get;}
  }
}
