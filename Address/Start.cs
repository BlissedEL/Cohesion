using Address.Ayatem;
using Address.Kriegon;

namespace Address
{
    class Start : IMachine
    {
        public bool Address { get; set; }
        public Start()
        {
            Interaction interaction = new();
            Machination address = new(interaction.Position, interaction.Appointment);
            Address = Appoint(address);
        }
        public bool Appoint(Machination address)
        {
            return address.Appoint();
        }
    }
}