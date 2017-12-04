using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMonsterClasses
{
    public class Ghost
    {
        #region Fields

        private string _name;
        private int _numberOfEyes;
        private DateTime dateTime;
        private bool _isDangerous;
        private bool _isVisible;

        #endregion

        #region Properties

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int NumberOfEyers
        {
            get { return _numberOfEyes; }
            set { _numberOfEyes = value; }
        }

        public bool IsDangerous
        {
            get { return _isDangerous; }
            set { _isDangerous = value; }
        }

        public bool IsVisible
        {
            get { return _isVisible; }
            set { _isVisible = value; }
        }

        public DateTime TimeOfDeath
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        #endregion

        #region Constructors

        public Ghost()
        {

        }

        #endregion
    }
}
