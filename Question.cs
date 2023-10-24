using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25oct_task
{
    public class Question
    {
        private static int Count = 1;
        public int Id {  get; set; }
        public string Text { get; set; }
        public List<string> Variants { get; set; }
        public int CorrectVariant { get; set; }

        public Question()
        {
            Id = Count++;
        }
    }
}
