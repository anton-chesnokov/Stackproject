using System;
using System.Collections.Generic;
    class QueueItem
    {
    public object Value { get; set; }
    public QueueItem Next { get; set;}
    }

    class Queue
{
    QueueItem head;
    QueueItem tail;

    public void Enqueue (object value)
    {
        var item=new QueueItem { Value=value };
        if (head==null)
        {
            head = tail = item;
        }
        else
        {
            tail.Next = item;
            tail = item;
        }
    }                                           
    public object Dequeue()
    {
        if (head==null)
        throw new InvalidOperationException();
        var result = head.Value;
        head = head.Next;
        if (head == null) tail = null;
        return result;
    }
}

class Program
{
    public static void Main()
    {
        var queue = new Queue();
        queue.Enqueue('A');
        queue.Enqueue('B');
        queue.Enqueue('C');
        for (int i=0;i < 3; i++) Console.WriteLine(queue.Dequeue());
    }
}