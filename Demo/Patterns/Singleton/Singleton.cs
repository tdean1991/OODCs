﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Patterns.Singleton;

class Singleton
{
    private static Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton()
    {
        Value = new Random().Next()
    });
    public static Singleton Instance => _instance.Value;
    public int Value { get; set; }

    private Singleton()
    {
    }
}
