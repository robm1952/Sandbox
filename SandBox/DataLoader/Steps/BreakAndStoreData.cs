using System;
using DataLoader.Repository;

namespace DataLoader.Steps
{
    internal class BreakAndStoreData
    {
        public ReadIn ReadIn { get; set; }
        private ReadIn _ri;
        private Repo _rep;
        public BreakAndStoreData()
        {
            _ri = new ReadIn();
            _rep = new Repo();
        }

        public bool ProcessReadLines() {
            _ri.StartRead();
            bool success = false;
            
            string stringToSplit;
            stringToSplit = _ri.ReadInStrings[0];
            var sts = stringToSplit[6];
            var splitter = stringToSplit.Substring(6, 1);
            _ = _ri.ReadInStrings[0].Contains("split\t|") ? _ = _ri.ReadInStrings[0].Substring(6,1) : throw new Exception("Invalid Splitter");
            foreach (string str in _ri.ReadInStrings) {
                if (str.Contains("split")) {
                    continue;
                }
                var jessica = str.Split(new char[] {'|' }, StringSplitOptions.RemoveEmptyEntries);
                ProcessSplits(jessica);
            }
            return success;
        }

        private void ProcessSplits(string[] jessica)
        {
            string strdtOfUse = jessica[1];
            string timeOfUse = jessica[2];
            
            int year = int.Parse(strdtOfUse.Substring(6, 4));
            int month = int.Parse(strdtOfUse.Substring(0, 2));
            int day = int.Parse(strdtOfUse.Substring(3, 2));
            int hour = int.Parse(timeOfUse.Substring(0, 2));
            int minute = int.Parse(timeOfUse.Substring(3, 2)); 
            int second = int.Parse(timeOfUse.Substring(6, 2));
            
            DateTime dtOfUse = new DateTime(year,month,day,hour,minute,second);
            double useAmt = double.Parse(jessica[4]);
            
            _rep.AddPhoneUseData(dtOfUse,1,1,useAmt);
        }
    }
}
