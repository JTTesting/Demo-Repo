using LibDemo2;
using LibDemo3;
namespace LibDemo1
{
    public class LibClass1
    {
        private string _message;
        public LibClass1(string message)
        {
            _message = Lib2(Lib3(message));
        }

        static string Lib2(string txt)
        {
            LibClass2 Lib = new LibClass2(txt);
            return Lib.GetMessage2();
        }

        static string Lib3(string txt)
        {
            LibClass3 Lib = new LibClass3(txt);
            return Lib.GetMessage3();
        }

        public string GetMessage1()
        {
            return $"{_message} and from Library1";
        }
    }
}
