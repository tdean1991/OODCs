namespace Demo;

public class S1 : Car
{
  public S1()
  {
    Make = "Globomantics";
    Model = "EC1";
    EngineControlModule = new IceControlModule();
  }
}
