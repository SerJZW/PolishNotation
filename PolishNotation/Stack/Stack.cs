using System;
using System.Collections.Generic;
using System.Text;

namespace PolishNotation.Stack
{
    public class Stack<T> 
    {
        /// <summary>
        /// Последний элемент в стеке.
        /// </summary>
        private LinkedNode<T>? _last;
        public bool IsEmpty => _last is null;

        public void Push(T? item) => _last = new LinkedNode<T>(item) { Link = _last };

        public T? Pop()
        {
            if (_last is null) throw new InvalidOperationException("Стек является пустым.");

            var res = _last!.Data;
            _last = _last.Link;
            return res;
        }

        public T? Peek() => _last is null ? throw new InvalidOperationException("Стек является пустым.") : _last!.Data;
    }
}
