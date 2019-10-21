using S2CDataMigration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2CDataMigration.Web.Domain
{
    public class PatientService : IPatientService
    {
        private IGentuUow GentuUow { get; set; }
        private HashSet<string> ValidationMessages { get; set; }
        public PatientService(IGentuUow gentuUow)
        {
            this.GentuUow = gentuUow;
            ValidationMessages = new HashSet<string>();
        }

        public IEnumerable<Patients> Get()
        {
            return GentuUow.Repository<Patients>().All();

        }
        public Patients Get(Guid id) => GentuUow.Repository<Patients>().SingleOrDefault(t => t.Id == id);


        public HashSet<string> AddValidation(Patients patient)
        {
            CommonValidation(patient);
            return ValidationMessages;
        }

        public Patients Add(Patients patient)
        {
            GentuUow.RegisterNew<Patients>(patient);
            GentuUow.Commit();
            return patient;
        }
        public HashSet<string> UpdateValidation(Patients patient)
        {
            CommonValidation(patient);
            return ValidationMessages;
        }

        public Patients Update(Patients patient)
        {
            GentuUow.RegisterDirty<Patients>(patient);
            GentuUow.Commit();
            return patient;
        }

        public HashSet<string> DeleteValidation(Guid id)
        {
            return ValidationMessages;
        }

        public void Delete(Guid id)
        {
            var patient = GentuUow.Repository<Patients>().FindBy(x=>x.Id == id).FirstOrDefault();
         
            if (patient != null)
            {
                GentuUow.RegisterDeleted<Patients>(patient);
                GentuUow.Commit();
            }
        }

        private void CommonValidation(Patients patient)
        {

        }
    }
    public interface IPatientService
    {
        IEnumerable<Patients> Get();
        Patients Get(Guid id);

        HashSet<string> AddValidation(Patients patient);
        HashSet<string> UpdateValidation(Patients patient);

        Patients Add(Patients patient);
        Patients Update(Patients patient);
        HashSet<string> DeleteValidation(Guid id);
        void Delete(Guid id);
    }
}
