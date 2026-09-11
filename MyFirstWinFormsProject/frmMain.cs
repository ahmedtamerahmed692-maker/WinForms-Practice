using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            EnableHighQualityPictureBoxes();
            LoadHeaderImages();
            RegisterMenuEvents();
            SelectNavItem(btnReceiveInvoice, pnlReceiveInvoice);
        }

        private void RegisterMenuEvents()
        {
            btnReceiveInvoice.Click += (s, e) => SelectNavItem(btnReceiveInvoice, pnlReceiveInvoice);
            btnSales.Click += (s, e) => SelectNavItem(btnSales, pnlSales);
            btnAttendance.Click += (s, e) => SelectNavItem(btnAttendance, pnlAttendance);
            btnInventory.Click += (s, e) => SelectNavItem(btnInventory, pnlStore);
            btnLoans.Click += (s, e) => SelectNavItem(btnLoans, pnlAdvance);
            btnFactorySearch.Click += (s, e) => SelectNavItem(btnFactorySearch, pnlSearchFactory);
            btnAccountSettle.Click += (s, e) => SelectNavItem(btnAccountSettle, pnlSettings);
        }

        private void SelectNavItem(Button selectedButton, Panel selectedPanel)
        {
            // 1. إعادة جميع الأزرار للون الطبيعي الغامق
            Button[] sidebarButtons = { btnReceiveInvoice, btnSales, btnAttendance, btnInventory, btnLoans, btnFactorySearch, btnAccountSettle };
            foreach (var btn in sidebarButtons)
            {
                if (btn != null)
                {
                    btn.BackColor = Color.FromArgb(30, 30, 30);
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
                }
            }

            // 2. إخفاء جميع لوحات المحتوى
            Panel[] contentPanels = { pnlReceiveInvoice, pnlSales, pnlAttendance, pnlStore, pnlAdvance, pnlSearchFactory, pnlSettings };
            foreach (var pnl in contentPanels)
            {
                if (pnl != null) pnl.Visible = false;
            }

            // 3. تظليل الزرار المختار باللون الأزرق الفاتح المأخوذ من الصورة
            if (selectedButton != null)
            {
                selectedButton.BackColor = Color.FromArgb(235, 243, 254);
                selectedButton.ForeColor = Color.FromArgb(15, 82, 186);
                selectedButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            }

            // 4. إظهار لوحة المحتوى المناسبة
            if (selectedPanel != null)
            {
                selectedPanel.Visible = true;
                selectedPanel.BringToFront();
            }
        }

        private void EnableHighQualityPictureBoxes()
        {
            PictureBox[] boxes = { picLogo, picUserAvatar, picDarkMode, picLanguage, picNotifications };
            foreach (var pb in boxes)
            {
                if (pb == null) continue;
                pb.Paint += (s, e) =>
                {
                    e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                    e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
                };
            }
        }

        private void LoadHeaderImages()
        {
            try
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string projectDir = Path.GetFullPath(Path.Combine(baseDir, @"..\..\"));

                SetHighQualityImage(picLogo, "factory_logo.png", baseDir, projectDir);
                SetHighQualityImage(picUserAvatar, "user_avatar.png", baseDir, projectDir);
                SetHighQualityImage(picDarkMode, "moon_icon.png", baseDir, projectDir);
                SetHighQualityImage(picLanguage, "lang_icon.png", baseDir, projectDir);
                SetHighQualityImage(picNotifications, "bell_icon.png", baseDir, projectDir);
            }
            catch { }
        }

        private void SetHighQualityImage(PictureBox pb, string fileName, string baseDir, string projectDir)
        {
            if (pb == null) return;

            string path = Path.Combine(baseDir, fileName);
            if (!File.Exists(path)) path = Path.Combine(projectDir, fileName);

            if (File.Exists(path))
            {
                using (Image src = Image.FromFile(path))
                {
                    pb.Image = new Bitmap(src);
                }
            }
        }

        private void pnlSettings_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void lblAppTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
