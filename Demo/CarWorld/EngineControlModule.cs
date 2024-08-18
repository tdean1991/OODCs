namespace Demo.CarWorld
{
    public abstract class EngineControlModule
    {
        public AirTemperatureSensor AirTemperatureSensor { get; set; }
        public abstract EngineType EngineType { get; }

        public abstract bool IsRunning { get; }
        public ThrottlePositionSensor ThrottlePositionSensor { get; set; }

        public abstract void Start();

        public abstract void Stop();
    }
}