using System;
using System.Collections.Generic;
using System.Linq;

namespace practiceConsole.InFlightMovie;

public interface IMovieLengthProvider
{
    int[] GetMovieLengths();
}

public interface IFlightLengthProvider
{
    int GetFlightLength();
}

public class MovieSequenceFinder
{
    private readonly IMovieLengthProvider _movieLengthProvider;
    private readonly IFlightLengthProvider _flightLengthProvider;
    public MovieSequenceFinder(IMovieLengthProvider movieLengthProvider, IFlightLengthProvider flightLengthProvider)
    {
        _movieLengthProvider = movieLengthProvider;
        _flightLengthProvider = flightLengthProvider;
    }

    public (bool found, int[] sequence) FindMovieSequence()
    {
        int[] movieLengths = _movieLengthProvider.GetMovieLengths();
        int flightLength = _flightLengthProvider.GetFlightLength();
        int iCount = movieLengths.Count();
        int start = 0;
        int sum = 0;
        (bool found, int[] sequence) sequenceReturn = (false, []);

        List<int> tempList = new List<int>();
        for(int end = 0; end < iCount; end++){
            // Start at index 0.
            // Sum values moving to the right until one of three conditions are met.
            // 1. The sum of movie values is equal to the flight length.
            // 2. The sum of movie values is greater than the flight length.
            // 3. The sum of movie values is less than the flight length, but we have run out of movies in the list.

            // There is this cool technique I copied. It makes the whole thing easier.
            // Add the current sum at the end pointer.
            sum += movieLengths[end];

            // If sum is too big, shrink from the left;
            while(sum > flightLength && start <= end){
                sum -= movieLengths[start];
                start++;

                if(sum == flightLength){
                    sequenceReturn.found = true;
                    sequenceReturn.sequence = [.. movieLengths
                        .Skip(start)
                        .Take(end - start + 1)];

                    break;
                }
            }

            if(sum == flightLength){
                sequenceReturn.found = true;
                sequenceReturn.sequence = [.. movieLengths
                    .Skip(start)
                    .Take(end - start + 1)];

                break;
            }

        }

        return sequenceReturn;
    }
}