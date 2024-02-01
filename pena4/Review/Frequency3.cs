using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    public class Frequency3
    {
        //object -
        public object Elements(string s)
        {
            List<char> charList = s.ToList();


            // GroupBy  is used for organizing and categorizing data into groups.
            // Each group is represented by an IGrouping<TKey, TElement> object.
            //Here we are using groupby to know how many times a char is occured.
            var charGroups = charList.GroupBy(c => c);
            //foreach (var group in charGroups)
            //{
            //    Console.WriteLine($"Character: {group.Key}, Count: {group.Count()}");
            //}


            //sorting the list in desending order  by using FirstOrDefault which help to return first element of list.
            var mostFrequentGroup = charGroups.OrderByDescending(g => g.Count()).FirstOrDefault();

            //by using Key it will returns the character from list, if we don't use Key then it returns only count of element
            //Console.WriteLine(mostFrequentGroup.Key);
            return new { Key = mostFrequentGroup.Key, Count = mostFrequentGroup.Count() };

        }
    }
}
