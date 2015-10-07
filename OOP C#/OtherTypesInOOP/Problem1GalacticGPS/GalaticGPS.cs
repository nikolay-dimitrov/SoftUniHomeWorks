using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1GalacticGPS
{
    class GalaticGPS
    {
        static void Main(string[] args)
        {
            Location home = new Location(18.037986, 28.870097,Planet.Earth);
            Location researhLab = new Location(78.037986, -28.870097, Planet.Venus);
            Location villa = new Location(-8.037986, -178.870097, Planet.Neptune);

            Console.WriteLine("{0}\n{1}\n{2}",home,villa,researhLab);
        }
    }
}
