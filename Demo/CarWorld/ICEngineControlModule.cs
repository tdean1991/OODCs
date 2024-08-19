namespace Demo.CarWorld;
public sealed class ICEngineControlModule : EngineControlModule
{
    private int _engineStatus;
    public override EngineType EngineType { get; } = EngineType.Gasoline;
    public CrankPositionSensor? CrankPositionSensor { get; set; }
    public ExhaustOxygenSensor? ExhaustOxygenSensor { get; set; }

    public override bool IsRunning => _engineStatus == 1;
    public override void Start()
    {
        _engineStatus = 1;
    }

    public override void Stop()
    {
        _engineStatus = 0;
    }
}
