using System;

namespace Asgn1_0328895_Jinyung
{
    public class BassGuitar : Guitar
    {
        // Constructor to instantiate object with base class of Guitar which is a subclass of Instrument
        public BassGuitar(string instrumentType, string instrumentName, string material, string manufacturer, int numOfStrings, string guitarType, string playTechnique, bool fret) : base(instrumentType, instrumentName, material, manufacturer, numOfStrings, guitarType)
        {
            this.PlayTechnique = playTechnique;
            this.Fret = fret;
        }

        // Getters and Setters to retrieve the data members of the class
        private string PlayTechnique { get; set; }

        private bool Fret { get; set; }

        public override void getInstrumentDetail() // Method overriding
        {
            var isThereFret = Fret ? "Yes" : "No";
            base.getInstrumentDetail();
            Console.WriteLine("Playing technique: " + PlayTechnique);
            Console.WriteLine("Is there fret? " + isThereFret);
        }

        public override void PlayNote() // Method overriding
        {
            Console.WriteLine("*Bass guitar note*");
        }

        public override void TuneInstrument() // Method overriding
        {
            Console.WriteLine("Bass Guitar Successfully tuned!");
        }
    }
}