using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class AgentBL:Agent
    {

       OnlineTicketBookingEntities obj;
       public AgentBL()
        {
            obj = new OnlineTicketBookingEntities();
        }
#region CRUD

        public void AddAgent(Agent agent)
        {
                obj.Agents.Add(agent);
                obj.SaveChanges();
        }

        public void DeleteAgent()
        {
                obj.SaveChanges();
        }

        public void UpdateAgent(Agent agent)
        {
                obj.SaveChanges();
        }

        public List<Agent>GetAllAgent()
        {
            List<Agent> agentList=new List<Agent>();
            agentList=obj.Agents.ToList();
            return agentList;
        }

#endregion

#region Filtering
        public Agent GetByAgentId()
        {
            Agent agent=new Agent();
            agent = obj.Agents.Where(a => a.Id == Id).FirstOrDefault();
            return agent;
        }
#endregion
    }
}

