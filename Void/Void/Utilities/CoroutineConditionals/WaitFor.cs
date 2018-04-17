using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Void.Utilities;

namespace Void.Utilities.CoroutineConditionals
{
    public class WaitFor : CoroutineConditional
    {
        private float timeLeft;
        public WaitFor(float seconds)
        {
            timeLeft = seconds;
        }


        public override bool DoCheck()
        {
            timeLeft -= Time.DeltaTime;
            return timeLeft <= 0.0f;
        }

    }
}
