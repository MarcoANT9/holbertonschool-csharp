using System;

///<summary>This is the Queue Class.</summary>
public class Queue<T>
{
    //=======================================================================
    //= Variables ===========================================================
    //=======================================================================

    // - Public -------------------------------------------------------------

    ///<summary>Head of the Queue.</summary>
    public Node head = null;
    ///<summary>Tail of the Queue.</summary>
    public Node tail = null;
    ///<summary>Counter of the nodes in Queue.</summary>
    public int count;

    // - Private ------------------------------------------------------------


    //=======================================================================
    //= Classes =============================================================
    //=======================================================================

    // - Public -------------------------------------------------------------
    ///<summary>This is a class to add nodes to the Queue.</summary>
    public class Node
    {
        ///<summary>This is the value to store in the node.</summary>
        public T value = default(T);
        ///<summary>This is the next node.</summary>
        public Node next = null;

        ///<summary>This method gives a value to the value variable.</summary>
        public Node(T var)
        {
            value = var;
        }
    }

    // - Private ------------------------------------------------------------


    //=======================================================================
    //= Methods =============================================================
    //=======================================================================

    // - Public -------------------------------------------------------------

    ///<summary>This method returns the number of elements in the Queue.</summary>
    public int Count() => count;


    ///<summary>This method eliminates the first element of the Queue.</summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        Node temp = head;
        head = head.next;
        count -= 1;
        return temp.value;
    }


    ///<summary>This returns the value of the first element in the Queue.</summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return head.value;
    }


    ///<summary>This method returns the Queue's type.</summary>
    public Type CheckType() => typeof(T);


    ///<summary>This method adds an element to the end of the Queue.</summary>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }

        count += 1;
    }


    ///<summary>This method prints all the elements in a Queue.</summary>
    public void Print()
    {
        if (head == null)
            Console.WriteLine("Queue is empty");
        else
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.value);
                temp = temp.next;
            }
        }
    }


    // - Private ------------------------------------------------------------



    //=======================================================================
    //= END OF CLASS ========================================================
    //=======================================================================
}

