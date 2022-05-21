using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event.Event
{
    public class CustomLIst<T> : List<T>
    {
        public delegate void ItemAddedEventHandler(object sender,EventArgs e);

        public event ItemAddedEventHandler ItemAdded;

      public new void Add(T item)
        {
            base.Add(item);
            if(ItemAdded != null)
                ItemAdded(this,EventArgs.Empty);
        }
    }
}
