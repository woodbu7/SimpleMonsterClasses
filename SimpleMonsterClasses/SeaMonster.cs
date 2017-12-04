using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMonsterClasses
{

    public class SeaMonster
    {
        public enum EmotionalState
        {
            HAPPY,
            SAD,
            ANGRY,
            MEAN
        }

        #region Fields

        private string _name;
        private string _color;
        private int _size; // length in meters
        private bool _livesInSaltWater;
        private DateTime _dateTime;
        private EmotionalState _emotion;

        #region Properties

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public bool LivesInSaltWater
        {
            get { return _livesInSaltWater; }
            set { _livesInSaltWater = value; }
        }

        public DateTime Birthdate
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }

        public EmotionalState Emotion
        {
            get { return _emotion; }
            set { _emotion = value; }
        }

        #endregion

        #endregion

        #region Constructors

        public SeaMonster() // default constructors, method signature
        {

        }

        public SeaMonster(string name, string color) // overloading: method with same name, but different parameters
        {
            _name = name; // underscores are used to recognize fields
            _color = color;
        }

        #endregion

        #region Methods

        public string Greeting()
        {
            string greeting = "";

            switch (_emotion)
            {
                case EmotionalState.HAPPY:
                    greeting = "Hello, I am a Sea Monster!";
                    break;
                case EmotionalState.SAD:
                    greeting = "Hi, I need a hug";
                    break;
                case EmotionalState.ANGRY:
                    greeting = "Get away from me!";
                    break;
                case EmotionalState.MEAN:
                    greeting = "I am a Sea Monster! I will eat you!";
                    break;
                default:
                    break;
            }

            return greeting;
        }

        #endregion





    }
}
