using CommonComponents;
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
    public partial class PetsDetailView : Form, IPetsDetailView
    {
        public event EventHandler<AccessTypeEventArgs> PetsDetailSaveBtnClickEventRaised;

        public PetsDetailView()
        {
            InitializeComponent();
        }

        public void ShowPetsDetailView()
        {
            this.ShowDialog();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
