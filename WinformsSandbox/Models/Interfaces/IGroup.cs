using System.Collections.Generic;

namespace WinformsSandbox.Models.Interfaces
{
    public interface IGroup : IList<IPerson>
    {
        string GroupName { get; }
    }
}
