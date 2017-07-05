using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryFarmWorkTest
{
    public class CourseLeadersView : ViewModelBase
    {
        private int _id;
        private int _sclappno;
        private string _coursecode;
        private string _schoolname;

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        public int SCLAppNo
        {
            get
            {
                return _sclappno;
            }
            set
            {
                _sclappno = value;
                OnPropertyChanged();
            }
        }

        public string CourseCode
        {
            get { return _coursecode; }
            set
            {
                _coursecode = value;
                OnPropertyChanged();
            }
        }
        public string SchoolName
        {
            get { return _schoolname; }
            set
            {
                _schoolname = value;
                OnPropertyChanged();
            }
        }
    }
}
