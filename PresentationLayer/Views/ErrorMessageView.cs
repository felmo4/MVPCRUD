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
    public partial class ErrorMessageView : Form, IErrorMessageView
    {
        public ErrorMessageView()
        {
            InitializeComponent();
        }

        public void ShowErrorMessageView(string windowTitle, string errorMessage)
        {
            this.Text = windowTitle;
            this.messageTxtBox.Text = errorMessage;
            this.ShowDialog();
            this.Close();
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            if (messageTxtBox.Text != "")
            {
                System.Windows.Forms.Clipboard.SetText(messageTxtBox.Text);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
