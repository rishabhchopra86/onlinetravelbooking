﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class OnlineTicketBookingEntities : DbContext
    {
        public OnlineTicketBookingEntities()
            : base("name=OnlineTicketBookingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<Aminity> Aminities { get; set; }
        public virtual DbSet<AvailableSeat> AvailableSeats { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<BookingDetail> BookingDetails { get; set; }
        public virtual DbSet<BookingStatu> BookingStatus { get; set; }
        public virtual DbSet<Cancel> Cancels { get; set; }
        public virtual DbSet<Cinema> Cinemas { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<ContactU> ContactUs { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Fare> Fares { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Master> Masters { get; set; }
        public virtual DbSet<MasterValue> MasterValues { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<PackageDetail> PackageDetails { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Screen> Screens { get; set; }
        public virtual DbSet<ScreenFare> ScreenFares { get; set; }
        public virtual DbSet<ScreenMaster> ScreenMasters { get; set; }
        public virtual DbSet<ScreenMovie> ScreenMovies { get; set; }
        public virtual DbSet<SeatDesign> SeatDesigns { get; set; }
        public virtual DbSet<SeatDesignDetail> SeatDesignDetails { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Station> Stations { get; set; }
        public virtual DbSet<Transport> Transports { get; set; }
        public virtual DbSet<TransportDetail> TransportDetails { get; set; }
        public virtual DbSet<User> Users { get; set; }
    
    
        public virtual ObjectResult<Procedure_Result> Procedure()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Procedure_Result>("Procedure");
        }
    
        public virtual ObjectResult<GetScreenMovieDetails_Result> GetScreenMovieDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetScreenMovieDetails_Result>("GetScreenMovieDetails");
        }
    }
}
