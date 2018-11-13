using System;
using System.Linq;
using Walker.Model;

namespace Walker.DataAccess
{
    public sealed class TubeFinder
    {
        private readonly Tubes _tubes;

        public TubeFinder(Tubes tubeData)
        {
            _tubes = tubeData ?? throw new NullReferenceException(nameof(tubeData));
        }

        public Tube GetTubeByCoordinate(int x, int y) => _tubes.FirstOrDefault(t => t.Row == y && t.Column == x);
        
    }
}
