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
    }
}
