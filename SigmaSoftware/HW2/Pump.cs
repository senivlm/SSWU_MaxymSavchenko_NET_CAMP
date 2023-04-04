namespace SigmaSoftware.HW2;

public class Pump : object
{
    private WaterTower _tower;
    private bool _isWorking;
    public int Speed { get; }
    public bool State => _isWorking;
    public Pump(WaterTower tower, int speed = 100)
    {
        _tower = tower;
        Speed = Math.Max(speed, 10);
    }

    public async Task PumpUpTower()
    {
        await Task.Run(async () =>
        {
            while (true)
            {
                if(_isWorking)
                {
                    Simulator.GetInstance().LogEvent?.Invoke(this, "[*Pump] Start pump tower.");
                    while (_isWorking)
                    {
                        if (_tower.CurrentVolume == _tower.MaxVolume)
                        {
                            _isWorking = false;
                            break;
                        }

                        _tower.IncreaseWater(Speed);
                        await Task.Delay(TimeSpan.FromSeconds(1));
                    }

                    if (_tower.CurrentVolume == _tower.MaxVolume)
                    {
                        Simulator.GetInstance().LogEvent?.Invoke(this, "[*Pump] End pump tower.");
                    }
                }
            }
        });
    }

    public void TurnOn()
    {
        _isWorking = true;
    }
    public void TurnOff()
    {
        _isWorking = false;
    }

    public void Disconnect()
    {
        _tower = null;
    }

    public override string ToString()
    {
        return $"Working: {_isWorking}";
    }
}