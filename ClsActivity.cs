using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    class ClsActivity
    {
        private string _ActivityID, _ActivityName, _MetricOne, _MetricTwo, _MetricThree;

        public string ActivityID
        {
            set { _ActivityID = value; }
            get { return _ActivityID; }
        }

        public string ActivityName
        {
            set { _ActivityName = value; }
            get { return _ActivityName; }
        }

        public string MetricOne
        {
            set { _MetricOne = value; }
            get { return _MetricOne; }
        }

        public string MetricTwo
        {
            set { _MetricTwo = value; }
            get { return _MetricTwo; }
        }

        public string MetricThree
        {
            set { _MetricThree = value; }
            get { return _MetricThree; }
        }
    }
}
