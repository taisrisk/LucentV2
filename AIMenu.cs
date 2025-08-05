using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucent_V2
{
    public partial class AIMenu : UserControl
    {
        public AIMenu()
        {
            InitializeComponent();
            SetupSimpleLayout();
        }
        
        private void SetupSimpleLayout()
        {
            
            // Enable basic Windows Forms scrolling on the hidden panel
            Hiddenpanel.AutoScroll = true;
            
            // Set the AutoScrollMinSize to ensure scrolling works
            // The guna2Panel1 is 455px tall, so we need at least that height
            Hiddenpanel.AutoScrollMinSize = new Size(0, 500);
        }
        
        // Method to add items to the content panel (no scrolling)
        public void AddMenuItem(Control menuItem)
        {
            Hiddenpanel.Controls.Add(menuItem);
        }
        
        // Property to access the content panel
        public Panel ContentPanel => Hiddenpanel;
    }
}
