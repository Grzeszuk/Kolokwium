using KolokwiumZadanie1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Zadanie1
{
    public class Node<T>
    {    
            public T value;
            public Node<T> next;
            public Node<T> previous;       
    }

    public class Lista<T> : ILista<T>, IEnumerable<T>, IDisplay
    {

        private Node<T> _tail = null;
        private Node<T> _head = null;

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> head = _head;
            if (head != null)
                do
                {
                    yield return head.value;
                    head = head.next;
                } while (head != null);
        }

        public T pop(int position)
        {
            if (_head == null) return default(T);
            var returnValue = _head.value;
            _head = _head.next;
            return returnValue;
        }

        public void push(T v)
        {
            var node = new Node<T>();
            node.value = v;
            node.next = null;
            if (_tail != null)
            {
                _tail.next = node;
            }
            else
            {
                _head = node;
            }
            _tail = node;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void display()
        {
            foreach (var item in this)
            {
                Console.WriteLine($"{item.ToString()}");
            }
        }
    }
}