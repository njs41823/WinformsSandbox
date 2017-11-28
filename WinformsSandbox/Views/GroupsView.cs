using System.Windows.Forms;
using WinformsSandbox.ViewModels.Interfaces;

namespace WinformsSandbox.Views
{
    public partial class GroupsView : Form
    {
        public GroupsView(IGroupsViewModel groupsViewModel)
        {
            InitializeComponent();
            GroupsViewModel = groupsViewModel;
        }

        private IGroupsViewModel _groupsViewModel;
        public IGroupsViewModel GroupsViewModel
        {
            get => _groupsViewModel;
            set
            {
                _groupsViewModel = value;
                if (_groupsViewModel != null) { Bind(); }
            }
        }

        private void Bind()
        {
            GroupsDataGrid.DataBindings.Clear();
            GroupsDataGrid.AutoGenerateColumns = false;
            GroupsDataGrid.DataBindings.Add(new Binding("DataSource", GroupsViewModel, "GroupsBindingList"));

            SelectedGroupDataGrid.DataBindings.Clear();
            SelectedGroupDataGrid.AutoGenerateColumns = false;
            SelectedGroupDataGrid.DataBindings.Add(new Binding("DataSource", GroupsViewModel, "SelectedGroupBindingList"));

            GroupsDataGrid.RowEnter -= GroupsViewModel.GroupsDataGrid_RowEnter;
            GroupsDataGrid.RowEnter += GroupsViewModel.GroupsDataGrid_RowEnter;
        }

    }
}
