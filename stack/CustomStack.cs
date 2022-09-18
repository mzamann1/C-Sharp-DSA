

using System.Text;

public class CustomStack<T>
{
    private int top;
    private readonly int _capacity;

    private T[] arr;
    public CustomStack(int size)
    {
        if (size > 0)
        {
            top = -1; //initializing the top pointer at -1 
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
        return top == -1;
    }

    public bool IsFull()
    {
        return top == _capacity - 1;
    }

    public int GetSize()
    {
        return top + 1;
    }

    public void Push(T element)
    {
        if (this.IsFull()) Console.WriteLine("Stack is Full.");
        else arr[++top] = element;
    }

    public T Pop()
    {
        if (this.IsEmpty())
        {
            Console.WriteLine("Stack is Empty.");
            return default(T);
        }

        else return arr[top--];
    }

    public void Show()
    {
        Console.WriteLine("\n============= Printing Stack Started ==============\n");
        for (int i = 0; i <= top; i++)
        {
            Console.Write(arr[i]+" ");
        }
        Console.WriteLine("\n============= Printing Stack Ended ==============\n");
    }



}