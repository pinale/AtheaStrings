using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AntheaChallenges
{
    public class AntheaStrings
    {

        public int Add(string numbers)
        {
            List<int> numberlist = new List<int>();
            string pattern = @"-?\d+";  //captures all distinct "groups" of numeric digit (lenght 1 to n)
            
            foreach (Match m in Regex.Matches(numbers, pattern))
                numberlist.Add(int.Parse(m.Value));
            
            int[] negatives = numberlist.Where(x => x < 0).ToArray();
            if  (negatives.Length > 0)
                throw new Exception("negatives not allowed: " + string.Join(",",negatives));

            //remove all number bigger than 1000
            numberlist.RemoveAll(x => x > 1000);

            return numberlist.Sum();
        }
    }
}
