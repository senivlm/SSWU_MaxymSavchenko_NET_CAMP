namespace SigmaSoftware.HW2;

public class Simulator
{
    private readonly WaterTower _tower;
    private readonly Pump _pump;
    private readonly IList<string> _logs;

    private static readonly Simulator _instance = new Simulator();

    public EventHandler<string> LogEvent;

    private Simulator()
    {
        _logs = new List<string>();
        _tower = new WaterTower();
        _pump = new Pump(_tower);
        _pump.PumpUpTower();
        
        LogEvent += Log;
    }

    public static Simulator GetInstance()
    {
        return _instance;
    }
    
    public void GetWater(int volume, User user)
    {
        if (volume <= 0)
        {
            Log(user, $"[{user}] Volume must be greater than 0.");
            return;
        }
        
        double gotWater = _tower.DecreaseWater(volume);
        Log(user, $"[{user}] Get {gotWater} water.");
        CheckWaterLevel();
    }
    public void AddWater(int volume, User user)
    {
        if (volume <= 0)
        {
            Log(user, $"[{user}] Volume must be greater than 0.");
            return;
        }
        
        double addedWater = _tower.IncreaseWater(volume);
        Log(user, $"[{user}] Add {addedWater} water.");
        CheckWaterLevel();
    }

    public void StopPump(User user)
    {
        if (_pump.State == false)
        {
            Console.WriteLine("Pump not working.");
            return;
        }
        Log(user, $"[{user}] Stop pump tower.");
        _pump.TurnOff();
    }
    
    public void CheckWaterLevel()
    {
        double currentWaterLevel = _tower.CurrentVolume;
        Console.WriteLine($"Water: {_tower}L");

        if (currentWaterLevel == 0)
        {
            _pump.TurnOn();
        }
    }

    public void PumpInfo(User user)
    {
        Console.WriteLine($"[{user}] {_pump}");
    }
    public void PrintLogs()
    {
        foreach (string log in _logs)
        {
            Console.WriteLine(log);
        }
    }
    
    private void Log(object? sender, string message)
    {
        Console.WriteLine(message);
        _logs.Add(message + $" {DateTime.UtcNow}");
    }
}