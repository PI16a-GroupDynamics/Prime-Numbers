using System.ComponentModel;
using System.Windows.Forms;

namespace MetroFramework_test_at_a_new_project
{
    public partial class FormAboutProgram: Form
    {
        public FormAboutProgram()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
        }

        void ShowHelp(object o, CancelEventArgs e)
        {
            MessageBox.Show(@"Просто закройте это окно.");
        }

        private void htmlPanel1_Click(object sender, System.EventArgs e)
        {

        }
    }
}