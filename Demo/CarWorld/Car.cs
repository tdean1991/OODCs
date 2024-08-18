namespace Demo.CarWorld;
public class Car : IStartable
{
    public Car(EngineControlModule engineControlModule)
    {
        EngineControlModule = engineControlModule;
    }
    public string Make { get; set; }
    public string Model { get; set; }
    protected EngineControlModule EngineControlModule { get; init; }
    public bool IsRunning => EngineControlModule.IsRunning;

    public BrakePedal BrakePedal { get; set; }

    public SteeringWheel SteeringWheel { get; set; } = new SteeringWheel();
    public Throttle Throttle { get; set; } = new Throttle();
    public void Start()
    {
        EngineControlModule.Start();
    }
    public void Stop()
    {
        EngineControlModule.Stop();
    }






}
