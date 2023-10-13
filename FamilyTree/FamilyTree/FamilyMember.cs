using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree;

    public class FamilyMember
    {

        private string _name;
        private DateTime _birthday;
        private FamilyMember _father;
        private FamilyMember _mother;
        private Gender _gender;
        private List<FamilyMember> _members;

        public FamilyMember(string name, DateTime birthday,Gender gender)
        {
            this._name = name;
            this._gender = gender;
            _birthday = birthday;
            _members = new List<FamilyMember>();
        }

        public override string ToString()
        {
            return $"Имя = {_name}" +
                   $" \n Пол = {_gender}\n" +
                   $"Дата рождения = {_birthday}";
        }
    }

