using System;
    public abstract class Goal
    {
        protected string _name, _description;
        protected int _points;
        protected bool _achieved;

        public Goal(string name, string description, int points, bool achieved = false)
        {
            _name = name;
            _description = description;
            _points = points;
            _achieved = achieved;

        }
        public abstract int RecordEvent();
        public void IsComplete()
        {
            _achieved = true;
        }
        public virtual void DisplayGoal() 
        {

            string checkBox = "[ ]";
            if (_achieved) 
            {
                checkBox ="[X]";
            }

            Console.WriteLine($"{checkBox} {_name} ({_description})");
        }
        public abstract string WriteInFile();
    }

    