using StudentAccounting.Model.DataBaseModels;
using StudentAccounting.Model;

namespace StudentAccounting.BusinessLogic.Implementations
{
    public class CustomerService
    {
        private readonly ApplicationDatabaseContext _context;

        public CustomerService(ApplicationDatabaseContext context)
        {
            _context = context;
        }
        public void Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }
        public IEnumerable<Customer> Get()
        {
            return _context.Customers.ToList();
        }
        public Customer Get(string name)
        {
            return _context.Customers.FirstOrDefault(x => x.FullName == name);
        }
        public void Edit(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }
        public void Delete(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
    }
}
