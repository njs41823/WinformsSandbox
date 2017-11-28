using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using WinformsSandbox.ComponentModel;
using WinformsSandbox.Models.Interfaces;
using WinformsSandbox.ViewModels.Interfaces;

namespace WinformsSandbox.ViewModels.Classes
{
    public class GroupsViewModel : IGroupsViewModel, INotifyPropertyChanged
    {
        public GroupsViewModel(IGroups groups)
        {
            Groups = groups;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private IGroups _groups;
        public IGroups Groups
        {
            get => _groups;
            set
            {
                _groups = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Groups"));
                GroupsBindingList = new SortableBindingList<IGroup>(_groups);
            }
        }

        #region Read Only Properties

        private SortableBindingList<IGroup> _groupsBindingList;
        public SortableBindingList<IGroup> GroupsBindingList
        {
            get => _groupsBindingList;
            private set
            {
                _groupsBindingList = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GroupsBindingList"));
                if (SelectedGroupBindingList == null) { SelectedGroupBindingList = new SortableBindingList<IPerson>(new List<IPerson>()); }
                SelectedGroupBindingList.Clear();
                if (_groupsBindingList != null && _groupsBindingList.Count > 0)
                {
                    SelectedGroupBindingList = new SortableBindingList<IPerson>(_groupsBindingList[0]);
                }
            }
        }

        private SortableBindingList<IPerson> _selectedGroupBindingList;
        public SortableBindingList<IPerson> SelectedGroupBindingList
        {
            get => _selectedGroupBindingList;
            private set
            {
                _selectedGroupBindingList = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedGroupBindingList"));
            }
        }

        #endregion

        public void GroupsDataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView groupsDataGrid = (DataGridView) sender;
            if (e.RowIndex < 0 || e.RowIndex >= groupsDataGrid.RowCount) { return; }
            if (!(groupsDataGrid.Rows[e.RowIndex].DataBoundItem is IGroup selectedGroup)) { return; }
            SelectedGroupBindingList = new SortableBindingList<IPerson>(selectedGroup);
        }
    }
}