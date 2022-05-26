using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Bike
    {

        public static int bikeCount; //counts bikes to output total number
        private string _make;
        private string _type;
        private string _model;
        private int _year;
        private string _wheelSize;
        private string _forks;
        private int _securityCode;

        public string Make
        {
            get
            {
                return _make;
            }

            set
            {
                _make = value;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }

            set
            {
                _model = value;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }

            set
            {
                _year = value;
            }
        }

        public string WheelSize
        {
            get
            {
                return _wheelSize;
            }

            set
            {
                _wheelSize = value;
            }
        }

        public string Forks
        {
            get
            {
                return _forks;
            }

            set
            {
                _forks = value;
            }
        }

        public int SecurityCode
        {
            get
            {
                return _securityCode;
            }

            set
            {
                _securityCode = value;
            }
        }

        public Bike() {

            bikeCount++;
        }

        public Bike(string make, string type, string model, int year, string wheelSize, string forks, int securityCode)
        {
            bikeCount++;
            Make = make;
            Type = type;
            Model = model;
            Year = year;
            WheelSize = wheelSize;
            Forks = forks;
            SecurityCode = securityCode;
        }

    }
}