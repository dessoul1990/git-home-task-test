using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Homework2
{
    internal class ComplicatedContainer : IEnumerable, IEnumerator
    {
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        public bool MoveNext()
        {
            return true;
        }
        public void Reset()
        {
            throw new System.NotImplementedException();
        }     
        public object Current
        {
            get
            {
                return null;
            }
        }
    



    }
}
