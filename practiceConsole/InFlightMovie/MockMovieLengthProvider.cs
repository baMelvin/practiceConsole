namespace practiceConsole.InFlightMovie;

public class MockMovieLengthProvider : IMovieLengthProvider
{
    private readonly int[] _movieLengths;
    public MockMovieLengthProvider(int[] movieLengths)
    {
        _movieLengths = movieLengths;
    }
    public int[] GetMovieLengths() => _movieLengths;
}