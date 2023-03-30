namespace SigmaSoftware.HW2;

public class WaterTower
{
    public int CurrentVolume { get; private set; }
    public int MaxVolume { get; }
    
    public WaterTower()
    {
        CurrentVolume = 500;
        MaxVolume = 1000;
    }

    public int DecreaseWater(int volume)
    {
        if (volume > CurrentVolume)
        {
            volume = CurrentVolume;
        }

        CurrentVolume -= volume;

        return volume;
    }
    public int IncreaseWater(int volume)
    {
        if (CurrentVolume + volume > MaxVolume)
        {
            volume = MaxVolume - CurrentVolume;
        }

        CurrentVolume += volume;

        return volume;
    }

    public override string ToString()
    {
        return $"{CurrentVolume}/{MaxVolume}";
    }
}