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
         public void insert(int element)
        {
            /*this statement checks for the overflow condition*/
            if((FRONT == 0 && REAR == max -1) || (FRONT == REAR + 1))
            {
                Console.WriteLine("\nQueue overflow\n");
                return;
            }
            /* the following statement check whether the queue is empty. if the queue is empty , then the value of the Rear and Front Variables is set to 0. */
            if(FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else
            {
                /* if Rear is at the las position of the array then the valie of REar is set to 0
                 * that corresponds to the first position of the array*/
                if (REAR == max - 1)
                    REAR = 0;
                else
                    /*if Rear is not at the last position, then its value is incremented by one*/
                    REAR = REAR + 1;
            }
            /* once the position of Rear is determined, the element is added at its proper place */
            queue_array[REAR] = element;
         }

    }
}
