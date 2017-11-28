namespace WinformsSandbox.Views
{
    partial class GroupsView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectedGroupDataGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupsDataGrid = new System.Windows.Forms.DataGridView();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedGroupDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedGroupDataGrid
            // 
            this.SelectedGroupDataGrid.AllowUserToAddRows = false;
            this.SelectedGroupDataGrid.AllowUserToDeleteRows = false;
            this.SelectedGroupDataGrid.AllowUserToResizeRows = false;
            this.SelectedGroupDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedGroupDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PersonName});
            this.SelectedGroupDataGrid.Location = new System.Drawing.Point(278, 12);
            this.SelectedGroupDataGrid.MultiSelect = false;
            this.SelectedGroupDataGrid.Name = "SelectedGroupDataGrid";
            this.SelectedGroupDataGrid.ReadOnly = true;
            this.SelectedGroupDataGrid.RowHeadersVisible = false;
            this.SelectedGroupDataGrid.Size = new System.Drawing.Size(465, 325);
            this.SelectedGroupDataGrid.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // PersonName
            // 
            this.PersonName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PersonName.DataPropertyName = "Name";
            this.PersonName.HeaderText = "Name";
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            // 
            // GroupsDataGrid
            // 
            this.GroupsDataGrid.AllowUserToAddRows = false;
            this.GroupsDataGrid.AllowUserToDeleteRows = false;
            this.GroupsDataGrid.AllowUserToResizeRows = false;
            this.GroupsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupName});
            this.GroupsDataGrid.Location = new System.Drawing.Point(12, 12);
            this.GroupsDataGrid.MultiSelect = false;
            this.GroupsDataGrid.Name = "GroupsDataGrid";
            this.GroupsDataGrid.ReadOnly = true;
            this.GroupsDataGrid.RowHeadersVisible = false;
            this.GroupsDataGrid.Size = new System.Drawing.Size(260, 325);
            this.GroupsDataGrid.TabIndex = 3;
            // 
            // GroupName
            // 
            this.GroupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GroupName.DataPropertyName = "GroupName";
            this.GroupName.HeaderText = "Group Name";
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            // 
            // GroupsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 349);
            this.Controls.Add(this.SelectedGroupDataGrid);
            this.Controls.Add(this.GroupsDataGrid);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GroupsView";
            this.Text = "GroupsView";
            ((System.ComponentModel.ISupportInitialize)(this.SelectedGroupDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SelectedGroupDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridView GroupsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
    }
}