using System.Collections.Generic;
using System.Linq;

namespace T9
{
    public class TextPredictor
    {
        private readonly IDictionary<int, string> _mappings = new Dictionary<int, string>
        {
            { 2, "abc" },
            { 3, "def" },
            { 4, "ghi" },
            { 5, "jkl" },
            { 6, "mno" },
            { 7, "pqrs" },
            { 8, "tuv" },
            { 9, "wxyz" }
        };

        // Given a string containing digits from 2-9 inclusive,
        // return all possible letter combinations that the number could represent.
        public IEnumerable<string> GetLetterCombinations(string digits)
        {
            var intDigits = digits
                .Select(d => int.Parse(d.ToString()))
                .ToList();

            return GetLetterCombinations(intDigits);
        }

        private IEnumerable<string> GetLetterCombinations(IList<int> digits)
        {
            return digits.Skip(1)
                .Aggregate(GetCombos(digits.First()), (accum, digit) =>
                    accum.SelectMany(partial => GetCombos(digit, partial)));
        }

        private IEnumerable<string> GetCombos(int digit, string str = "")
        {
            return _mappings[digit].Select(c => str + c);
        }
    }
}
