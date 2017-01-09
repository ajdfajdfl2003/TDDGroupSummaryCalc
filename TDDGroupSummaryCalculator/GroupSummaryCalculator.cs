using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class  GroupSummaryCalculator<T>
    {
        private IEnumerable<T> _source;

        public GroupSummaryCalculator(IEnumerable<T> source) {
            this._source = source;
        }
        public IEnumerable<int> CheckSummary(int groupSize, Func<T,int> column) {
            if(groupSize < 0) {
                throw new ArgumentOutOfRangeException("GroupingSize should be greater than or equal to zero.");
            }
            for(int index = 0; index<_source.Count(); index+=groupSize) {
                yield return _source.Skip(index).Take(groupSize).Sum(column);
            }
        }
    }
}
