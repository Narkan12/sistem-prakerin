using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app_prakerin.Config;
using System.Windows.Forms;

namespace app_prakerin
{
    class Helper
    {
        //Kontrol Form
        public static void UntukForm(Form FormApa, Panel PanelApa)
        {
            PanelApa.Controls.Clear();
            FormApa.TopLevel = false;
            FormApa.FormBorderStyle = FormBorderStyle.None;
            FormApa.Dock = DockStyle.Fill;
            PanelApa.Controls.Add(FormApa);
            FormApa.Show();
        }

        //Kontrol Keychar
        public static void Pindah(params Control[] controls)
        {
            for (int i = 0; i < controls.Length - 1; i++)
            {
                int next = i + 1;

                controls[i].KeyDown += (s, e) =>
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        e.SuppressKeyPress = true;
                        controls[next].Focus();
                    }
                };
            }
        }
    }
}