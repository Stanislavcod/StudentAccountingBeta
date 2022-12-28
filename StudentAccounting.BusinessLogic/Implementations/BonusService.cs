
using StudentAccounting.Model.DataBaseModels;
using StudentAccounting.Model;

namespace StudentAccounting.BusinessLogic.Implementations
{
    public class BonusService
    {
        private readonly ApplicationDatabaseContext _context;
        public BonusService(ApplicationDatabaseContext context)
        {
            _context = context;
        }
        public void Create(Bonus bonus)
        {
            _context.Bonuses.Add(bonus);
            _context.SaveChanges();
        }
        public IEnumerable<Bonus> Get()
        {
            return _context.Bonuses.ToList();
        }
        public Bonus Get(string name)
        {
            return _context.Bonuses.FirstOrDefault(x => x.BonusName == name);
        }
        public void Edit(Bonus bonus)
        {
            _context.Bonuses.Update(bonus);
            _context.SaveChanges();
        }
        public void Delete(Bonus bonus)
        {
            _context.Bonuses.Remove(bonus);
            _context.SaveChanges();
        }
    }
}
