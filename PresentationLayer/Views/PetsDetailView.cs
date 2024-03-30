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
using System.Windows.Forms.VisualStyles;

namespace PresentationLayer.Views
{
    public partial class PetsDetailView : Form, IPetsDetailView
    {
        private AccessTypeEventArgs _accessTypeEventArgs;
        public event EventHandler<AccessTypeEventArgs> PetsDetailSaveBtnClickEventRaised;
        public event EventHandler PetsDetailCancelBtnClickEventRaised;

        public void ShowPetsDetailView()
        {
            this.ShowDialog();
        }

        public AccessTypeEventArgs AccessTypeEventArgs
        {
            get { return _accessTypeEventArgs; }
            set
            {
                if (value == _accessTypeEventArgs) return;
                _accessTypeEventArgs = value;
            }
        }
        public PetsDetailView()
        {
            InitializeComponent();
            _accessTypeEventArgs = new AccessTypeEventArgs();
        }

        public void SetUpPetsDetailView(Dictionary<string, Binding> bindingDictionary,
                                          AccessTypeEventArgs accessTypeEventArgs)
        {
            BindPetsModelToView(bindingDictionary);
            _accessTypeEventArgs = accessTypeEventArgs;
        }

        public void BindPetsModelToView(Dictionary<string, Binding> bindingDictionary)
        {
            ClearExistingBindings();
            petIDTxtB.DataBindings.Add(bindingDictionary["PetID"]);
            petnameTxtB.DataBindings.Add(bindingDictionary["PetName"]);
            petbreedTxtB.DataBindings.Add(bindingDictionary["PetBreed"]);
            petbdayDateP.DataBindings.Add(bindingDictionary["PetBday"]);
            //IdTextInputUC.InputBoxDataBindings.Add(bindingDictionary["DepartmentId"]);

        }

        public void ClearExistingBindings()
        {
            petIDTxtB.DataBindings.Clear();
            petnameTxtB.DataBindings.Clear();
            petbreedTxtB.DataBindings.Clear();
            petbdayDateP.DataBindings.Clear();
            //IdTextInputUC.InputBoxDataBindings.Clear();

        }

        //public string GetPetID() { return this.petIDTxtB.Text; }

        //public string GetPetname() { return this.petnameTxtB.Text; }

        //public string GetPetbreed() { return this.petbreedTxtB.Text; }

        //public string GetPetbday() { return this.petbdayDateP.Value.ToString(); }


        private void addBtn_Click(object sender, EventArgs e)
        {
            EventHelpers.RaiseEvent(this, PetsDetailSaveBtnClickEventRaised, (AccessTypeEventArgs)_accessTypeEventArgs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventHelpers.RaiseEvent(this, PetsDetailCancelBtnClickEventRaised, e);
        }

        private void PetsDetailView_Load(object sender, EventArgs e)
        {
            petIDTxtB.ReadOnly = true;
            if (petnameTxtB.Text == string.Empty)
            {
                petIDTxtB.Visible = false;
            }
        }
    }
}
