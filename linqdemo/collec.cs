using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqdemo
{
    public static class collec
    {
        private static List<Class> classes;
        private static List<student> students;
        public static List<student> Students
        {
            get
            {

                students = new List<student>()
                    {
                        new student(){stu_id=11,stu_name="st1",classid=1},
                        new student(){stu_id=12,stu_name="st2",classid=1},
                        new student(){stu_id=13,stu_name="st3",classid=2}
                    };

                return students;
            }
        }
        public static List<Class> Classes
        {
            get
            {

                classes = new List<Class>()
                    {
                        new Class(){id=1,name="c1"},
                        new Class(){id=2,name="c2"},
                        new Class(){id=3,name="c3"}
                    };

                return classes;
            }
        }
    }
}
