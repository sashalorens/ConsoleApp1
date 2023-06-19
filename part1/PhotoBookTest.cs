using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.part1
{
    public class PhotoBookTest
    {

        public void init()
        {
            PhotoBook pb1 = new PhotoBook();
            Console.WriteLine(pb1.GetNumberPages());
            PhotoBook pb2 = new PhotoBook(24);
            Console.WriteLine(pb2.GetNumberPages());
            BigPhotoBook pb3 = new BigPhotoBook();
            Console.WriteLine(pb3.GetNumberPages());
        }
    }
}
