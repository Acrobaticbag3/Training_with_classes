using System.Collections.Generic;
using System;

namespace Training_with_classes {
    class Program {
        static void Main(string[] args) {
            Car c = new Car();
            c.setManufacturer("SomeRandomCarManu");
            c.setModle("RandomModle");
            c.setModleYear("RandomModleYear");
            c.setWeight("RandomWeight");
            
            List<Car> carSpecs = new List<Car>();

            carSpecs.Add(c);
        }
    }

    class Car {
        private string manufacturer;
        private string model;
        private string modelYear; 
        private string weight;

        public void setManufacturer(string ma) { manufacturer = ma; }
        public string setManufacturer() { return manufacturer; }
        public void setModle(string mo) { model = mo; }
        public string getModle() {return model;}
        public void setModleYear(string m) { modelYear = m;}
        public string setModleYear() { return modelYear; }
        public void setWeight(string w) { weight = w;}
        public string setWeight() { return weight; }
    }
}
