using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public static class GroupSummaryCalculator
    {
        public static IEnumerable<int> CheckSummary<T>(this IEnumerable<T> _source, int groupSize, Func<T,int> column) {
            if(groupSize < 0) {
                throw new ArgumentOutOfRangeException("GroupingSize should be greater than or equal to zero.");
            }
            if (groupSize == 0) {
                yield return _source.Skip(_source.Count()).Sum(column);
                yield break;
            }
            for (int index = 0; index<_source.Count(); index+=groupSize) {
                yield return _source.Skip(index).Take(groupSize).Sum(column);
            }
        }
    }
}
