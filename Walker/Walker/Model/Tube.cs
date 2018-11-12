namespace Walker.Model
{
    public sealed class Tube
    {
        public Tube(int row, int col, string status)
        {
            Row = row;
            Column = col;
            Status = status;
            TubeColor = TubeColor.Resolve(this);
        }

        public int Row { get; private set; }
        public int Column { get; private set; }
        public string Status { get; private set; }

        public string Description => string.Format("Row: {0}, Column: {1}, Status: {2}, Color: {3}", Row, Column, Status, TubeColor.Name);
        
        public TubeColor TubeColor { get; private set; }
    }
}
