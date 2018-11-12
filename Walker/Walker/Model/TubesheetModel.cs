using System.Collections.Generic;

namespace Walker.Model
{
    public sealed class TubesheetModel
    {
        private readonly decimal _tubesheetDiameter;
        private readonly decimal _tubesheetPitch;
        private Tubes _tubes { get; set; }
        public TubesheetModel(decimal tubesheetDiameter, decimal tubesheetPitch, IEnumerable<Tube> tubes)
        {
            _tubesheetDiameter = tubesheetDiameter;
            _tubesheetPitch = tubesheetPitch;
            _tubes = new Tubes(tubes);
        }
        public decimal TubesheetDiameter
        {
            get { return _tubesheetDiameter; }
        }
        public decimal TubesheetPitch
        {
            get { return _tubesheetPitch; }
        }

        public Tubes Tubes
        {
            get { return _tubes; }
        }
    }
}
