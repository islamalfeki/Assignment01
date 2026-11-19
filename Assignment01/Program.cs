using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //// Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
            //// variable of type object.Print it.

            //Book book = new Book();

            //book.Title = "Atomic Habits";
            //book.Pages = 250;

            //object obj = book;

            //// obj.Title ????????
            ////  book مش ال  object ال  class  ومنفعش ولما بحثت فهمت انه بيبص على  object  عن طريق ال  Title هنا حاولت اغير فى قيمة ال 
            //// وده معناه انك بتحول من نوع اعم الاب لنوع أخص الابن وبيكون بالشكل ده  Down Casting وعرفت ان حلها حاجه اسمها 
            ////((Book)obj).Title = "second book";

            //Console.WriteLine(obj);

            #endregion

            #region Question02
            //// Using the Book class above, print the result of calling ToString(), Equals() (compare book with
            ////itself), GetHashCode(), and GetType() on book.

            //Book book = new Book();
            //book.Title = "Atomic Habits";
            //book.Pages = 250;


            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());

            #endregion

            #region Question03
            //// Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            ////int pages = "464";


            //// Answer
            //// it is a compile-Time error => syntax error
            //int pages = 464 ;
            #endregion

            #region Question04
            ////  Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by
            ////zero", and then prints "Done" in a finally block.

            //try {
            //    int x = 10;
            //    int y = 0;
            //    int z = x / y; 
            //} 
            //catch (Exception) {

            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally {
            //    Console.WriteLine("Done");
            //};

            #endregion

            #region Question05
            ////  Declare an int pages = 300; then store it in a double variable without using a cast.

            //int pages = 300;
            //double x = pages;

            #endregion

            #region Question06
            //// Declare a double price = 49.99; then convert it into an int using a cast.

            //double price = 49.99;
            //int d = (int) price;     // Explicit Casting

            //Console.WriteLine(d);
            #endregion

            #region Question07
            //// Given string pagesText = "464";, convert it into an int using the Convert class.

            //string pagesText = "464";
            //int pagesNumber = Convert.ToInt32(pagesText);

            //Console.WriteLine(pagesNumber);
            #endregion

            #region Question08 
            //// Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,
            ////use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.

            //string yearText = "2023";
            //int year = int.Parse(yearText);
            //Console.WriteLine(year);


            //string badText = "abc";
            //// TryParse => bool 
            //if (int.TryParse(badText, out int result)) {

            //Console.WriteLine(result);

            //}
            //else {

            // Console.WriteLine("Invalid number");
            //}


            #endregion

            #region Question09 
            //// Given int pages = 464;, convert it into a string using ToString() and print its type using GetType()
            ////to prove it's now a string.

            //int pages = 464;
            //string pagesText = pages.ToString();

            //Console.WriteLine(pagesText.GetType());

            #endregion

            #region Question10
            ////  Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
            ////  variable, and print both.

            //int copies = 100;
            //object i = copies;  // Boxing (Implicit)
            //int j = (int) i;    // Unboxing (Explicit)

            //Console.WriteLine(i);
            //Console.WriteLine(j);
            #endregion

            #region Question11
            //// Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its value.


            //int? year = null;
            //// I searched to get whether it has a value or not and I found HasValue attribute for int class and it gives bool
            //Console.WriteLine(year.HasValue);

            //year = 2023;
            //Console.WriteLine(year);

            #endregion

            #region Question12
            ////  Declare a string? reviewer = null;. Print whether it is null

            //string? reviewer = null;

            //if (reviewer == null)
            //{
            //    Console.WriteLine("reviewer is null");
            //}
            //else {
            //    Console.WriteLine(reviewer);
            //}


            //// another solution
            //// using is null and it gives you true or false
            //Console.WriteLine(reviewer is null);

            #endregion

            #region Question13
            // Declare a Book? book = null;. Use ?. to safely read book.Title without crashing the program, and
            //print the result.

            Book? book = null;
            Console.WriteLine(book?.Title);

            #endregion
        }
    }
}
