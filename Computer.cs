namespace ComputerClub;

public class Computer
{
    private Client _client;
    private int _minutesRemaining;
    public int PricePerHour { get; private set; }

    public bool _isTaken
    {
        get
        {
            return _minutesRemaining > 0;
        }
    }

    public Computer(int pricePerHour)
    {
        PricePerHour = pricePerHour;
    }

    public void BecomeTaken(Client client)
    {
        _client = client;
        _minutesRemaining = client.DesiredMinutes;
    }

    public void BecomeEmpty()
    {
        _client = null;
    }

    public void SpendTime()
    {
        _minutesRemaining--;
    }

    public void ShowState()
    {
        if (_isTaken)
        {
            Console.WriteLine($"The computer is taken, minutes remaining : {_minutesRemaining}");
        }
        else
        {
            Console.WriteLine($"The computer is free, price per hour : {PricePerHour}");
        }
    }
}