using CommonComponents;
using PresentationLayer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MainView : Form, IMainView
    {
        public event EventHandler MainViewLoadedEventRaised;
        public event EventHandler HomeBtnClickEventRaised;
        public event EventHandler PetsListBtnClickEventRaised;
        public event EventHandler HelpAboutMenuClickEventRaised;

        //private Point _userControlPanelMovingLocation;
        //private int _userControlPanelTimerLoopCount = 0;
        //private const int _userControlPanelStretchIncrement = 55;
        //private const int _userControlPanelEndingStretchTopYPos = 60;

        //private Panel _userControlPanelOrigValues = null;

        //private List<Button> NavigationButtonList = null;

        public MainView()
        {
            InitializeComponent();
        }

        public void ShowMainView()
        {
            this.Show();
        }

        //public PictureBox GetUserInfoPictureBox() { }

        public Panel GetOptionsPanel()
        {
            return optionsPanel;
        }

        public void ResetUserControlPanelSizeandLocation()
        {
            //userControlPanel.Height = _user
        }

        public void LoadPetsListToGrid(BindingSource petsListBindingSource, Dictionary<string, string> headingsDictionary,
                                        Dictionary<string, float> gridColumnWidthsDictionary, int rowHeight)
        {
            this.petsListDGV.RowTemplate.Height = 32;
            this.petsListDGV.DataSource = petsListBindingSource;

            SetGridHeaderText(headingsDictionary);
            petsListDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            petsListDGV.ReadOnly = true;

            int optionsWidth = 0;
            SetGridColumnWidths(gridColumnWidthsDictionary, ref optionsWidth);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Options";
            imageColumn.Name = "Options";
            imageColumn.Width = optionsWidth;
            imageColumn.Image = Properties.Resources.options;

            if (petsListDGV.Columns["Options"] == null)
            {
                petsListDGV.Columns.Add(imageColumn);
            }
        }

        private void SetGridHeaderText(Dictionary<string,string> headingsDictionary)
        {
            petsListDGV.Columns["petID"].HeaderText = headingsDictionary["petID"];
            petsListDGV.Columns["petname"].HeaderText = headingsDictionary["petname"];
            petsListDGV.Columns["petbreed"].HeaderText = headingsDictionary["petbreed"];
            petsListDGV.Columns["petbday"].HeaderText = headingsDictionary["petbday"];

        }

        private void SetGridColumnWidths(Dictionary<string, float> gridColumnWidthsDictionary, ref int OptionsWidth)
        {
            int GridWidth = (petsListDGV.Width - petsListDGV.RowHeadersWidth - SystemInformation.VerticalScrollBarWidth);

            petsListDGV.Columns["petID"].Width = (int)((GridWidth) * gridColumnWidthsDictionary["petID"]);
            petsListDGV.Columns["petname"].Width = (int)((GridWidth) * gridColumnWidthsDictionary["petname"]);
            petsListDGV.Columns["petbreed"].Width = (int)((GridWidth) * gridColumnWidthsDictionary["petbreed"]);
            petsListDGV.Columns["petbday"].Width = (int)((GridWidth) * gridColumnWidthsDictionary["petbday"]);

            OptionsWidth = (int)((GridWidth) * gridColumnWidthsDictionary["Options"]);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void helpAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventHelpers.RaiseEvent(this, HelpAboutMenuClickEventRaised, e);
        }

        private void menuPB_Click(object sender, EventArgs e)
        {
            PictureBoxHelper.DisplayContextMenu(menuPB, moreOptionsCS, this);
        }

        private void petsBtn_Click(object sender, EventArgs e)
        {
            EventHelpers.RaiseEvent(this, PetsListBtnClickEventRaised, e);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            EventHelpers.RaiseEvent(this, HomeBtnClickEventRaised, e);
        }

        

    }
}
