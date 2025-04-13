using System;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using practiceConsole;
using System.Net.Http;
using System.Text.Json;
using practiceConsole.InFlightMovie;


namespace practiceConsole;

class Program
{
    static void Main(string[] args){
        Console.WriteLine("The app ran.");
        IFlightLengthProvider flightLengthProvider = new MockFlightLengthProvider(120);
        IMovieLengthProvider movieLengthProvider = new MockMovieLengthProvider([10, 20, 30, 90, 160]);
        MovieSequenceFinder movieSequenceFinder = new MovieSequenceFinder(movieLengthProvider, flightLengthProvider);
        var sequenceReturn = movieSequenceFinder.FindMovieSequence();

        Console.WriteLine(
            $"Sequence found: {sequenceReturn.found}, " + 
            $"Sequence: {string.Join(", ", sequenceReturn.sequence)}"
        );

    }
}