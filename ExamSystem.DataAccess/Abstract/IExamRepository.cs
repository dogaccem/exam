using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Entities.Concrete.Models;
using ExamSystem.Shared.Data;

namespace ExamSystem.DataAccess.Abstract
{
    public interface IExamRepository : IRepository<Exam>
    {

    }
}
