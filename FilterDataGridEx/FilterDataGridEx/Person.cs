using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace FilterDataGridEx
{
    public class Skill
    {
        public int Years { get; set; }
        public string Name { get; set; }
    }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public List<Skill> SkillList { get; set; }
    }
    public class Persons : ObservableCollection<Person>
    {
        public Persons()
        {
            Add(new Person() { Id = 1, Name = "Person1", Position = "Manager", SkillList = new List<Skill>() });
            Add(new Person() { Id = 2, Name = "Programmer2", Position = "Programmer", SkillList = new List<Skill>() });
            Add(new Person() { Id = 3, Name = "Person3", Position = "Programmer", SkillList = new List<Skill>() });
            Add(new Person() { Id = 4, Name = "Person4", Position = "Admin", SkillList = new List<Skill>() });
            Add(new Person() { Id = 5, Name = "Person5", Position = "Tester", SkillList = new List<Skill>() });
        }
    }
}
