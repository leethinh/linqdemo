using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqdemo
{
    class b3
    {
        static void Main()
        {
            var bq3 =
                from s in collec.Students
                group s by s.classid into n
                select new
                {
                    classid = n.Key,
                    count = n.Count()
                };
            Console.WriteLine("ket qua");
            foreach (var pt in bq3)
            {
                Console.WriteLine($"{pt.classid},{pt.count}");
            }
        }
    }
}
