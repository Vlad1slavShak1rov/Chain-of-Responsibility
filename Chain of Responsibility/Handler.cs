using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public abstract class Handler
    {
        public Handler Next { get; set; }
        
        public void SetNext(Handler handler)
        {
            Next = handler; 
        }

        public abstract void HandleRequest(Request request);
    }
}
