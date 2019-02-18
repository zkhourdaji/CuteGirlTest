using System;
using System.Collections.Generic;
using System.Linq;

namespace CuteNamespace
{
    public class Girl
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public double Waist { get; set; }
        public double Hips { get; set; }
        public List<string> Languages { get; set; }
        public int IQ { get; set; }

        public Girl()
        {
            Languages = new List<string>();
        }

        private string GetLanguagesString()
        {
            if (Languages.Count == 0)
            {
                return "None";
            }
            string languages = "";
            foreach (string lang in Languages)
            {
                languages += lang + " ";
            }
            return languages;
        }


        public override string ToString()
        {
            string myGirl = "Weight: " + Weight;
            myGirl += "\nHeight: " + Height;
            myGirl += "\nWaiste: " + Waist;
            myGirl += "\nHips: " + Hips;
            myGirl += "\nLanguages: " + GetLanguagesString();
            myGirl += "\nIQ: " + IQ;

            return myGirl;
        }
    }
}
