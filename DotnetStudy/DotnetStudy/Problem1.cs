using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetStudy
{
    internal class Problem1
    {
        public string model;
        public string color;
        public int year;
        public Problem1(string modelName, string modelColor, int modelYear)
        {
            this.model = modelName;
            this.color = modelColor;
            this.year = modelYear;
        }

    }
}
