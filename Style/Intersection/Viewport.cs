using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop; // Made sure <-

namespace Style.Intersection
{
    public class Viewport : ComponentBase
    {
        [JSInvokable]
        public static void UpdateVmin(int value)
        {
            // Optional: Range check if you want to ensure the value is within the ushort range
            if (value >= 0 && value <= 65535)
            {
                Vmin = (ushort)value;
                Console.WriteLine($"Vmin set to: {Vmin}");
            }
            else
            {
                Console.WriteLine($"Received Vmin value out of range: {value}");
            }
        }

        public static ushort Vmin { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await JSRuntime.InvokeVoidAsync("ViewportAbstraction.updateVmin");
        }
    }
}