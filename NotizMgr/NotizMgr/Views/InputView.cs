using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NotizMgr.Data.Element;

namespace NotizMgr.Views
{
    public partial class InputView : Form
    {
        public Data.Element m_cElement { get; private set; }
        InputViewModel m_cInput { get; set; }
        
        public InputView(eElementType l_eType)
        {
            InitializeComponent();
            m_cInput = new InputViewModel(l_eType);
            SetCaption();
        }

        private void SetCaption()
        {
            lblCaption.Text = m_cInput.GetElementType();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            m_cElement = m_cInput.CreateElement(txtContent.Text);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
