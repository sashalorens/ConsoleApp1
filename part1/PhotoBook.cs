using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.part1
{
    public class PhotoBook
    {
        private int numPages { get; set; } = 0;

        public PhotoBook(int number)
        {
            numPages = number;
        }

        public PhotoBook() : this(16)
        { }

        public int GetNumberPages() => numPages;
    }
}
