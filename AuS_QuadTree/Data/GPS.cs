using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuS_QuadTree.Data
{
    public class GPS
    {       //sirka - Y    dlzka - X
        char latitude, longitude;
        double x, y;

        #region properties
        public char Latitude { get => latitude; set => latitude = value; }
        public char Longitude { get => longitude; set => longitude = value; }
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        #endregion

        public GPS(char latitude, char longitude, double latitudeAccuracy, double longitudeAccuracy)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.X = latitudeAccuracy;
            this.Y = longitudeAccuracy;
        }
        
    }
}
