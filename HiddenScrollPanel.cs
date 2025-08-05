using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Lucent_V2
{
    // Panel with scrolling functionality but completely hidden scroll bars
    public class HiddenScrollPanel : Panel
    {
        // Windows API constants and imports
        private const int WM_HSCROLL = 0x114;
        private const int WM_VSCROLL = 0x115;
        private const int WM_MOUSEWHEEL = 0x020A;
        private const int WM_NCCALCSIZE = 0x0083;
        private const int WM_WINDOWPOSCHANGING = 0x0046;
        private const int SB_HORZ = 0;
        private const int SB_VERT = 1;
        private const int SB_BOTH = 3;
        
        [DllImport("user32.dll")]
        private static extern int ShowScrollBar(IntPtr hWnd, int wBar, int bShow);
        
        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        
        private const uint SWP_FRAMECHANGED = 0x0020;
        private const uint SWP_NOMOVE = 0x0002;
        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOZORDER = 0x0004;
        
        public HiddenScrollPanel()
        {
            // Enable basic scrolling
            this.AutoScroll = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }
        
        protected override void WndProc(ref Message m)
        {
            // Intercept all scroll-related messages and hide bars immediately
            if (m.Msg == WM_HSCROLL || m.Msg == WM_VSCROLL || m.Msg == WM_MOUSEWHEEL || m.Msg == WM_NCCALCSIZE)
            {
                base.WndProc(ref m);
                // Hide immediately after processing
                HideScrollBarsImmediate();
                return;
            }
            
            base.WndProc(ref m);
        }
        
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            // Hide scrollbars immediately when the handle is created
            HideScrollBarsImmediate();
        }
        
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible && this.IsHandleCreated)
            {
                HideScrollBarsImmediate();
            }
        }
        
        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            // Hide scroll bars when controls are added
            if (this.IsHandleCreated)
            {
                HideScrollBarsImmediate();
            }
        }
        
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // Hide scroll bars when resized
            if (this.IsHandleCreated)
            {
                HideScrollBarsImmediate();
            }
        }
        
        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
            // Hide scroll bars after layout
            if (this.IsHandleCreated)
            {
                HideScrollBarsImmediate();
            }
        }
        
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            // Handle mouse wheel scrolling
            if (this.AutoScroll)
            {
                int currentY = -this.AutoScrollPosition.Y;
                int scrollAmount = e.Delta / 3;
                int newY = currentY - scrollAmount;
                
                int maxScroll = Math.Max(0, this.AutoScrollMinSize.Height - this.ClientSize.Height);
                newY = Math.Max(0, Math.Min(newY, maxScroll));
                
                this.AutoScrollPosition = new Point(0, newY);
                
                // Hide scrollbars immediately after scrolling
                HideScrollBarsImmediate();
            }
            base.OnMouseWheel(e);
        }
        
        // Custom method to handle vertical scrolling
        public void ScrollVertically(int delta)
        {
            if (this.IsHandleCreated)
            {
                MouseEventArgs e = new MouseEventArgs(MouseButtons.None, 0, 0, 0, delta);
                OnMouseWheel(e);
            }
        }
        
        private void HideScrollBarsImmediate()
        {
            if (this.IsHandleCreated && !this.IsDisposed)
            {
                try
                {
                    // Multiple immediate calls to ensure they stay hidden
                    ShowScrollBar(this.Handle, SB_BOTH, 0);
                    ShowScrollBar(this.Handle, SB_HORZ, 0);
                    ShowScrollBar(this.Handle, SB_VERT, 0);
                }
                catch
                {
                    // Ignore any errors (handle might be invalid)
                }
            }
        }
    }
}
