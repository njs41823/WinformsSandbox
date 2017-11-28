using System;
using System.Windows.Forms;
using WinformsSandbox.Models.Classes;
using WinformsSandbox.Models.Interfaces;
using WinformsSandbox.ViewModels.Classes;
using WinformsSandbox.Views;

namespace WinformsSandbox
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Group group1 = Group.GetRandomGroup(20);
            Group group2 = Group.GetRandomGroup(30);
            IGroups groups = new Groups("Group of Groups!") { group1, group2 };
            Application.Run(new GroupsView(new GroupsViewModel(groups)));
        }
    }
}
