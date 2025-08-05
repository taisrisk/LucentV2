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
            
            // Enable double buffering on the AIMenu itself for smoother rendering
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.UserPaint |
                         ControlStyles.DoubleBuffer |
                         ControlStyles.ResizeRedraw |
                         ControlStyles.OptimizedDoubleBuffer, true);
            
            this.UpdateStyles();
            
            SetupSimpleLayout();
        }
        
        private void SetupSimpleLayout()
        {
            // Calculate the actual content height needed
            int maxBottom = 0;
            
            // Check all controls in the guna2Panel1 to find the real bottom
            foreach (Control panel in guna2Panel1.Controls)
            {
                if (panel.Visible)
                {
                    maxBottom = Math.Max(maxBottom, panel.Bottom);
                }
            }
            
            // Add padding for smooth scrolling
            int contentHeight = maxBottom + 50; // Add 50px padding at bottom
            
            // Set the guna2Panel1 height to accommodate all content
            guna2Panel1.Size = new Size(guna2Panel1.Width, contentHeight);
            
            // Enable scrolling on both hidden panels
            Hiddenpanel.AutoScroll = true;
            hiddenScrollPanel1.AutoScroll = true;
            
            // Set proper AutoScrollMinSize for the scrollable content
            hiddenScrollPanel1.AutoScrollMinSize = new Size(0, contentHeight);
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
