using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culbertson_SportingForm
{
    public class Child
    {
        private string name, address, city, state, sport;

        public Child() { }
        public Child(string name, string address, string city, string state, string sport)
        {
            this.name = name;
            this.address = address;
            this.city = city;
            this.state = state;
            this.sport = sport;
        }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Sport { get => sport; set => sport = value; }
    }
}
