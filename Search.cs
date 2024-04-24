using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactBook
{
    public partial class Search : Form
    {
        int CollapsedPanelHeight;
        public Search()
        {
            InitializeComponent();
            CollapsedPanelHeight = this.splitContainer1.Panel2.Height;
            this.Height -= CollapsedPanelHeight;
            this.splitContainer1.Panel2Collapsed = true;
        }

        private void collapse(object sender, EventArgs e)
        {
            if (this.splitContainer1.Panel2Collapsed)
            {
                this.splitContainer1.Panel2Collapsed = false;
                this.Height += CollapsedPanelHeight;
            }
            else
            {
                this.splitContainer1.Panel2Collapsed = true;
                this.Height -= CollapsedPanelHeight;
            }
        }
    }
}
