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
            this.Name = name;
            this.Gender1 = gender;
            Birthday = birthday;
            _members = new List<FamilyMember>();
        }

    #region Свойства_полей
    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public DateTime Birthday
    {
        get => _birthday;
    }

    public FamilyMember Father
    {
        get => _father;
        set => _father = value;
    }

    public FamilyMember Mother
    {
        get => _mother;
        set => _mother = value;
    }

    public Gender Gender
    {
        get => _gender;
        set => _gender = value;
    }
    #endregion

    public override string ToString()
        {
            return $"Имя = {Name}" +
                   $" \n Пол = {Gender1}\n" +
                   $"Дата рождения = {_birthday}";
        }
    }

