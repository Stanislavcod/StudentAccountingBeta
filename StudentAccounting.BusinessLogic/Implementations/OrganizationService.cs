using StudentAccounting.Model;
using StudentAccounting.Model.DataBaseModels;

namespace StudentAccounting.BusinessLogic.Implementations
{
    public class OrganizationService
    {
        private readonly ApplicationDatabaseContext _context;
        public OrganizationService()
        {
            _context = new ApplicationDatabaseContext();
        }
        public void Create(Organization organization)
        {
            _context.Organizations.Add(organization);
            _context.SaveChanges();
        }
        public IEnumerable<Organization> Get()
        {
            return _context.Organizations.ToList();
        }
        public Organization Get(string name)
        {
            return _context.Organizations.FirstOrDefault(x => x.Fullname == name);
        }
        public void Edit(Organization organization)
        {
            _context.Organizations.Update(organization);
            _context.SaveChanges();
        }
        public void Delete(Organization organization)
        {
            _context.Organizations.Remove(organization);
            _context.SaveChanges();
        }
    }
}
