using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wallpaper
{
    public partial class frmWallpaperProperties : Form
    {
        string[] paths;

        public frmWallpaperProperties()
        {
            InitializeComponent();
            paths = new string[3];
        }

        private string getPath(char[] cha)
        {
            string part = "";
            string fullName = "";

            for (int i = 0; i < cha.Length; i++)
            {
                if (cha[i] == '\\')
                {
                    if (part.Contains(".jpg") || part.Contains(".png") || part.Contains(".jpeg") || part.Contains(".gif"))
                        break;
                    part = "";
                }
                else
                    part += cha[i];

                if (i > 11)
                    fullName += cha[i];
            }
            return fullName.Replace("\0", string.Empty);
        }

        private void RefreshWallpapers()
        {
            const string keyName = "HKEY_CURRENT_USER\\Control Panel\\Desktop";

            try {
                paths[0] = getPath(System.Text.Encoding.Unicode.GetString((byte[])Registry.GetValue(keyName, "TranscodedImageCache_000", "")).ToCharArray());
                using (FileStream stream = new FileStream(paths[0], FileMode.Open, FileAccess.Read))
                {
                    pic1.Image = Image.FromStream(stream);
                    txtPath1.Text = paths[0];
                }
            }
            catch (Exception e) {
                grpMonitor1.Enabled = false;
            }

            try {
                paths[1] = getPath(System.Text.Encoding.Unicode.GetString((byte[])Registry.GetValue(keyName, "TranscodedImageCache_001", "")).ToCharArray());
                using (FileStream stream = new FileStream(paths[1], FileMode.Open, FileAccess.Read))
                {
                    pic2.Image = Image.FromStream(stream);
                    txtPath2.Text = paths[1];
                }
            }
            catch (Exception e)
            {
                grpMonitor2.Enabled = false;
            }
            try {
                paths[2] = getPath(System.Text.Encoding.Unicode.GetString((byte[])Registry.GetValue(keyName, "TranscodedImageCache_002", "")).ToCharArray());
                using (FileStream stream = new FileStream(paths[2], FileMode.Open, FileAccess.Read))
                {
                    pic3.Image = Image.FromStream(stream);
                    txtPath3.Text = paths[2];
                }
            }
            catch (Exception e)
            {
                grpMonitor3.Enabled = false;
            }
        }

        private void deleteImg(string path)
        {
            string file = Path.GetFileName(path);
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + file + "? This is permanent!", "Delete Wallpaper", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try {
                    File.Delete(path);
                    pic1.Image = null;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not delete. " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshWallpapers();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Visible)
                RefreshWallpapers();
        }

        private void btnOpen1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"/select, " + paths[0]);
        }
        private void btnOpen2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"/select, " + paths[1]);
        }
        private void btnOpen3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"/select, " + paths[2]);
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            deleteImg(paths[0]);
        }
        private void btnDelete2_Click(object sender, EventArgs e)
        {
            deleteImg(paths[1]);
        }
        private void btnDelete3_Click(object sender, EventArgs e)
        {
            deleteImg(paths[2]);
        }
    }
}
