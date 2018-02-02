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

        public void DeleteCustomer()
        {
            using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Customer customer = obj.Customers.Where(c => c.Id == Id).FirstOrDefault();
                customer.IsActive = IsActive;
                obj.SaveChanges();
            }
        }

        public void UpdateCustomer()
        {
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Customer customer = obj.Customers.Where(c => c.Id == Id).FirstOrDefault();
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
        public Customer GetByCustomerId()
        {
            Customer customer = new Customer();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                customer = obj.Customers.Where(c => c.Id == Id).FirstOrDefault();
            }
            return customer;
        }
#endregion
    }
}
