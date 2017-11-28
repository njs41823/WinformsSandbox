using System.Collections.Generic;
using WinformsSandbox.Models.Interfaces;

namespace WinformsSandbox.Models.Classes
{
    public class Groups : List<IGroup>, IGroups
    {
        #region IGroups Implementation

        public string Name { get; set; }

        #endregion


        #region Constructor

        public Groups(string name)
        {
            Name = name;
        }

        #endregion
    }
}
