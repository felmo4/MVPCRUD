using System.Windows.Forms;

namespace PresentationLayer.Presenters
{
    public interface IPetsListPresenter
    {
        void LoadAllPetsFromDbtoGrid();
        void DeletePetFromList(DataGridViewRow selectedRow);
    }
}