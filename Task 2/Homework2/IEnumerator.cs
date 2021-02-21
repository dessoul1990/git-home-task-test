using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Homework2
{
    public interface IEnumerable
    {
        bool MoveNext();
        object Current { get; }
        void Reset();
    }
}
