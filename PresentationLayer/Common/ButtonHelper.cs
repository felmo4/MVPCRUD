using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Common
{
    static public class ButtonHelper
    {
        static public void SetToBorderless(Button button)
        {
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;  
            button.FlatAppearance.MouseOverBackColor = button.BackColor;
            button.FlatAppearance.MouseDownBackColor = button.BackColor;

            button.MouseMove += new MouseEventHandler(OnBorderlessMouseMoveEventRaised);
            button.MouseLeave += new EventHandler(OnBorderlessMouseLeaveEventRaised);
        }

        static private void SetGroupToBorderless(List<Button> buttons)
        {
            foreach (Button btn in buttons)
            {
                SetToBorderless(btn);
            }
        }

        static private void OnBorderlessMouseMoveEventRaised (object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        static private void OnBorderlessMouseLeaveEventRaised (object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        static public void SetVisibilityOfButtons (List<Button> buttons, bool visibility, Label underlineLabel)
        {
            foreach (Button btn in buttons)
            {
                btn.Visible = visibility;
            }

            if(underlineLabel != null)
            {
                underlineLabel.Visible = visibility; 
            }
        }

    }
}
