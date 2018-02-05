using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.Reflection;

namespace Model
{
    public class AgentClass:Agent
    {
       
#region CRUD

        public void AddAgent()
        {
            using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Agent agent = new Agent();
                agent.TravellerName =this.TravellerName;
                agent.TravellerLogo = this.TravellerLogo;
                agent.Address = this.Address;
                agent.FirstName = this.FirstName;
                agent.LastName = this.LastName;
                agent.MiddleName = this.MiddleName;
                agent.MobileNo = this.MobileNo;
                agent.AlternateMobileNo = this.AlternateMobileNo;
                agent.CityId = this.CityId;
                agent.Ratings = this.Ratings;
                agent.CreatedBy = this.CreatedBy;
                agent.CreatedDate = this.CreatedDate;
                agent.UpdatedBy = this.UpdatedBy;
                agent.UpdatedDate = this.UpdatedDate;
                agent.IsActive = this.IsActive;

                obj.Agents.Add(agent);
                obj.SaveChanges();

            }
        }

        public void DeleteAgent()
        {
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Agent agent = obj.Agents.Where(a => a.Id == this.Id).FirstOrDefault();
                agent.IsActive = IsActive;
                obj.SaveChanges();
            }
        }

        public void UpdateAgent()
        {
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Agent agent = obj.Agents.Where(a=> a.Id == this.Id).FirstOrDefault();
                agent.TravellerName = this.TravellerName;
                agent.TravellerLogo = this.TravellerLogo;
                agent.Address = this.Address;
                agent.FirstName = this.FirstName;
                agent.LastName = this.LastName;
                agent.MiddleName = this.MiddleName;
                agent.MobileNo = this.MobileNo;
                agent.AlternateMobileNo = this.AlternateMobileNo;
                agent.CityId = this.CityId;
                agent.Ratings = this.Ratings;
                agent.CreatedBy = this.CreatedBy;
                agent.CreatedDate = this.CreatedDate;
                agent.UpdatedBy = this.UpdatedBy;
                agent.UpdatedDate = this.UpdatedDate;
                agent.IsActive = this.IsActive;
                
                obj.SaveChanges();
            }
        }

        public List<AgentClass>GetAllAgent()
        {
            List<Agent> agentList=new List<Agent>();
            List<AgentClass> agentclasslist = new List<AgentClass>();
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                agentList=obj.Agents.ToList();
                foreach(var age in agentList)
                {
                    agentclasslist.Add((AgentClass)CopyProperties(age, this));
                }
            }
            return agentclasslist;
        }

        public object CopyProperties(object source, object destination)
        {
            PropertyInfo[] destinationProperties = destination.GetType().GetProperties();
            foreach (PropertyInfo destinationPi in destinationProperties)
            {
                PropertyInfo sourcePi = source.GetType().GetProperty(destinationPi.Name);
                destinationPi.SetValue(destination, sourcePi.GetValue(source, null), null);
            }
            return destination;
        }

#endregion

 #region Filtering
        public AgentClass GetByAgentId()
        {
            Agent agent=new Agent();
            AgentClass agentclass;
            using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                 agent = obj.Agents.Where(a => a.Id == this.Id).FirstOrDefault();
                agentclass= (AgentClass)CopyProperties(agent, this);
            }
            return agentclass;
        }
#endregion
    }
}

