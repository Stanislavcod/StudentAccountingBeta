using StudentAccounting.Model.DataBaseModels;
using StudentAccounting.Model;

namespace StudentAccounting.BusinessLogic.Implementations
{
    public class UserService
    {
        private readonly ApplicationDatabaseContext _context;
        public UserService(ApplicationDatabaseContext context)
        {
            _context = context;
        }
        public void Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public IEnumerable<User> Get()
        {
            return _context.Users.ToList();
        }
        public User Get(string name)
        {
            return _context.Users.FirstOrDefault(x => x.Login == name);
        }
        public void Edit(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
        public void Delete(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}
