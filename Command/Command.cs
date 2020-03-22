using System;
using System.Collections.Generic;

public interface ICommand
{
    void Execute();
    bool CanExecute();
}

public interface IUnit
{
    int Minerals { get; set; }
    Point Position { get; set; }

    void Move(int x, int y);
    void Gather();
}

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

public class Probe : IUnit
{
    public Queue<ICommand> Commands { get; set; }

    public int Minerals { get; set; }

    public Point Position { get; set; }

    public Probe()
    {
      Commands = new Queue<ICommand>();
      Position = new Point();
    }

    public void Move(int x, int y)
    {
        Commands.Enqueue(new MoveCommand(this, x, y));
    }

    public void Gather()
    {
        Commands.Enqueue(new GatherCommand(this));
    }
}

public class MoveCommand : ICommand
{
    private IUnit unit;
    private int x;
    private int y;

    public MoveCommand(IUnit unit, int x, int y)
    {
        this.unit = unit;
        this.x = x;
        this.y = y;
    }

    public bool CanExecute() { return true;}

    public void Execute() {
      unit.Position.X = x;
      unit.Position.Y = y;
    }
}

public class GatherCommand : ICommand
{
    private IUnit unit;

    public GatherCommand(IUnit unit)
    {
        this.unit = unit;
    }

    public bool CanExecute() {
      return unit.Minerals == 0;
    }

    public void Execute() {
      if(CanExecute()){
      unit.Minerals += 5;
      }
    }
}