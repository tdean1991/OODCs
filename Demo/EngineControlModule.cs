namespace Demo;
public abstract class EngineControlModule
{
  private ThrottlePositionSensor _throttlePositionSensor = new ThrottlePositionSensor();
  protected int Status;

  internal abstract void Start();

  internal abstract void Stop();
  public bool IsRunning => Status == 1;
}
