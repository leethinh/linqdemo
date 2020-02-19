using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var bq1 = from c in collec.Classes
                      from s in collec.Students
                      select new
                      {
                          c.id,
                          s.stu_id
                      };
            Console.WriteLine(" ket qua");
            foreach (var pt in bq1)
            {
                Console.WriteLine($"{pt.stu_id},{pt.id}");
            }
            Console.WriteLine("okkk");
        }
    }
}
