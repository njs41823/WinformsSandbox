using WinformsSandbox.Models.Interfaces;

namespace WinformsSandbox.Models.Classes
{
    public class Person : IPerson
    {
        #region IPerson Implementation

        public int Id { get; }
        
        public string Name { get; }

        #endregion


        #region Constructor

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        #endregion
    }
}
