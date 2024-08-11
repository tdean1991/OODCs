namespace Demo;

public class ElectriControlModule : EngineControlModule
{
  internal override void Start()
  {
    Status = 1;
  }

  internal override void Stop()
  {
    Status = 0;  
  }
}
