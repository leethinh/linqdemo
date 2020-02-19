using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqdemo
{
    class b4
    {
        static void Main()
        {
            var bq4 =
                from t in
                    from c in collec.Classes
                    select new
                    {
                        c.name,
                        dem = collec.Students.Count(s => s.classid == c.id)
                    }
                where t.dem > 0
                select t
                ;
            Console.WriteLine(" ket qua");
            foreach (var pt in bq4)
            {
                Console.WriteLine($"{pt.name},{pt.dem}");
            }
        }
    }
}
