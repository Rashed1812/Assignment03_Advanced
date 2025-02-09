using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_Advanced
{
    public delegate string DelegateBookFunc(Book book);
    internal class LibraryEngine
    {
        #region 1.Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.
       
        public static void ProcessBooks(List<Book> bList, DelegateBookFunc fptr)
        {
            foreach (var B in bList)
            {
                Console.WriteLine(fptr(B));
            }
        }
        #endregion

        public static void ProcessBook2(List<Book> bLists,Func<Book,string> fptr) 
        {
            foreach (var B in bLists)
            {
                Console.WriteLine(fptr(B));
            }
        }
    }
}
