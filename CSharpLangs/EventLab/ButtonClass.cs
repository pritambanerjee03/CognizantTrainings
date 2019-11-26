using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLab
{
    public delegate void ButtonClickHandler();
    class ButtonClass
    {
        public event ButtonClickHandler ButtonClicked;
        public void SimulateClick()
        {
            if (ButtonClicked == null)
            {
                ButtonClicked();

            }
        }
    }
}
