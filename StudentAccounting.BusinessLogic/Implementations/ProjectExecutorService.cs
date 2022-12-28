using StudentAccounting.Model.DataBaseModels;
using StudentAccounting.Model;

namespace StudentAccounting.BusinessLogic.Implementations
{
    public class ProjectExecutorService
    {
        private readonly ApplicationDatabaseContext _context;
        public ProjectExecutorService(ApplicationDatabaseContext context)
        {
            _context = context;
        }
        public void Create(ProjectExecutor projectExecutor)
        {
            _context.ProjectExecutor.Add(projectExecutor);
            _context.SaveChanges();
        }
        public IEnumerable<ProjectExecutor> Get()
        {
            return _context.ProjectExecutor.ToList();
        }
        public ProjectExecutor Get(int id)
        {
            return _context.ProjectExecutor.FirstOrDefault(x => x.Id == id);
        }
        public void Edit(ProjectExecutor projectExecutor)
        {
            _context.ProjectExecutor.Update(projectExecutor);
            _context.SaveChanges();
        }
        public void Delete(ProjectExecutor projectExecutor)
        {
            _context.ProjectExecutor.Remove(projectExecutor);
            _context.SaveChanges();
        }
    }
}
