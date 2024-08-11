namespace Demo;
public class IceControlModule : EngineControlModule
{
  private AirTemperatureSensor _airTemperatureSensor = new AirTemperatureSensor();
  private CrankPositionSensor _crankPositionSensor = new CrankPositionSensor();

  internal override void Start()
  {
    Status = 1;
  }

  internal override void Stop()
  {
    Status = 0;
  }
}
