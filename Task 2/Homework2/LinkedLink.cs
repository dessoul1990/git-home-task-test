using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    class LinkedList<T> : IEnumerable<T>
    {
        private DataItem<T> Head { get; set; }
        private DataItem<T> LastNode { get; set; }

        public int Count { get; private set; }

        public LinkedList()
        {
            Clear();
        }

        public LinkedList(T data)
        {
            var item = new DataItem<T>(data);
            SetHeadAndLastNode(item);
        }

        public void Add(T data)
        {
            var item = new DataItem<T>(data);
            if (LastNode != null)
            {
                LastNode.Next = item;
                LastNode = item;
                Count++;
            }
            else
            {
                SetHeadAndLastNode(item);
            }
        }

        private void SetHeadAndLastNode(DataItem<T> item)
        {
            Head = item;
            LastNode = item;
            Count = 1;
        }

        public void Delete(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                }

                var current = Head.Next;
                var previous = Head;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
        }

        public void Clear()
        {
            DeleteAllDataItems();
        }

        private void DeleteAllDataItems()
        {
            Head = null;
            LastNode = null;
            Count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
