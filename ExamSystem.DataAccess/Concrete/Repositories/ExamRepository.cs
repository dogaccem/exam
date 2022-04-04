using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.DataAccess.Abstract;
using ExamSystem.DataAccess.Concrete.Contexts;
using ExamSystem.Entities.Concrete.Models;
using ExamSystem.Shared.Data;

namespace ExamSystem.DataAccess.Concrete.Repositories
{
    public class ExamRepository : EFBaseRepository<Exam,AppDbContext>, IExamRepository
    {
        public ExamRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
