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
        private AccessTypeEventArgs _accessType = new AccessTypeEventArgs();


        public PetsDetailView()
        {
            InitializeComponent();
        }

        public void ShowPetsDetailView()
        {
            ClearTextBoxes();
            petnameTxtB.Focus();
            this.ShowDialog();
        }

        public void ShowPetsDetailViewEdit(DataGridViewRow selectedRow)
        {           
            petIDTxtB.Text = selectedRow.Cells["petID"].Value.ToString();
            petnameTxtB.Text = selectedRow.Cells["petname"].Value.ToString();
            petbreedTxtB.Text = selectedRow.Cells["petbreed"].Value.ToString();
            petbdayDTPicker.Text = selectedRow.Cells["petbday"].Value.ToString();
            this.ShowDialog();
        }

        public int GetPetID() { return int.Parse(petIDTxtB.Text); }
        public string GetPetName() { return petnameTxtB.Text; }
        public string GetPetBreed() { return petbreedTxtB.Text; }
        public string GetPetBday() { return petbdayDTPicker.Value.ToString("yyyy-MM-dd"); }

        public void ClosePetsDetailView() { Close(); }


        private void addBtn_Click(object sender, EventArgs e)
        {
            EventHelpers.RaiseEvent(this, PetsDetailSaveBtnClickEventRaised, _accessType);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClosePetsDetailView();
        }

        private void PetsDetailView_Load(object sender, EventArgs e)
        {
            
            if (petIDTxtB.Text == string.Empty)
            {
                _accessType.AccessTypeValue = AccessTypeEventArgs.AccessType.Add;
            }
            else
            {
                _accessType.AccessTypeValue = AccessTypeEventArgs.AccessType.Edit;
            }
        }

        private void ClearTextBoxes()
        {
            petIDTxtB.Clear();
            petnameTxtB.Clear();
            petbreedTxtB.Clear();
            petbdayDTPicker.Value = DateTime.Now;
        }
    }
}
