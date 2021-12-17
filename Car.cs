using System;

namespace Training_with_classes {
    class Car {
        private string manufacturer;
        private string model;
        private int modelYear; 
        private int weight;

        public void setManufacturer(string ma) { manufacturer = ma; }
        public string setManufacturer() { return manufacturer; }
        public void setModle(string mo) { model = mo; }
        public string setModle() {return model;}
        public void setModleYear(int m) { modelYear = m;}
        public int setModleYear() { return modelYear; }
        public void setWeight(int w) { weight = w;}
        public int setWeight() { return weight; }

        public static void TK() {

        }
    }
}