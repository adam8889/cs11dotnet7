using Packt.Shared;

public class DvdPlayer : IPlayable
{
    public void Pause()
    {
        WriteLine("Dvd player is paused.");
    }

    public void Play()
    {
        WriteLine("Dvd player is playing.");
    }
}
