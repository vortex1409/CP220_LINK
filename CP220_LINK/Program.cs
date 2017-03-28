using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP220_LINK
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Link Objects
            Link<int> L1 = new Link<int>(1);
            Link<int> L2 = new Link<int>(2);
            Link<int> L3 = new Link<int>(3);
            Link<int> L4 = new Link<int>(4);
            Link<int> L5 = new Link<int>(5);

            // Create Link Chain
            L1.insertAfter(L2);
            L2.insertAfter(L3);
            L3.insertAfter(L4);
            L4.insertAfter(L5);

            // Creating Chain Data Output (Shows Chain Length)
            Console.WriteLine("== LINK CHAIN ==");
            L1.print(L1);
            L2.print(L2);
            L3.print(L3);
            L4.print(L4);
            L5.print(L5);

            Console.WriteLine("==================");

            Console.WriteLine("L2's nextLink: " + L2.nextLink.data);
            L2.nextLink.remove();
            Console.WriteLine("L2's nextLink after remove method: " + L2.nextLink.data);

            Console.ReadKey();

        }

        public class Link<T>
        {
            
            //Fields
            private Link<T> _nextLink;
            private Link<T> _previousLink;
            private T _value;

            //Constructor
            public Link(T parm)
            {
                _value = parm;
            }

            //Properties
            public Link<T> nextLink
            {
                get
                {
                    if (_nextLink == null)
                    {
                        return null;
                    }
                    else
                    {
                        return _nextLink;
                    }
                }
                set
                {
                    _nextLink = value;
                }
            }
            public Link<T> previousLink
            {
                get
                {
                    if (_previousLink == null)
                    {
                        return null;
                    }
                    else
                    {
                        return _previousLink;
                    }
                }
                set
                {
                    _previousLink = value;
                }
            }
            public T data
            {
                get
                {
                    return _value;
                }
            }

            //Methods
            public void remove()
            {
                if (_nextLink == null)
                {
                    _previousLink._nextLink = null;
                }
                else if (_previousLink == null)
                {
                    _nextLink._previousLink = null;
                }
                else
                {
                    _nextLink._previousLink = _previousLink;
                    _previousLink._nextLink = _nextLink;
                }
            }
            public void insertAfter(Link<T> newObject)
            {
                _nextLink = newObject;
                newObject._previousLink = this;
            }
            public void print(Link<T> LinkObj)
            {
                Link<T> tmp = LinkObj;
                if(tmp != null)
                {
                    Console.WriteLine(tmp.data);
                    tmp = tmp.nextLink;
                }
            }
        }

    }
}
