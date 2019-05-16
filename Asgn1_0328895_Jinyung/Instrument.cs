
// This is the superclass

using System;

namespace Asgn1_0328895_Jinyung
{
    public class Instrument : IPlayInstrument // Implementing the interface on the Instrument class
    {
        // Constant variable 
        private const bool isInstrument = true; 
        
        // Constructor used to instantiate objects
        public Instrument(string instrumentType, string instrumentName, string material, string manufacturer)
        {
            this.InstrumentType = instrumentType;
            this.InstrumentName = instrumentName;
            this.Material = material;
            this.Manufacturer = manufacturer;
        }

        // Getters and Setters to retrieve the data members of the class
        private string InstrumentType { get; set; }

        private string InstrumentName { get; set; }

        private string Material { get; set; }

        private string Manufacturer { get; set; }

        // virtual method to be used in subclasses Guitar, BassGuitar, and Drums
        public virtual void getInstrumentDetail()
        {
            Console.WriteLine("Instrument Name: " + InstrumentName); // Variables are retrieved through get methods
            Console.WriteLine("Instrument Type: " + InstrumentType);
            Console.WriteLine("Instrument Material: " + Material);
            Console.WriteLine("Instrument Manufacturer: " + Manufacturer);
        }

        // the methods in the interface are implemented here in the superclass 
        public virtual void PlayNote()
        {
            Console.WriteLine("Instrument Note Played!");
        }

        public virtual void TuneInstrument()
        {
            Console.WriteLine("Instrument successfully tuned!");
        }
    }
}