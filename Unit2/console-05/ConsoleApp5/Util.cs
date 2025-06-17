using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5;

public class Util
{
    public string GetWorld()
    {
        return "World";
    }

    /// <summary>
    /// Generates a greeting message.
    /// </summary>
    /// <param name="nameDemo">The name for the greeting.</param>
    /// <param name="flag">A flag indicating additional options.</param>
    /// <returns>A greeting message.</returns>
    public string GetGreeting(string nameDemo, 
                              bool flag)
    {
        return $"Hello, {nameDemo}!";
    }
}

