using S2CDataMigration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2CDataMigration.Web.Domain
{
    public class PracticeService : IPracticeService
    {
        private IGentuUow GentuUow { get; set; }
        private HashSet<string> ValidationMessages { get; set; }
        public PracticeService(IGentuUow gentuUow)
        {
            this.GentuUow = gentuUow;
            ValidationMessages = new HashSet<string>();
        }

        public IEnumerable<Practices> Get()
        {
            return GentuUow.Repository<Practices>().All();

        }
        public Practices Get(Guid id) => GentuUow.Repository<Practices>().SingleOrDefault(t => t.Id == id);


        public HashSet<string> AddValidation(Practices practice)
        {
            CommonValidation(practice);
            return ValidationMessages;
        }

        public Practices Add(Practices practice)
        {
            GentuUow.RegisterNew<Practices>(practice);
            GentuUow.Commit();
            return practice;
        }
        public HashSet<string> UpdateValidation(Practices practice)
        {
            CommonValidation(practice);
            return ValidationMessages;
        }

        public Practices Update(Practices practice)
        {
            GentuUow.RegisterDirty<Practices>(practice);
            GentuUow.Commit();
            return practice;
        }

        public HashSet<string> DeleteValidation(Guid id)
        {
            return ValidationMessages;
        }

        public void Delete(Guid id)
        {
            var practice = GentuUow.Repository<Practices>().FindBy(x=>x.Id == id).FirstOrDefault();
         
            if (practice != null)
            {
                GentuUow.RegisterDeleted<Practices>(practice);
                GentuUow.Commit();
            }
        }

        private void CommonValidation(Practices practice)
        {

        }
    }
    public interface IPracticeService
    {
        IEnumerable<Practices> Get();
        Practices Get(Guid id);

        HashSet<string> AddValidation(Practices practice);
        HashSet<string> UpdateValidation(Practices practice);

        Practices Add(Practices practice);
        Practices Update(Practices practice);
        HashSet<string> DeleteValidation(Guid id);
        void Delete(Guid id);
    }
}
