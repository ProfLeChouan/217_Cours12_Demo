using Devoir6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Calculatrice : Form
    {
        //1-décalrer une instance de calcule
        Calcul unCalcul;
        public Calculatrice()
        {
            InitializeComponent();
            //2-initialiser unCalcul
            unCalcul = new Calcul();
            //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.checkedlistbox?view=netframework-4.8
            // https://docs.microsoft.com/en-us/dotnet/api/system.enum.getnames?view=netframework-4.8
            //3-populer les checkbox
            checkedListOperation.Items.AddRange(Enum.GetNames(typeof(OperationType)));
            
        }

        private void checkedListOperation_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                unCalcul.AjouterOp((OperationType)e.Index);
            }

            if (e.NewValue == CheckState.Unchecked)
            {
                unCalcul.RetirerOp((OperationType)e.Index);
            }
            lblResultat.Text = unCalcul.GetMesCalculs();
        }
    }
}
