using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab4
{
    internal class Motorway
    {
        private string nameOfTheHighway;
        public string NameOfTheHighway {
            get { return nameOfTheHighway; } 
            set { nameOfTheHighway = value; }
        }

        private string typeOfStreet;
        public string TypeOfStreet {
            get { return typeOfStreet; }
            set { typeOfStreet = value; }
        }
        
        private string direction;
        public string Direction {
            get { return direction; }
            set { direction = value; }
        }
        
        private string surface;
        public string Surface {
            get { return surface; }
            set { surface = value; }
        }
        
        private int numberOfLanes;
        public int NumberOfLanes {
            get { return numberOfLanes; }
            set { numberOfLanes = value; }
        }
        
        private bool isToll;
        public bool IsToll {
            get { return isToll; }
            set { isToll = value; }
        }
        
        private string maintains;
        public string Maintains {
            get { return maintains; }
            set { maintains = value; }
        }

        public Motorway() { }

        public Motorway(string _name, bool _toll, string _maintains)
        {
            this.nameOfTheHighway = _name;
            this.isToll = _toll;
            this.maintains = _maintains;
        }
        public Motorway(string _name,string _type,string _dir, string _sur, int _lanes, bool _toll, string _maintains) { 
            this.nameOfTheHighway = _name;
            this.typeOfStreet = _type;
            this.direction = _dir;
            this.surface = _sur;
            this.numberOfLanes = _lanes;
            this.isToll = _toll;
            this.maintains = _maintains;
        }

        public override string ToString()
        {
            return "Name of Motoway: " + getFullNameOfMotorway()
                + "\nSurface: " + surface
                + "\nNumber of Lanes: " + numberOfLanes
                + "\nToll: " + isToll
                + "\nMaintained by: " + maintains;
        }
        public string getFullNameOfMotorway() {
            return nameOfTheHighway + " " + typeOfStreet + " " + direction;
        }
        public string getFullNameOfMotorwayAndToll()
        {
            return "Name of Motoway: " + getFullNameOfMotorway()
                + "\nisToll: " + isToll;
        }
        public string getFullNameOfMotorwayAndNumberOfLanes()
        {
            return "Name of Motoway: " + getFullNameOfMotorway()
                + "\nNumber of Lanes: " + numberOfLanes;
        }

    }
}
