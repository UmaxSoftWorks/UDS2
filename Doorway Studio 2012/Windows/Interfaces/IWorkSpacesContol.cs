using System;

namespace Umax.Windows.Interfaces
{
    public interface IWorkSpacesContol
    {
        int SelectedWorkSpace { get; }

        void CreateWorkSpace(object sender, EventArgs e);
        void CopyWorkSpace(object sender, EventArgs e);
        void EditWorkSpace(object sender, EventArgs e);
        void DeleteWorkSpace(object sender, EventArgs e);
    }
}
