using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQQ
{
    static class Program
    {
        static void Main()
        {
            var stdlist = new List<Stu>
            {
                new Stu(){StdId = 10, StdName = "Kunal", StdEmail = "kunal@yopmil.com" , StdProg = new List<string>{ "C#" , "python"} },
                new Stu(){StdId = 15, StdName = "Raj", StdEmail = "raj@yopmil.com" ,  StdProg = new List<string>{ "C" , "java"}},
                new Stu(){StdId = 25, StdName = "Kunj", StdEmail = "kunj@yopmil.com" ,  StdProg = new List<string>{ "JS" , "ruby"}}

            };

            var nlist = new List<string> { "abc", "xyz" };

            //var methodquery = stdlist.Select(x => x).ToList();
            //var methodquery = nlist.SelectMany(x => x).ToList();
            //var methodquery = stdlist.SelectMany(x => x.StdProg).ToList();
            var methodquery = stdlist.SelectMany(x => x.StdEmail).ToList();
            foreach (var item in methodquery)
            {
                Console.WriteLine(item);
            }

        }
    }

    public class Stu{
        public int StdId { get; set; }
        public string StdName { get; set; }
        public string StdEmail{ get; set; }

        public List<string> StdProg { get; set; }
    }





}
