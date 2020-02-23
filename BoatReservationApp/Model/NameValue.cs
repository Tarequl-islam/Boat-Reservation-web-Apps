using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatReservationApp.Model
{

    public class NameValue
    {

        private string dataName;
        private int dataValue;

        public NameValue(string dataName, int dataValue)
        {
            DataName = dataName;
            DataValue = dataValue;
        }

        public string DataName
        {
            get { return dataName; }
            set { dataName = value; }
        }

        public int DataValue
        {
            get { return dataValue; }
            set { dataValue = value; }
        }

        public override string ToString()
        {
            return dataName;
        }

    }
}
