using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree;

public class FamilyMember: Person
{
    private FamilyMember? _father;
    private FamilyMember? _mother;
    private List<FamilyMember> _childrenList;
    private FamilyMember? _wife;
    private FamilyMember? _husband;

    public FamilyMember(string name, DateTime birthday, Gender gender): base(name, birthday, gender)
    {
        this._name = name;
        this._gender = gender;
        this._birthday = birthday;
        _childrenList = new List<FamilyMember>();//для будущего вывода целого древа
    }

    #region Свойства_полей

    

    public FamilyMember? Father
    {
        get => _father;
        set => _father = value;
    }

    public FamilyMember? Mother
    {
        get => _mother;
        set => _mother = value;
    }

    public FamilyMember? Wife
    {
        get => _wife;
        set => _wife = value;
    }

    public FamilyMember? Husband
    {
        get => _husband;
        set => _husband = value;
    }

    #endregion

    public override string ToString()
    {
        return $"Name = {_name} Пол = {_gender} Birthday = {_birthday.ToLongDateString()}";
    }



    public string GetParents()
    {
        return $"Родители {_name}:\n " +
               $"Father = {_father?.Name} \n" +
               $"Moter = {_mother?.Name}";
    }

    public string GetCloseRelative()
    {
        if (this._gender == Gender.Female)
            return $"{this.Name} 's husband is {this.Husband?.Name}";
        else
        {
            return $"{this.Name} 's wife is {this.Wife?.Name}";
        }
    }

}