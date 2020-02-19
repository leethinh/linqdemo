using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqdemo
{
    class b2
    {
        static void Main()
        {
            var bq1 =
                from c in collec.Classes
                select new
                {
                    c.name,
                    Count = collec.Students.Count(s => s.classid == c.id)
                };
            Console.WriteLine("ket qua");
            foreach (var pt in bq1)
            {
                Console.WriteLine($"{pt.name}, {pt.Count}");
            }

        }
    }
}
