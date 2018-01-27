using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostageCalculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            output();
        }

        protected void handle (object sender, EventArgs e)
        {
            output();
        }

        private void output()
        {
            if (!valuesExist()) return;

            int volume = 0;
            if (!inputVolume(out volume)) return;

            double postageMultiplier = getPostageMultiplier();

            double cost = volume * postageMultiplier;

            resultLabel.Text = string.Format("Your parcel will cost {0:C} to ship.", cost);
        }
        private bool valuesExist()
        {
            if (!airRadio.Checked && !groundRadio.Checked && !nextDayRadio.Checked) return false;
            if (widthTextBox.Text.Trim().Length == 0 || heightTextBox.Text.Trim().Length == 0) return false;
            return true;
        }
        private bool inputVolume(out int volume)
        {
            volume = 0;
            int width = 0;
            int height = 0;
            int length = 0;

            if (!int.TryParse(widthTextBox.Text.Trim(), out width)) return false;
            if (!int.TryParse(heightTextBox.Text.Trim(), out height)) return false;
            if (!int.TryParse(lengthTextBox.Text.Trim(), out length)) length = 1;

            volume = width * height * length;

            return true;
        }
        private double getPostageMultiplier()
        {
            if (groundRadio.Checked) return .15;
            else if (airRadio.Checked) return .25;
            else if (nextDayRadio.Checked) return .45;
            else return 0;
        }
    }
}