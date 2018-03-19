using System;
using System.Collections.Generic;
using System.Collections;

namespace Checkers
{
    //Super simple linked list implementation. Supports adding items to the list and using a foreach loop to retrieve them
    //This class extends IEnumerable<T> but not IList<T> since that would require implementing unneeded extra features
    public class LinkedList<T> : IEnumerable<T>
    {
        public int Length { get; private set; }
        internal Node<T> first, last;
        public LinkedList() => Length = 0;

        public void Add(T element)
        {
            Node<T> newNode = new Node<T>(element);
            if (last == null)
                first = newNode;
            else
                last.Next = newNode;
            last = newNode;
            Length++;
        }
        public void AddAll(LinkedList<T> other)
        {
            foreach (T element in other)
                Add(element);
        }

        public IEnumerator<T> GetEnumerator() => new LLEnum<T>(this);
        IEnumerator IEnumerable.GetEnumerator() => new LLEnum<T>(this);

        internal class Node<V>
        {
            public Node<V> Next { get; internal set; }
            public V Val { get; private set; }
            public Node(V val) => Val = val;
        }
    }
    //Simple enumerator for LinkedList<T>. Implemented so that foreach loops work correctly on Linked Lists
    public class LLEnum<V> : IEnumerator<V>
    {
        private LinkedList<V> ls;
        private bool started = false;
        private LinkedList<V>.Node<V> currentNode;
        private LinkedList<V>.Node<V> CurrentNode
        {
            get => currentNode;
            set
            {
                currentNode = value;
                if (value != null)
                    Current = currentNode.Val;
            }
        }
        public V Current { get; private set; }
        object IEnumerator.Current => Current;

        public LLEnum(LinkedList<V> ls) => this.ls = ls;

        public void Dispose() { }

        public bool MoveNext()
        {
            if (CurrentNode == null)
            {
                if (started)
                    return false;
                started = true;
                CurrentNode = ls.first;
                return CurrentNode != null;
            }
            CurrentNode = CurrentNode.Next;
            return CurrentNode != null;
        }

        public void Reset()
        {
            started = false;
            CurrentNode = null;
        }
    }
}
