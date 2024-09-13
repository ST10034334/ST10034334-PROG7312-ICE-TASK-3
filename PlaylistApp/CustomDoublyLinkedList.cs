using System.Text;

namespace PlaylistApp
{
    //GeeksForGeeks (2024) demonstrates Doubly Linked List.
    public class CustomDoublyLinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private Node<T> current;
        private int count;

        public CustomDoublyLinkedList()
        {
            head = null;
            tail = null;
            current = null;
            count = 0;

        }

        //Adds an item to the list.
        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
                count++;
            }
            else
            {
                tail.Next = newNode;
                newNode.Previous = tail;
                tail = newNode;
                count++;
            }

        }

        //Removes an item from the list.
        public (bool removed, bool end) Remove()
        {
            bool isRemoved = false;
            bool atEnd = false;
            if (current != null)
            {

                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                    isRemoved = true;
                }


                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                    isRemoved = true;
                }

                if (current.Next == null)
                {
                    atEnd = true;
                }

            }
            count--;
            return (isRemoved, atEnd);
        }


        //Shows first item in list.
        public T PrintFirst()
        {
            current = head;
            return head.Data;
        }

        //Shows the next item in the list.
        public (Node<T> data, bool reachedEnd) PrintNext()
        {
            if (current != null)
            {
                current = current.Next;

                if (current != null)
                {
                    return (current, false);
                }
                else
                {
                    return (default, true);
                }

            }
            return (default, true);

        }

        public void ResetPrevious()
        {
            current = tail;
        }

        public void ResetNext()
        {
            current = head;
        }

        //Shows the previous item in a list.
        public (T data, bool reachedBeginning) PrintPrevious()
        {

            if (current != null)
            {
                current = current.Previous;

                if (current != null)
                {
                    return (current.Data, false);
                }
                else
                {
                    return (default, true);
                }
            }
            else
            {
                return (default, true);
            }


        }

        //Shows all items in the list.
        public string PrintList()
        {
            Node<T> current = head;

            StringBuilder listOutput = new StringBuilder();

            while (current != null)
            {
                listOutput.Append(current.Data.ToString());
                current = current.Next;
            }
            return listOutput.ToString();
        }

    }
}
//REFERENCE LIST:
//GeeksForGeeks. 2024. Doubly Linked List Tutorial (Version 2.0)
//[Source code] https://www.geeksforgeeks.org/doubly-linked-list/
//(Accessed 29 July 2024).