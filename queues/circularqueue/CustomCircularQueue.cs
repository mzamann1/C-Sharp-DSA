

using System.Text;

public class CustomCircularQueue<T>
{
    private int front, rear;
    private readonly int _capacity;

    private T[] arr;
    public CustomCircularQueue(int size)
    {
        if (size > 0)
        {
            front = rear = -1; //initializing the top pointer at -1 
            _capacity = size;
            arr = new T[size];
        }
        else
        {
            throw new Exception("Invalid size of stack");
        }

    }

    public bool IsEmpty()
    {
        return front == -1;
    }

    public bool IsFull()
    {
        if (front == 0 && rear == _capacity - 1) return true; //normal case
        if (front == rear + 1) return true; //circular case
        return false;
    }

    public int GetSize()
    {
        if (this.IsEmpty())
        {
            return 0;
        }
        else
        {
            if(front<=rear) return rear + 1 - front; //normal case
            else return rear+front+1; //circular case
        }
    }

    public void Enqueue(T element)
    {
        if (this.IsFull()) Console.WriteLine("Queue is Full.");
        else
        {
            if (front == -1)
                front = 0;

            rear = (rear + 1) % _capacity;
            arr[rear] = element;
            Console.WriteLine("Inserted ==> {0}", element);
        }
    }

    public T DeQueue()
    {
        if (this.IsEmpty())
        {
            Console.WriteLine("Queue is Empty.");
            return default(T);
        }

        else
        {
            var element = arr[front];
            if (front == rear)
            {
                front = rear = -1;
            }
            else
            {
                front = (front + 1) % _capacity;
            }

            Console.WriteLine("Deleted ==> {0}", element);
            return element;
        }
    }

    public void Show()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is Empty.");
            return;
        }

        Console.WriteLine("\n============= Printing Queue Started ==============\n");
        for (int i = front; i <= rear; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine("\n============= Printing Queue Ended ==============\n");
    }



}