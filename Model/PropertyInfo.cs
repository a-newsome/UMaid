using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PropertyInfo
    {
        public double size { get; set; }
        public int numBeds { get; set; }
        public int numBaths { get; set; }
        public string desc { get; set; }
        public List<string> photos { get; set; }
        public List<double> priceLight { get; set; }
        public List<double> priceNormal { get; set; }
        public List<double> priceHeavy { get; set; }

        public PropertyInfo()
        {
            priceLight = new List<double>();
            priceNormal = new List<double>();
            priceHeavy = new List<double>();
        }

        public static double getAverage(List<double> priceList)
        {
            if (priceList.Count == 0)
            {
                return 0;
            }
            else
            {
                double avg = 0;
                foreach (int p in priceList)
                {
                    avg += p;
                }
                return avg / priceList.Count;
            }
        }

    }
}
