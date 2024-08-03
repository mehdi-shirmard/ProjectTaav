using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNet.Infora;

public abstract class Game
{
    protected abstract string Name { get; set; }

    public void Start()
    {
        Console.WriteLine($"Game {Name} started");
        Play();
    }

    protected abstract void Play();
}
