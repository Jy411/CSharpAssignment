using System;

namespace Asgn1_0328895_Jinyung
{
    class Program
    {
        static void Main(string[] args)
        {
            // Superclass
            // instrument object is an Instantiation of Instrument Class
            Instrument instrument =
                new Instrument("Brass", "Trombone", "Metallic", "Queen of England");
            
            instrument.PlayNote(); // Virtual Method
            instrument.TuneInstrument(); // Virtual Method
            instrument.getInstrumentDetail(); // Virtual Method
            
            Console.WriteLine("=================================");

            // Subclass of Instrument [Inheritance]
            // guitar object is an Instantiation of Guitar Class
            Guitar guitar =
                new Guitar("String", "Stratomaster", "Wooden",
                    "Yamaha", 5, "Electric");
            
            guitar.PlayNote(); // Override Method [Polymorphism]
            guitar.TuneInstrument(); // Override Method [Polymorphism]
            guitar.getInstrumentDetail(); // Override Method [Polymorphism]
            
            Console.WriteLine("=================================");

            // Subclass of Guitar [Inheritance]
            // bassGuitar object is an Instantiation of BassGuitar Class
            BassGuitar bassGuitar = 
                new BassGuitar("String", "HeadBanger", "Plastic-ish",
                    "TheMadHats", 4, "Electric", "Strumming", false);
            
            bassGuitar.PlayNote(); // Override Method [Polymorphism]
            bassGuitar.TuneInstrument(); // Override Method [Polymorphism]
            bassGuitar.getInstrumentDetail(); // Override Method [Polymorphism]
            
            Console.WriteLine("=================================");

            // Subclass of Instrument [Inheritance]
            // drums object is an Instantiation of Drums Class
            Drums drums =
                new Drums("Percussion", "Indonesian Classical Drum", "Leather and other stuff",
                    "Native Tribes", 5, "Hands");
            
            drums.PlayNote(); // Override Method [Polymorphism]
            drums.TuneInstrument(); // Override Method [Polymorphism]
            drums.tuneInstrument(false); // Overload Method [Polymorphism]
            drums.getInstrumentDetail(); // Override Method [Polymorphism]
        }
    }
}
