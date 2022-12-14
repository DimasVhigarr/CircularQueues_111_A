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
        public void remove()
        {
            /*Checks whether the queue is empty. */
            if (FRONT == -1)
            {
                Console.WriteLine("Queue underflow \n");
                return;
            }
            Console.WriteLine("\nThe element deleted from the queue is:" + queue_array[FRONT] + "\n");
            /*checks if the queue has one element */
            if(FRONT == REAR)
            {
                FRONT = -1;
                REAR = -1;
            }
            else
            {
                /* If the element to be deleted is at the last position of the array, then the value of FRONT is set to 0 i.e to the first element of the array. */
                if (FRONT == max - 1)
                    FRONT = 0;
                else
                    /* FRONT is incremented by one if it is not the first elements of array. */
                    FRONT = FRONT + 1;
            }
        }
        public void display()
        {
            int FRONT_position = FRONT;
            int REAR_position = REAR;
            /* checks if the queue is empty */
            if (FRONT == -1)
            {
                Console.WriteLine("\nElements in the queue are...........\n");
                if (FRONT_position <= REAR_position)
                {
                    /* traverses the queue till the last element present in an array.*/
                    while (FRONT_position <= REAR_position)
                    {
                        Console.Write(queue_array[FRONT_position] + "  ");
                        FRONT_position++;
                    }
                    Console.WriteLine();
                }
                else
                {
                    /* traverses the queue till the last position of the array. */
                    while (FRONT_position <= max - 1)
                    {
                        Console.Write(queue_array[FRONT_position] + "  ");
                        FRONT_position++;
                    }
                    /* set the FRONT position to the first element of the array. */
                    FRONT_position = 0;
                    /* traverses the array till the last element present in the queue. */
                    while(FRONT_position <= REAR_position)
                    {
                        Console.Write(queue_array[FRONT_position] + "  ");
                        FRONT_position++;
                    }
                    Console.WriteLine();
                }
            }
            static void Main(string[] args)
            {
                Queues q = new Queues();
                char ch;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Menu");
                        Console.WriteLine("1. Implement Insert Operation");
                        Console.WriteLine("2. Implement Delete Operation");
                        Console.WriteLine("3. Display Values");
                        Console.WriteLine("4. Exit");
                        Console.Write("\n Enter your choice (1-4) : ");
                        ch = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine();
                        switch (ch)
                        {
                            case '1':
                                {
                                    Console.Write("Enter a number: ");
                                    int num = Convert.ToInt32(System.Console.ReadLine());
                                    Console.WriteLine();
                                    q.insert(num);
                                }
                                break;

                            case '2':
                                {
                                    q.remove();
                                }
                                break;

                            case '3':
                                {
                                    q.display();
                                }
                                break;

                            case '4':
                                return;

                            default:
                                {
                                    Console.WriteLine("Invalid option!!");
                                }
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Check for the values entered.");
                    }
                }
            }
        }
    }
}
