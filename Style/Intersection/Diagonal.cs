namespace Style.Intersection
{
    public class Diagonal
    {
        public ushort Intersection { get; set; }
        public Diagonal(ushort intersection)
        {
            Intersection = intersection;
        }

        public void UpdateDiagonalValue(ushort intersection)
        {
            Intersection = intersection;
        }
    }
}
