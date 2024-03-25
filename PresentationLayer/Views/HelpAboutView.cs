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

namespace PresentationLayer.Views
{
    public partial class HelpAboutView : Form, IHelpAboutView
    {

        public event EventHandler HelpAboutViewLoadEventRaised;
        public HelpAboutView()
        {
            InitializeComponent();
        }

        public void SetAboutValues(string windowTitle,
                                    string productName,
                                    string version,
                                    string copyright,
                                    string companyName,
                                    string description)
        {
            this.Text = windowTitle;
            this.productLbl.Text = productName;
            this.versionLbl.Text = version;
            this.copyrightLbl.Text = copyright;
            this.CompanyLbl.Text = companyName;
            this.descriptionLbl.Text = description;
        }

        private void HelpAboutView_Load(object sender, EventArgs e)
        {
            FormHelper.SetDialogAppearance(this);
            EventHelpers.RaiseEvent(this, HelpAboutViewLoadEventRaised, e);
        }

        public void ShowHelpAboutView()
        {
            this.ShowDialog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
