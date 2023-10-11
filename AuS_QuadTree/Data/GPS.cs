using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuS_QuadTree.Data
{
    internal class GPS
    {       //sirka    dlzka
        char latitude, longitude;
        double latitudeAccuracy, longitudeAccuracy;

        #region properties
        public char Latitude { get => latitude; set => latitude = value; }
        public char Longitude { get => longitude; set => longitude = value; }
        public double LatitudeAccuracy { get => latitudeAccuracy; set => latitudeAccuracy = value; }
        public double LongitudeAccuracy { get => longitudeAccuracy; set => longitudeAccuracy = value; }
        #endregion

        public GPS(char latitude, char longitude, double latitudeAccuracy, double longitudeAccuracy)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.LatitudeAccuracy = latitudeAccuracy;
            this.LongitudeAccuracy = longitudeAccuracy;
        }
        
    }
}
