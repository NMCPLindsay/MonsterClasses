using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    public abstract class Monster
    {
        public enum Types
        {
            Fire,
            Earth,
            Wind,
            Water
        }

        private int _id;
        private Types _type;
        private double _level;
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public double Level
        {
            get { return _level; }
            set { _level = value; }
        }


        public Types Type
        {
            get { return _type; }   
            set { _type = value; }
        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


    }
}
