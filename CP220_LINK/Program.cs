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
            Link<int> L0 = new Link<int>(0);
            Link<int> L1 = new Link<int>(1);
            Link<int> L2 = new Link<int>(2);
            Link<int> L3 = new Link<int>(3);
            Link<int> L4 = new Link<int>(4);
            Link<int> L5 = new Link<int>(5);

            // Create Link Chain
            L0.insertAfter(L1);
            L1.insertAfter(L2);
            L2.insertAfter(L3);
            L3.insertAfter(L4);
            L4.insertAfter(L5);

            //Creating Chain Data Output (Shows Chain Length)
            
            Console.WriteLine("======= LINK CHAIN =======");
            Console.WriteLine();
            Console.WriteLine("LINK 0 PREVIOUS LINK: " + chkNull(L0, 0));
            Console.WriteLine("LINK 0 DATA: " + L0.data);
            Console.WriteLine("LINK 0 NEXTLINK: " + chkNull(L0, 1));
            Console.WriteLine();
            Console.WriteLine("LINK 1 PREVIOUS LINK: " + chkNull(L1, 0));
            Console.WriteLine("LINK 1 DATA: " + L1.data);
            Console.WriteLine("LINK 1 NEXTLINK: " + chkNull(L1, 1));
            Console.WriteLine();
            Console.WriteLine("LINK 2 PREVIOUS LINK: " + chkNull(L2, 0));
            Console.WriteLine("LINK 2 DATA: " + L2.data);
            Console.WriteLine("LINK 2 NEXTLINK: " + chkNull(L2, 1));
            Console.WriteLine();
            Console.WriteLine("LINK 3 PREVIOUS LINK: " + chkNull(L3, 0));
            Console.WriteLine("LINK 3 DATA: " + L3.data);
            Console.WriteLine("LINK 3 NEXTLINK: " + chkNull(L3, 1));    
            Console.WriteLine();
            Console.WriteLine("LINK 4 PREVIOUS LINK: " + chkNull(L4, 0));
            Console.WriteLine("LINK 4 DATA: " + L4.data);
            Console.WriteLine("LINK 4 NEXTLINK: " + chkNull(L4, 1));
            Console.WriteLine();
            Console.WriteLine("LINK 5 PREVIOUS LINK: " + chkNull(L5, 0));
            Console.WriteLine("LINK 5 DATA: " + L5.data);
            Console.WriteLine("LINK 5 NEXTLINK: " + chkNull(L5, 1));
            
            Console.WriteLine("L2's nextLink: " + L2.nextLink.data);
            L2.nextLink.remove();
            L2.previousLink.remove();
            Console.WriteLine("L2's nextLink after remove method: " + L2.nextLink.data);
            Console.WriteLine("L2's previousLink after remove method: " + L2.previousLink.data);

            Console.WriteLine("======= LINK CHAIN =======");
            Console.WriteLine();
            Console.WriteLine("LINK 0 PREVIOUS LINK: " + chkNull(L0, 0));
            Console.WriteLine("LINK 0 DATA: " + L0.data);
            Console.WriteLine("LINK 0 NEXTLINK: " + chkNull(L0, 1));
            Console.WriteLine();
            Console.WriteLine("LINK 1 PREVIOUS LINK: " + chkNull(L1, 0));
            Console.WriteLine("LINK 0 DATA: " + L1.data);
            Console.WriteLine("LINK 1 NEXTLINK: " + chkNull(L1, 1));
            Console.WriteLine();
            Console.WriteLine("LINK 2 PREVIOUS LINK: " + chkNull(L2, 0));
            Console.WriteLine("LINK 0 DATA: " + L2.data);
            Console.WriteLine("LINK 2 NEXTLINK: " + chkNull(L2, 1));
            Console.WriteLine();
            Console.WriteLine("LINK 3 PREVIOUS LINK: " + chkNull(L3, 0));
            Console.WriteLine("LINK 0 DATA: " + L3.data);
            Console.WriteLine("LINK 3 NEXTLINK: " + chkNull(L3, 1));
            Console.WriteLine();
            Console.WriteLine("LINK 4 PREVIOUS LINK: " + chkNull(L4, 0));
            Console.WriteLine("LINK 0 DATA: " + L4.data);
            Console.WriteLine("LINK 4 NEXTLINK: " + chkNull(L4, 1));
            Console.WriteLine();
            Console.WriteLine("LINK 5 PREVIOUS LINK: " + chkNull(L5, 0));
            Console.WriteLine("LINK 0 DATA: " + L5.data);
            Console.WriteLine("LINK 5 NEXTLINK: " + chkNull(L5, 1));


            Console.ReadKey();

        }


       public static string chkNull(Link<int> input, int NP)
        {
            if(input.nextLink == null && NP == 1)
            {
                return "NULL";
            }
            else if(input.previousLink == null && NP == 0)
            {
                return "NULL";
            }
            else if(input.nextLink != null && NP == 1)
            {
                return Convert.ToString(input.nextLink.data);
            }
            else if (input.previousLink != null && NP == 0)
            {
                return Convert.ToString(input.previousLink.data);
            }
            else 
            {
                return "UNKNOWN DATA";
            }
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
            public T print(Link<T> LinkObj)
            {
                Link<T> tmp = LinkObj;
                if(tmp != null)
                {
                    return tmp.data;
                }
                else
                {
                    return default(T);
                }
            }
        }

    }
}
