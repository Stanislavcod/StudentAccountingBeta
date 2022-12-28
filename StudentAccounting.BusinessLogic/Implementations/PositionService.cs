using StudentAccounting.Model.DataBaseModels;
using StudentAccounting.Model;

namespace StudentAccounting.BusinessLogic.Implementations
{
    public class PositionService
    {
        private readonly ApplicationDatabaseContext _context;
        public PositionService(ApplicationDatabaseContext context)
        {
            _context = context;
        }
        public void Create(Position position)
        {
            _context.Positions.Add(position);
            _context.SaveChanges();
        }
        public IEnumerable<Position> Get()
        {
            return _context.Positions.ToList();
        }
        public Position Get(string name)
        {
            return _context.Positions.FirstOrDefault(x => x.FullName == name);
        }
        public void Edit(Position position)
        {
            _context.Positions.Update(position);
            _context.SaveChanges();
        }
        public void Delete(Position position)
        {
            _context.Positions.Remove(position);
            _context.SaveChanges();
        }
    }
}
