﻿using System.Drawing;
using System.Linq.Expressions;

namespace hash_table_dictionary;

public class LinkedList
{
    private LinkedListNode? _head;

    private LinkedListNode? _tail;
    private int _size;

    public LinkedList()
    {
        _tail = null;
        _head = null;
        _size = 0;
    }
    public void AddBack(KeyValuePair pair)
    {
        // add provided pair to the end of the linked list
        if (this._size == 0)
        {
            LinkedListNode cur = new LinkedListNode(pair);
            _tail = cur;
            _head = cur;
            _size++;
            return;
        }

        LinkedListNode notLastAnymore = _tail;
        LinkedListNode last = new LinkedListNode(pair);
        _tail = last;
        notLastAnymore.Next = last;
        _size++;
    }

    public void PrintLinkedList()
    {
        LinkedListNode? cur = _head;
        for (int i = 0; i < _size; i++)
        {
            Console.WriteLine($"{cur.Pair.Key} and {cur.Pair.Value}");
            cur = cur.Next;
        }
    }

    public void RemoveByKey(string key)
    {
        // remove pair with provided key
        if (this._size == 0)
        {
            throw new Exception("cannot remove something from an empty list");
        }

        LinkedListNode? cur = this._head;
        LinkedListNode? prev = null;
        for (int i = 0; i < this._size; i++)
        {
            // check if the element is what we are looking for
            var curPairKey = cur.Pair.Key;
            if (key == curPairKey)
            {
                // remove this element and finish void
                // if element is the first one
                if (cur == _head)
                {
                    _head = _head.Next;
                }
                else
                {
                    prev.Next = cur.Next;
                }
                _size--;
                // if we want to delete last element, we should change tail
                if (cur.Next == null)
                {
                    _tail = prev;
                }
                return;
            }
            // move cur to the next, and change prev to the next
            cur = cur.Next;
            if (prev == null)
            {
                prev = _head;
            }
            else
            {
                prev = prev.Next;
            }
            
            
        }

        throw new Exception("there is no such element in the list, so I cannot delete it");
    }

    /* public KeyValuePair GetItemWithKey(string key)
    {
        // get pair with provided key, return null if not found
        return;
    }*/
}