using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
namespace Model
{
    public class CustomerClass
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<int> PhoneNo { get; set; }
        public Nullable<int> AlternatePhoneNo { get; set; }
        public string Address { get; set; }
        public string IdProof { get; set; }
        public Nullable<int> CityId { get; set; }
        public Nullable<int> PostalCode { get; set; }
        public string Fax { get; set; }
        public string ArrivalInfo { get; set; }
        public string Comments { get; set; }
        public string Nationality { get; set; }
        public string PassportNo { get; set; }
        public Nullable<int> PassportCountryId { get; set; }
        public Nullable<System.DateTime> ExpiryDateOfPassport { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }

#region CRUD
        public void AddCustomer()
        {
                using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
                {
                    Customer customer = new Customer();
                    customer.UserId = UserId;
                    customer.FirstName = FirstName;
                    customer.LastName = LastName;
                    customer.MiddleName = MiddleName;
                    customer.Email = Email;
                    customer.DOB = DOB;
                    customer.PhoneNo = PhoneNo;
                    customer.AlternatePhoneNo = AlternatePhoneNo;
                    customer.Address = Address;
                    customer.IdProof = IdProof;
                    customer.CityId = CityId;
                    customer.PostalCode = PostalCode;
                    customer.Fax = Fax;
                    customer.ArrivalInfo = ArrivalInfo;
                    customer.Comments = Comments;
                    customer.Nationality = Nationality;
                    customer.PassportNo = PassportNo;
                    customer.PassportCountryId = PassportCountryId;
                    customer.ExpiryDateOfPassport = ExpiryDateOfPassport;
                    customer.CreatedBy = CreatedBy;
                    customer.CreatedDate = CreatedDate;
                    customer.UpdatedBy = UpdatedBy;
                    customer.UpdatedDate = UpdatedDate;
                    customer.IsActive = IsActive;

                    obj.Customers.Add(customer);
                    obj.SaveChanges();
                }
        }

        public void DeleteCustomer(CustomerClass data)
        {
            using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Customer customer = obj.Customers.Where(c => c.Id == data.Id).FirstOrDefault();
                obj.Customers.Remove(customer);
                obj.SaveChanges();
            }
        }

        public void UpdateCustomer(CustomerClass data)
        {
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Customer customer = obj.Customers.Where(c => c.Id == data.Id).FirstOrDefault();
                customer.UserId = data.UserId;
                customer.FirstName = data.FirstName;
                customer.LastName = data.LastName;
                customer.MiddleName = data.MiddleName;
                customer.Email = data.Email;
                customer.DOB = data.DOB;
                customer.PhoneNo = data.PhoneNo;
                customer.AlternatePhoneNo = data.AlternatePhoneNo;
                customer.Address = data.Address;
                customer.IdProof = data.IdProof;
                customer.CityId = data.CityId;
                customer.PostalCode = data.PostalCode;
                customer.Fax = data.Fax;
                customer.ArrivalInfo = data.ArrivalInfo;
                customer.Comments = data.Comments;
                customer.Nationality = data.Nationality;
                customer.PassportNo = data.PassportNo;
                customer.PassportCountryId = data.PassportCountryId;
                customer.ExpiryDateOfPassport = data.ExpiryDateOfPassport;
                customer.CreatedBy = data.CreatedBy;
                customer.CreatedDate = data.CreatedDate;
                customer.UpdatedBy = data.UpdatedBy;
                customer.UpdatedDate = data.UpdatedDate;
                customer.IsActive = data.IsActive;

                obj.SaveChanges();
            }
        }

       public List<Customer> GetAllCustomer()
        {
            List<Customer> customerlst = new List<Customer>();
           using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
           {
               customerlst = obj.Customers.ToList();
           }
           return customerlst;
        }
#endregion

#region Filtering
        public Customer GetByCustomerId(CustomerClass data)
        {
            Customer customer = new Customer();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                customer = obj.Customers.Where(c => c.Id == data.Id).FirstOrDefault();
            }
            return customer;
        }
#endregion
    }
}
