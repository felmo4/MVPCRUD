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

        private Point _userControlPanelMovingLocation;
        private int _userControlPanelTimerLoopCount = 0;
        private const int _userControlPanelStretchIncrement = 55;
        private const int _userControlPanelEndingStretchTopYPos = 60;

        private Panel _userControlPanelOrigValues = null;

        private List<Button> NavigationButtonList = null;

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
    }
}
