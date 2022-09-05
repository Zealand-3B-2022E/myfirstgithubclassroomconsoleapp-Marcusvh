using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    internal class Demo
    {
        private int _id;
        private int _number;
        private string _name;
        private string _description;

        public Demo()
        {
            _id = 0;
            _number = 0;
            _name = "";
            _description = "";
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
            }
        }
    }
}
