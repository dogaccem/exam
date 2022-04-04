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
    public class UserRepository : EFBaseRepository<User,AppDbContext>, IUserRepository
    {
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public User FindUserByEmail(string email)
        {
            return _dbSet.FirstOrDefault(x => x.Email == email);
        }
    }
}
