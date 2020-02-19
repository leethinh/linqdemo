using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqdemo
{
    class b5
    {
        static void Main()
        {
            var bq5 =
                from c in collec.Classes
                join s in collec.Students
                on c.id equals s.classid into t
                select new
                {

                    classname = c.name,
                    first = t.FirstOrDefault()?.stu_name ?? "Null"
                };
            Console.WriteLine("ket qua");
            foreach (var pt in bq5)
            {
                Console.WriteLine($"{pt.classname},{pt.first}");
            }
        }
    }
}
