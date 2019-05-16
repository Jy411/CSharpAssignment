
// This is a subclass of the instrument superclass

using System;

namespace Asgn1_0328895_Jinyung
{
    public class Guitar : Instrument // as demonstrated here, guitar is a subclass of instrument
    {
        // Constructor used to instantiate object with the base class of Instrument
        public Guitar(string instrumentType, string instrumentName, string material, string manufacturer, int numOfStrings, string guitarType) : base(instrumentType, instrumentName, material, manufacturer)
        {
            this.NumOfStrings = numOfStrings;
            this.GuitarType = guitarType;
        }
        
        // Getters and Setters to retrieve the data members of the class
        private int NumOfStrings { get; set; }

        private string GuitarType { get; set; }

        public override void getInstrumentDetail() // shown here is a virtual method being overriden by the subclass Guitar
        {
            base.getInstrumentDetail();
            Console.WriteLine("Guitar Type: " + GuitarType);
            Console.WriteLine("Number of strings: " + NumOfStrings);
        }

        public override void PlayNote() // this is overriding the methods defined in the Instrument class
        {
            Console.WriteLine("*Guitar note played*");
        }

        public override void TuneInstrument() // this is overriding the methods defined in the Instrument class
        {
            Console.WriteLine("Guitar Successfully tuned!");
        }
    }
}