using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.CarWorld;

public class RemoteStarter
{
    private readonly IStartable _device;

    public RemoteStarter(IStartable device)
    {
        _device = device;
    }

    public void Start()
    {
        Console.WriteLine("Remote starting...");
        _device.Start();
    }

    public void Stop()
    {
        Console.WriteLine("Remote stopping...");
        _device.Stop();
    }
}


