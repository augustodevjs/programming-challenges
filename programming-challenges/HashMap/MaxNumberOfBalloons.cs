namespace programming_challenges.HashMap;

public class MaxNumberOfBalloons
{
    // https://leetcode.com/problems/maximum-number-of-balloons/description/
    public int MaxNumberOfBalloonsSoluton(string text) {
        var maxNumberBallonsDictionary = new Dictionary<char, int>() {
            { 'b', 0 },
            { 'a', 0 },
            { 'l', 0 },
            { 'o', 0 },
            { 'n', 0 }
        };

        foreach (var t in text) {
            if(maxNumberBallonsDictionary.ContainsKey(t)) {
                maxNumberBallonsDictionary[t] += 1;
            }
        }

        maxNumberBallonsDictionary['l'] = maxNumberBallonsDictionary['l'] / 2;
        maxNumberBallonsDictionary['o'] = maxNumberBallonsDictionary['o'] / 2;

        var maxBalloons = maxNumberBallonsDictionary['b'];

        maxBalloons = Math.Min(maxBalloons, maxNumberBallonsDictionary['a']);
        maxBalloons = Math.Min(maxBalloons, maxNumberBallonsDictionary['l']);
        maxBalloons = Math.Min(maxBalloons, maxNumberBallonsDictionary['o']);
        maxBalloons = Math.Min(maxBalloons, maxNumberBallonsDictionary['n']);

        return maxBalloons;
    }
}