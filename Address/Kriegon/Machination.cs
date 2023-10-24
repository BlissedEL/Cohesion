namespace Address.Kriegon
{
    public class Machination
    {
        // Define read-only property
        private bool Address { get; }

        // Constructor that initializes and sets the value of 'Address'
        public Machination(ushort position, ushort appointment)
        {
            Address = position == 0 && appointment == 1;
        }

        // Public method to get the value of 'Address'
        public bool Appoint()
        {
            return Address;
        }
    }
}