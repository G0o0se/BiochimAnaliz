using System;

namespace BiochimAnaliz
{
    public class BiochemicalAnalysisOfUrine
    {
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public bool Pregnancy { get; set; }
        public double PH { get; set; }
        public double Glucose { get; set; }
        public double Albumen { get; set; }
        public double Ketones { get; set; }
        public double Nitrite { get; set; }
        public double Urobilinogen { get; set; }
        public double Creatinine { get; set; }
        public double ElectrolytesSodium { get; set; }
        public double ElectrolytesPotassium { get; set; }
        public double ElectrolytesChlorides { get; set; }
    };
}
