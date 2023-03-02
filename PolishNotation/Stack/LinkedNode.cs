using System;
using System.Collections.Generic;
using System.Text;

namespace PolishNotation.Stack
{
    internal sealed class LinkedNode<T>
    {
        /// <summary>
        /// Возвращает значение, содержащееся в узле.
        /// </summary>
        internal T? Data { get;}

        /// <summary>
        /// Получает и устанавливает ссылку на связный узел.
        /// </summary>
        internal LinkedNode<T>? Link { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса LinkedNode, содержащего указанное значение.
        /// </summary>
        /// <param name="data">Значение, которое должно содержаться в списке.</param>
        internal LinkedNode(T? data = default) => Data = data;
    }
}
