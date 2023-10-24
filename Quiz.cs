using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25oct_task
{
    public class Quiz
    {
        private static int Count = 1;

        public int Id { get; private set; }
        public string Name { get; set; }
        public List<Question> Questions { get; set; }
        
        public Quiz(string name, List<Question> questions)
        {
            Id = Count++;
            Name = name;
            Questions = questions;
        }

       
    }
}
