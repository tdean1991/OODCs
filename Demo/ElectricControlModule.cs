namespace Demo;
public sealed class ElectricControlModule : EngineControlModule
{
  private int _relayStatus;
  public override EngineType EngineType => EngineType.Electric;
  
  public override bool IsRunning => _relayStatus == 1;

  public override void Start()
  {
    _relayStatus = 1;
  }

  public override void Stop()
  {
    _relayStatus = 0;
  }
}
