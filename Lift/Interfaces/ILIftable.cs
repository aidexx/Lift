using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift
{
    public interface ILIftable
    {
        protected IEnumerable<Request> RequestQueue { get; set; }
        public int CurrentFloor { get; set; }
        public LiftState State { get; set; }

        public void Call(Request request);
        public void Stop();
        public void Cancel();

    }

    public enum LiftState
    {
        Still, MovingUp, MovingDown, Stopped
    }
}
