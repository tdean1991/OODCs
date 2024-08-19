namespace Demo.CarWorld;

public sealed class HybridControlModule : EngineControlModule
{
    private int _engineStatus;
    private int _relayStatus;
    public override EngineType EngineType { get; } = EngineType.Hybrid;
    public CrankPositionSensor? CrankPositionSensor { get; set; }
    public ExhaustOxygenSensor? ExhaustOxygenSensor { get; set; }

    public override bool IsRunning => _engineStatus == 1 || _relayStatus == 1;
    public override void Start()
    {
        _engineStatus = 1;
        _relayStatus = 1;
    }

    public override void Stop()
    {
        _engineStatus = 0;
        _relayStatus = 0;
    }
}
