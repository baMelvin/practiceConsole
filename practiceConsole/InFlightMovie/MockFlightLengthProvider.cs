namespace practiceConsole.InFlightMovie;
public class MockFlightLengthProvider : IFlightLengthProvider
{
    private readonly int _flightLength;
    public MockFlightLengthProvider(int flightLength)
    {
        _flightLength = flightLength;
    }

    public  int GetFlightLength() => _flightLength;
}