using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Eduction_Institute_Mangment_Systerm
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        

         private void AbrirFormEnPanel(object Form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = Form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();

        }

       

        private void btn_student_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new student());
        }

        private void btn_teacher_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Teacher());
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Staff());
        }

        private void btn_finance_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Finance());
        }

        private void btn_attendance_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Attendance());
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_form_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_form_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_fb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com");
        }

        private void btn_gmil_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://accounts.google.com/signin/v2/identifier?hl=en-GB&flowName=GlifWebSignIn&flowEntry=ServiceLogin");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_login_edit_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Login_Edit());
        }
    }
}
