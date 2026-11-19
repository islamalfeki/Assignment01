namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            // Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
            // variable of type object.Print it.

            Book book = new Book();

            book.Title = "Atomic Habits";
            book.Pages = 250;

            object obj = book;

            // obj.Title ????????
            //  book مش ال  object ال  class  ومنفعش ولما بحثت فهمت انه بيبص على  object  عن طريق ال  Title هنا حاولت اغير فى قيمة ال 
            // وده معناه انك بتحول من نوع اعم الاب لنوع أخص الابن وبيكون بالشكل ده  Down Casting وعرفت ان حلها حاجه اسمها 
             //((Book)obj).Title = "second book";

            Console.WriteLine(obj);

            #endregion
        }
    }
}
