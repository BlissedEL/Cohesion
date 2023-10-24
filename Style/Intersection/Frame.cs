namespace Style.Intersection
{
    /// <summary>
    /// Represents the Frame structure for the Style.Intersection namespace.
    /// This struct is intentionally immutable to serve as a reliable data contract for flow.
    /// </summary>
    public readonly struct Frame
    {
        /// <summary>
        /// Gets the weight for the North direction.
        /// </summary>
        public ushort North { get; }

        /// <summary>
        /// Gets the weight for the South direction.
        /// </summary>
        public ushort South { get; }

        /// <summary>
        /// Gets the weight for the East direction.
        /// </summary>
        public ushort East { get; }

        /// <summary>
        /// Gets the weight for the West direction.
        /// </summary>
        public ushort West { get; }

        /// <summary>
        /// Initializes a new instance of the Frame struct with specified weights for each cardinal direction.
        /// </summary>
        /// <param name="weightedNorth">The weight for the North direction.</param>
        /// <param name="weightedSouth">The weight for the South direction.</param>
        /// <param name="weightedEast">The weight for the East direction.</param>
        /// <param name="weightedWest">The weight for the West direction.</param>
        public Frame(ushort weightedNorth, ushort weightedSouth, ushort weightedEast, ushort weightedWest)
        {
            North = weightedNorth;
            South = weightedSouth;
            East = weightedEast;
            West = weightedWest;
        }
    }
}