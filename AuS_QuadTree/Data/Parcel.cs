using AuS_QuadTree.QuadTreeFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuS_QuadTree.Data
{
    internal class Parcel : IComparable<Parcel>, IQTData<Parcel>
    {
        public int CompareTo(QTNode<Parcel> node_)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Parcel? other)
        {
            throw new NotImplementedException();
        }
    }
}
