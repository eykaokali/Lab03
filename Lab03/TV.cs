using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class TV
    {
            public string model;
            public string brand;
            public int screenSize;
            public string resolution;
            public bool isSmart;
            public string color;
            public float price;
            public float area
            {
                get
                {
                    double x = Math.Sqrt(screenSize * screenSize / 337);
                    return Convert.ToSingle(16 * 9 * x * x);
                }
            }

            public void ChangePrice(float newPrice)
            {
                if (newPrice >= 0)
                    price = newPrice;
            }
    }

}
