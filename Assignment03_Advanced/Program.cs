namespace Assignment03_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<Book> books = new List<Book>()
            //{
            //new Book("1","Programming",new [] {"Ahmed","Ali","Gaber"},DateTime.Now,1500),
            //new Book("2","C#",new [] {"Abdullah","Salem","Kareem"},DateTime.Now,200),
            //new Book("3","Algorithm",new [] {"Khaled","Marwa","Fadi"},DateTime.Now,1250)
            //};

            #region 1.Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.

            //DelegateBookFunc TitleDelegate = BookFunction.GetTitle;
            //DelegateBookFunc PriceDelegate = BookFunction.GetPrice;
            //DelegateBookFunc AuthorsDelegate = BookFunction.GetAuthors;

            //LibraryEngine.ProcessBooks(books, TitleDelegate);
            //LibraryEngine.ProcessBooks(books, PriceDelegate);
            //LibraryEngine.ProcessBooks(books, AuthorsDelegate);

            #endregion

            #region 2.Use the Proper build in delegate. 

            //Func<Book, string> funcTitle = BookFunction.GetTitle;
            //LibraryEngine.ProcessBook2(books, funcTitle);

            #endregion

            #region 3.Anonymous Method (GetISBN).
            //Func< string> GetISBN = delegate (){return $"101";};
            #endregion

            #region 4.Lambda Expression (GetPublicationDate).
            //Func<DateTime> GetPublicationDate = () => new DateTime(2025, 2, 9);
            #endregion
        }
    }
}
