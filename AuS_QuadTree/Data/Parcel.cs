using AuS_QuadTree.QuadTreeFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AuS_QuadTree.Data
{
    public class Parcel : IQTData<Parcel>, IEquatable<Parcel>
    {
        int index;
        string description;
        //  pravy dolny roh, lavy horny roh
        GPS upperBound, lowerBound;
        List<Estate> locatedIn;

        # region properties
        public int Index { get => index; set => index = value; }
        public string Description { get => description; set => description = value; }
        internal GPS UpperBound { get => upperBound; set => upperBound = value; }
        internal GPS LowerBound { get => lowerBound; set => lowerBound = value; }
        internal List<Estate> LocatedIn { get => locatedIn; set => locatedIn = value; }
        #endregion

        public Parcel(int index_, string description_, GPS upperBound_, GPS lowerBound_)
        {
            this.Index = index_;
            this.Description = description_;
            this.UpperBound = upperBound_;
            this.LowerBound = lowerBound_;

            if (LowerBound.X > UpperBound.X)
            {
                double hlp = UpperBound.X;
                UpperBound.X = LowerBound.X;
                LowerBound.X = hlp;
            }
            if (LowerBound.Y > UpperBound.Y)
            {
                double hlp = UpperBound.Y;
                UpperBound.Y = LowerBound.Y;
                LowerBound.Y = hlp;
            }
        }

        public int CompareTo(QTNode<Parcel> node_)
        {
            if (node_ == null) {
                return 0;
            }else if((LowerBound.X > node_.LowerBoundX && LowerBound.X < node_.UpperBoundX) &&
               (LowerBound.Y > node_.LowerBoundY && LowerBound.Y < node_.UpperBoundY) &&
               (UpperBound.X > node_.LowerBoundX && UpperBound.X < node_.UpperBoundX) &&
               (UpperBound.Y > node_.LowerBoundY && UpperBound.Y < node_.UpperBoundY))
            {
                return 1;
            } else
            {
                return -1;
            }
        }

        public int CompareIntersect(double _x1, double _y1, double _x2, double _y2)
        {
            if (((LowerBound.X <= _x1 && UpperBound.X >= _x1) || (LowerBound.X <= _x2 && UpperBound.X >= _x2) ||
               (LowerBound.X >= _x1 && LowerBound.X <= _x2) || (UpperBound.X >= _x1 && UpperBound.X <= _x2)) &&
               ((LowerBound.Y <= _y1 && UpperBound.Y >= _y1) || (LowerBound.Y <= _y2 && UpperBound.Y >= _y2) ||
               (LowerBound.Y >= _y1 && LowerBound.Y <= _y2) || (UpperBound.Y >= _y1 && UpperBound.Y <= _y1)))
            { 
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public bool Equals(Parcel? other)
        {
            if (other == null) 
            {
                return false;
            }
            else if(ReferenceEquals(this, other) || 
                   (other.index == index && other.Description.Equals(description) && 
                    other.LowerBound.X == lowerBound.X && other.LowerBound.Y == lowerBound.Y &&
                    other.UpperBound.X == upperBound.X && other.UpperBound.Y == upperBound.Y))
            {
                return true;
            }
            return false;        
        }
    }
}
