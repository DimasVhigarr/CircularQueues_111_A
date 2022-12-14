using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueues
{
    class Queues
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];
        public Queues()
        {
            /*initializing the values of the variables Rear and Front to -1 to indicate that the queue is initialli\y empty*/
            FRONT = -1;
            REAR = -1;
        }

    }
}
