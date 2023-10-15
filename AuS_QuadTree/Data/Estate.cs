using AuS_QuadTree.QuadTreeFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuS_QuadTree.Data
{
    internal class Estate : IQTData<Parcel>
    {
        int index;
        string description;
        GPS upperBound, lowerBound;
        List<Parcel> locatedOn;

        #region properties
        public int Index { get => index; set => index = value; }
        public string Description { get => description; set => description = value; }
        internal GPS UpperBound { get => upperBound; set => upperBound = value; }
        internal GPS LowerBound { get => lowerBound; set => lowerBound = value; }
        internal List<Parcel> LocatedOn { get => locatedOn; set => locatedOn = value; }
        #endregion 

        public Estate(int index_, string description_, GPS upperBound_, GPS lowerBound_)
        {
            this.Index = index_;
            this.Description = description_;
            this.UpperBound = upperBound_;
            this.LowerBound = lowerBound_;

            if (LowerBound.LatitudeAccuracy > UpperBound.LatitudeAccuracy)
            {
                double hlp = UpperBound.LatitudeAccuracy;
                UpperBound.LatitudeAccuracy = LowerBound.LatitudeAccuracy;
                LowerBound.LatitudeAccuracy = hlp;
            }
            if (LowerBound.LongitudeAccuracy > UpperBound.LongitudeAccuracy)
            {
                double hlp = UpperBound.LongitudeAccuracy;
                UpperBound.LongitudeAccuracy = LowerBound.LongitudeAccuracy;
                LowerBound.LongitudeAccuracy = hlp;
            }
        }

        

        public int CompareTo(QTNode<Parcel> node_)
        {
            if (node_ == null)
            {
                return 0;
            }
            else if ((LowerBound.LatitudeAccuracy > node_.LowerBoundX && LowerBound.LatitudeAccuracy < node_.UpperBoundX) &&
               (LowerBound.LongitudeAccuracy > node_.LowerBoundY && LowerBound.LongitudeAccuracy < node_.UpperBoundY) &&
               (UpperBound.LatitudeAccuracy > node_.LowerBoundX && UpperBound.LatitudeAccuracy < node_.UpperBoundX) &&
               (UpperBound.LongitudeAccuracy > node_.LowerBoundY && UpperBound.LongitudeAccuracy < node_.UpperBoundY))
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
