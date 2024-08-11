﻿namespace Demo;
public abstract class Car
{
  protected EngineControlModule EngineControlModule { get; init; }
  public BrakePedal BrakePedal { get; set; } = new BrakePedal();

  public bool IsRunning => EngineControlModule.IsRunning;

    public string Make { get; set; }
    public string Model { get; set; }


  public Throttle Throttle { get; set; } = new Throttle();

  public SteeringWheel SteeringWheel { get; set; } = new SteeringWheel();

    public void Start()
    {
        EngineControlModule.Start();
    }

    public void Stop()
    {
        EngineControlModule.Stop();
    }
}
