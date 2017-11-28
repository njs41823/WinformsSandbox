using System.Windows.Forms;
using WinformsSandbox.ComponentModel;
using WinformsSandbox.Models.Interfaces;

namespace WinformsSandbox.ViewModels.Interfaces
{
    public interface IGroupsViewModel
    {
        IGroups Groups { get; set; }

        SortableBindingList<IGroup> GroupsBindingList { get; }

        SortableBindingList<IPerson> SelectedGroupBindingList { get; }

        void GroupsDataGrid_RowEnter(object sender, DataGridViewCellEventArgs e);
    }
}
