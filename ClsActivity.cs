using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    class ClsActivity
    {
        private String _ActivityID, _ActivityName, _MetricOne, _MetricTwo, _MetricThree;

        public String ActivityID
        {
            set { _ActivityID = value; }
            get { return _ActivityID; }
        }

        public String ActivityName
        {
            set { _ActivityName = value; }
            get { return _ActivityName; }
        }

        public String MetricOne
        {
            set { _MetricOne = value; }
            get { return _MetricOne; }
        }

        public String MetricTwo
        {
            set { _MetricTwo = value; }
            get { return _MetricTwo; }
        }

        public String MetricThree
        {
            set { _MetricThree = value; }
            get { return _MetricThree; }
        }
    }
}
