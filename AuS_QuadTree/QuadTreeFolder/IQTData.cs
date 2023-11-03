using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuS_QuadTree.QuadTreeFolder
{
    public interface IQTData<TKey>
    {
        int CompareTo(QTNode<TKey> node_);
        int CompareIntersect(double _x1, double _y1, double _x2, double _y2);
    }
}
