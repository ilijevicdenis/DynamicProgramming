using System;
using System.Collections;
using System.Collections.Generic;

namespace Walker.Model
{
    public sealed class Tubes : IEnumerable<Tube>
    {
        private List<Tube> _tubes;

        public Tubes(IEnumerable<Tube> tubes)
        {
            _tubes = new List<Tube>(tubes) ?? throw new ArgumentNullException(nameof(tubes));
        }
        public IEnumerator<Tube> GetEnumerator()
        {
            return _tubes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
    }
}
