using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.Data.Entity.Validation;

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
        public void AddCustomer(Customer customer)
        {
            try
            {
                obj.Customers.Add(customer);
                obj.SaveChanges();
            } 
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
}
                throw;
            }
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
