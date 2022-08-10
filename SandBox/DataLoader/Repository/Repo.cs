using DataLoader.Models;
using System;

namespace DataLoader.Repository
{
    internal class Repo
    {
        private Model1 _model1;
        public Repo() {
            _model1 = new Model1();
        }

        public bool AddPhoneUseData(DateTime dateTimeOfUse, int useDataType, int usePhoneId, double useAmt) {
            DataUse du = new DataUse()
            {
                UseDate = dateTimeOfUse,
                UseDataType = useDataType,
                UsePhoneId = usePhoneId,
                UsedDataAmount = useAmt,
            };
            _model1.DataUses.Add(du);
                
            int alcatraz =  _model1.SaveChanges();
            bool success = false;
            return success;
        }
    }
}
