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

        public Estate(int index, string description, GPS upperBound, GPS lowerBound)
        {
            this.Index = index;
            this.Description = description;
            this.UpperBound = upperBound;
            this.LowerBound = lowerBound;
        }

        

        public int CompareTo(QTNode<Parcel> node_)
        {
            throw new NotImplementedException();
        }
    }
}
