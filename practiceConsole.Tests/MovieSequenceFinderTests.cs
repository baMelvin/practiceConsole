using practiceConsole.InFlightMovie;
using Xunit;

public class MovieSequenceFinderTests
{
    [Theory]
    [InlineData(120, new[] { 10, 20, 30, 90, 160 }, true, new[] { 30, 90 })]
    [InlineData(100, new[] { 10, 20, 30, 40 }, true, new[] { 10, 20, 30, 40 })] 
    [InlineData(200, new[] { 10, 20, 30, 40 }, false, new int[0])]    
    public void FindMovieSequence_VariousCases(int flightLength, int[] movieLengths, bool expectedFound, int[] expectedSequence)
    {
        // Arrange
        IFlightLengthProvider flightLengthProvider = new MockFlightLengthProvider(flightLength);
        IMovieLengthProvider movieLengthProvider = new MockMovieLengthProvider(movieLengths);
        MovieSequenceFinder finder = new MovieSequenceFinder(movieLengthProvider, flightLengthProvider);

        // Act
        var result = finder.FindMovieSequence();

        // Assert
        Assert.Equal(expectedFound, result.found);
        Assert.Equal(expectedSequence, result.sequence);
    }
}