using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Entities.Concrete.Models
{
    public class Exam
    {
        //private List<IQuestion> questions = new List<IQuestion>();
        //public IReadOnlyList<IQuestion> Questions => questions;
        public string Id { get; private set; }
        public DateTime Date { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
    }
}
