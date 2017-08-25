using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DZSerialization
{
    [Serializable]
    public class Book
    {
        string bookName { get; set; }
        double price { get; set; }
        string author { get; set; }
        int year { get; set; }
        public Book(string bookName, double price, string author, int year)
        {
            this.bookName = bookName;
            this.price = price;
            this.author = author;
            this.year = year;
        }
    }
    public class PhoneBook
    {
        public string name;
        public string lastname;
        public string phone;
        public string year;

        public List<PhoneBook> readFile (string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                StreamReader sr = new StreamReader(file,System.Text.Encoding.Default);
                string line;
                line = sr.ReadToEnd();

                string[] array = line.Split('\n');

                PhoneBook pb = new PhoneBook();
                foreach (var item in array)
                {

                }
            }
            return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook ph = new PhoneBook();
            List<PhoneBook> list ph.readFile(@"");



            
        }
    }
}
