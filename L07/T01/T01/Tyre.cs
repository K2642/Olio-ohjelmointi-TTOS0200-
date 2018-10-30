using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01
{
    public class Tyre
    {

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Width { get; set; }
        public int Profile { get; set; }
        public int Radial { get; set; }

        public Tyre(string brand, string model, int width, int profile, int radial)
        {
            Brand = brand;
            Model = model;
            Width = width;
            Profile = profile;
            Radial = radial;
        }

        public override string ToString()
        {
            return "\n- Brand: " + Brand + ", Model: " + Model + ", Size: " + Width + "/" + Profile + "R" + Radial;
        }
    }
}