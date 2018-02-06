using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
namespace Model
{
    public class CustomerBL:Customer
    {
        OnlineTicketBookingEntities obj;
        public CustomerBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

#region CRUD
        public void AddCustomer(CustomerBL customer)
        {
               obj.Customers.Add(customer);
               obj.SaveChanges();
        }

        public void DeleteCustomer()
        {
                obj.SaveChanges();
        }

        public void UpdateCustomer()
        {
                obj.SaveChanges();
        }

       public List<Customer> GetAllCustomer()
        {
           List<Customer> customerlst = new List<Customer>();
           customerlst = obj.Customers.ToList();
           return customerlst;
        }
#endregion

#region Filtering
        public Customer GetByCustomerId()
        {
            Customer customer = new Customer();
            customer = obj.Customers.Where(c => c.Id == Id).FirstOrDefault();
            return customer;
        }
#endregion
    }
}
