using System;

namespace Asgn1_0328895_Jinyung
{
    public class Drums : Instrument
    {
        public Drums(string instrumentType, string instrumentName, string material, string manufacturer, int configuration, string drumSticksType) : base(instrumentType, instrumentName, material, manufacturer)
        {
            this.Configuration = configuration;
            this.DrumSticksType = drumSticksType;
        }

        // Getters and Setters to retrieve the data members of the class
        private int Configuration { get; set; }

        private string DrumSticksType { get; set; }

        public override void getInstrumentDetail() // Method overriding 
        {
            base.getInstrumentDetail();
            Console.WriteLine("Drum Configuration: " + Configuration);
            Console.WriteLine("Drum Sticks Type: " + DrumSticksType);
        }

        public override void PlayNote() // Method overriding
        {
            Console.WriteLine("*Drum Sound*");
        }

        public override void TuneInstrument() // Method overriding
        {
            Console.WriteLine("Drums tuned(?)");
        }

        public void tuneInstrument(bool isTuneable) // Method overloading
        {
            Console.WriteLine(!isTuneable ? "Cannot tune drums(?)" : "Drums are tuned(?)");
        }
    }
}