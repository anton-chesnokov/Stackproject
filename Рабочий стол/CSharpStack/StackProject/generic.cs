using System;
using System.Collections.Generic;
public class QueueItem<T>
{
    public T Value { get; set; }
    public QueueItem<T> Next { get; set; }
}

public class Queue<T>
{
QueueItem<T> head;
QueueItem<T> tail;

public bool IsEmpty { get {return head == null;}}

public void Enqueue (T value)
    {
        if (IsEmpty)
        tail = head = new QueueItem<T> {Value = value, Next = null };
        else
        {
            var item = new QueueItem<T> { Value = value, Next = null };
            tail.Next = item;
            tail = item;
        }
    }