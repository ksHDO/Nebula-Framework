using Void.Utilities.CoroutineConditionals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void.Utilities
{
    using IEnumerator = IEnumerator<CoroutineConditional>;

    public class Coroutine
    {
        //False of movenext means done;
        public bool IsComplete { get; protected set; } = false;

        IEnumerator coroutine;
        CoroutineConditional currentConditional;
        public Coroutine(IEnumerator<CoroutineConditional> coroutine)
        {
            this.coroutine = coroutine;
            currentConditional = coroutine.Current;
        }

        public void DoCycle()
        {
            if(currentConditional == null || currentConditional.DoCheck())
            {
                IsComplete = !coroutine.MoveNext();
                currentConditional = coroutine.Current;
            }
        }


    }
}
