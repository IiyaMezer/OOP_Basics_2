using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree;

    public class Person
    {
        internal string _name;
        internal DateTime _birthday;
        internal Gender _gender;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public DateTime Birthday => _birthday;
        public Gender Gender
        {
            get => _gender;
            set => _gender = value;
        }

        public Person(string name, DateTime birthday, Gender gender) 
        {
            this._name = name;
            this._gender = gender;
            this._birthday = birthday;
            
        }

    }

