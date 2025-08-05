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
    public partial class Form1 : Form
    {
        private UserControl currentMenu;
        
        public Form1()
        {
            InitializeComponent();
            // Set current menu to the default aiMenu1
            currentMenu = aiMenu1;

            // Disable all scrolling on MenuPanel
            MenuPanel.AutoScroll = false;
        }
        
        private void ShowMenu(UserControl menu)
        {
            // Clear current menu
            MenuPanel.Controls.Clear();
            
            // Add new menu
            MenuPanel.Controls.Add(menu);
            currentMenu = menu;
            
            // Ensure the menu fills the panel
            menu.Dock = DockStyle.Fill;
        }
    }
}
