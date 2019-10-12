using System;
using System.Windows.Forms;

namespace csNumberChecker
{
    public partial class FormCheckers : Form
    {
        public FormCheckers()
        {
            InitializeComponent();
        }

        private void bCheckBankBE_Click(object sender, EventArgs e)
        {
            lResult.Text = BankOk(tbBEBankAccount.Text, cbSepa.Checked, cbWithSpaces.Checked);
        }

        private string BankOk(string anyRekString, bool sepaFlag, bool returnFormatted)
        {
            int rekLength = anyRekString.Length;
            long dPip;
            int dPip2;
            long calcPip;

            bool inputIsSepa;

            string rekOld;
            string rekSepa = "";

            switch (rekLength)
            {
                case 12:
                    inputIsSepa = false;
                    rekOld = anyRekString;
                    break;

                case 14:
                    inputIsSepa = false;
                    rekOld =
                        anyRekString.Substring(0, 3) +
                        anyRekString.Substring(4, 7) +
                        anyRekString.Substring(12, 2);
                    break;

                case 16:
                    inputIsSepa = true;
                    rekSepa = anyRekString;
                    rekOld = rekSepa.Substring(4, 12);
                    break;

                case 19:
                    inputIsSepa = true;
                    rekSepa =
                        anyRekString.Substring(0, 4) +
                        anyRekString.Substring(5, 4) +
                        anyRekString.Substring(10, 4) +
                        anyRekString.Substring(15, 4);
                    rekOld = rekSepa.Substring(4, 12);
                    break;

                default:
                    return "invalid";
            }

            // first check if rekOld is valid
            dPip = long.Parse(rekOld.Substring(0, 10));
            dPip2 = int.Parse(rekOld.Substring(10, 2));
            calcPip = dPip - (dPip / 97 * 97);

            if (rekOld.Substring(10, 2) == "00")
            {
                return "invalid";
            }
            else if (calcPip == 0 && (rekOld.Substring(10, 2) == "97"))
            {
                // ok
            }
            else if (calcPip == dPip2)
            {
                // ok
            }
            else
            {
                return "invalid";
            }

            // then check if sepa version is needed
            if (!sepaFlag)
            {
                if (!returnFormatted )
                {
                    return rekOld;
                }
                else
                {
                    rekOld =
                        rekOld.Substring(0, 3) + " " +
                        rekOld.Substring(3, 7) + " " +
                        rekOld.Substring(10, 2);
                    return rekOld;
                }
            }
            else
            {
                if (!inputIsSepa)
                {
                    rekSepa = "BE00" + rekOld;
                }
                else if (!(rekSepa.Substring(0, 2) == "BE"))
                {
                    return "invalid";
                }

                // dPip = Val(Mid(rekOldString, 11, 2) + Mid(rekOldString, 11, 2) + "111400")
                dPip = long.Parse(rekOld.Substring(10, 2) + rekOld.Substring(10, 2) + "111400");
                calcPip = dPip - (dPip / 97 * 97);
                
                if (!inputIsSepa)
                {
                    rekSepa = rekSepa.Remove(2, 2).Insert(2, (98 - calcPip).ToString("00"));
                    // s = s.Remove(3, 2).Insert(3, "ZX");
                }

                dPip2 = int.Parse(rekSepa.Substring(2, 2));
                if (!((98 - calcPip) == dPip2))
                {
                    return "invalid";
                }

                if (!returnFormatted ){
                    return rekSepa;
                }
                else
                {
                    rekSepa =
                        rekSepa.Substring(0, 4) + " " +
                        rekSepa.Substring(4, 4) + " " +
                        rekSepa.Substring(8, 4) + " " +
                        rekSepa.Substring(12, 4);
                    return rekSepa;
                }
            }
        }
    }
}
