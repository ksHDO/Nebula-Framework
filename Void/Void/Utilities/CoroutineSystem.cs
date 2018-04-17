using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Void.Utilities;
using Void.Utilities.CoroutineConditionals;
using Void;
namespace Void.Utilities
{
    public class CoroutineSystem 
    {
        public static LinkedList<Coroutine> _coroutines = new LinkedList<Coroutine>();

        public static Coroutine BeginCoroutine(IEnumerator<CoroutineConditional> enumerator)
        {
            Coroutine res = new Coroutine(enumerator);
            _coroutines.AddLast(res);
            return res;
        }
        
        public static void Update()
        {
            var curCoroutineNode = _coroutines.First;
            while (curCoroutineNode != null)
            {
                Coroutine curCoroutine = curCoroutineNode.Value;
                curCoroutine.DoCycle();
                var nextNode = curCoroutineNode.Next;
                if (curCoroutine.IsComplete) {
                    curCoroutineNode.Value = null;
                    _coroutines.Remove(curCoroutineNode);
                }
                curCoroutineNode = nextNode;
            }
        }


    }
}
