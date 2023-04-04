namespace SigmaSoftware.HW2;

public class WaterTower
{
    public int CurrentVolume { get; private set; }
    public int MaxVolume { get; }
    
    public WaterTower(int currentVolume = 500, int maxVolume = 1000)
    {
        CurrentVolume = Math.Max(0, currentVolume);
        MaxVolume = Math.Max(CurrentVolume, maxVolume);
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