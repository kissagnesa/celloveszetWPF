using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celloveszetWPF
{
    public class Shooter
    {
        public string name { get; private set; }
        public int shot1 { get; private set; }
        public int shot2 { get; private set; }
        public int shot3 { get; private set; }
        public int shot4 { get; private set; }

        public int highest()
        {
            int highestShot = 0;
            if (this.shot1 > highestShot) { highestShot = this.shot1; }
            if (this.shot2 > highestShot) { highestShot = this.shot2; }
            if (this.shot3 > highestShot) { highestShot = this.shot3; }
            if (this.shot4 > highestShot) { highestShot = this.shot4; }
            return highestShot;
        }

        public int average()
        {
            int averageShot;
            averageShot = (this.shot1 + this.shot2 + this.shot3 + this.shot4) / 4;
            return averageShot;
        }

        public Shooter(string line)
        {
            string[] data = line.Split(';');
            this.name = data[0];
            this.shot1 = int.Parse(data[1]);
            this.shot2 = int.Parse(data[2]);
            this.shot3 = int.Parse(data[3]);
            this.shot4 = int.Parse(data[4]);
        }

        public Shooter(string name, int shot1, int shot2, int shot3, int shot4)
        {
            this.name = name;
            this.shot1 = shot1;
            this.shot2 = shot2;
            this.shot3 = shot3;
            this.shot4 = shot4;
        }

        public override string ToString()
        {
            return $"{name};{shot1};{shot2};{shot3};{shot4}";
        }
    }
}
