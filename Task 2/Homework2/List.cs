using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{      
        public class DataItem<T>
        {
            private T data = default(T);
            public T Data
            {
                get { return data; }
                set
                {
                    if (value != null)
                        data = value;
                }
            }
            public DataItem<T> Next { get; set; }

            public DataItem(T data)
            {
                Data = data;
            }

            public override string ToString()
            {
                return Data.ToString();
            }
        }
    }

