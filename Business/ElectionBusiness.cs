using System;
using Data;
using Data.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Business
{
    public class ElectionBusiness
    {
        private ElectionContext electionContext;

        public List<Party> GetAll()
        {
            using (electionContext = new ElectionContext())
            {
                return electionContext.Parties.ToList();
            }
        }

        public Party Get(int id)
        {
            using (electionContext = new ElectionContext())
            {
                return electionContext.Parties.Find(id);
            }
        }

        public void Add(Party party)
        {
            using (electionContext = new ElectionContext())
            {
                electionContext.Parties.Add(party);
                electionContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (electionContext = new ElectionContext())
            {
                Party party = electionContext.Parties.Find(id);

                if (party != null)
                {
                    electionContext.Parties.Remove(party);
                    electionContext.SaveChanges();
                }
            }
        }

        public void Update(Party party)
        {
            using (electionContext = new ElectionContext())
            {
                Party item = electionContext.Parties.Find(party.ID);

                if (item != null)
                {
                    electionContext.Entry(item).CurrentValues.SetValues(party);
                    electionContext.SaveChanges();
                }
            }
        }        
    }
}