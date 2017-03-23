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
            //Link<int> myLink = new Link<int>(16);
            //Debug.WriteLine(myLink.Data);

            //myLink.insertAfter(new Link<int>(21));

            //Debug.WriteLine(myLink.nextValue.Data);

        }

        public class Link<T>
        {
            private Link<T> _nextLink;
            private Link<T> _previousLink;
            private T value;

            public Link(T parm)
            {
                value = parm;
            }

            public Link<T> nextLink
            {
                get
                {
                    return _nextLink;
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
                    return _previousLink;
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
                    return value;
                }
            }

            public void remove()
            {
                nextLink.previousLink = previousLink;
                previousLink.nextLink = nextLink;
            }

            public void insertAfter(Link<T> newObj)
            {

            }
        }

    }
}
