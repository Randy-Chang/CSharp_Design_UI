using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_design_Color;

namespace CSharp_Design_UI
{
    public partial class Form1 : Form
    {
        //Fields
        private Form activeForm;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        string sFont_FamilName = "Microsoft JhengHei"; // 微軟正黑體
        float intButtonFont_Size = 14F;
        float intButtonFont_Size_Activate = 16F;

        public Form1()
        {
            InitializeComponent();

            // Form 無邊框
            this.FormBorderStyle = FormBorderStyle.None;
            plFormBar.MouseDown += panelFormBar_MouseDown;
            btnCancel.Click += btnCancel_Click;
            btnMaximize.Click += btnMaximize_Click;
            btnMinimize.Click += btnMinimize_Click;

            // 點擊會改變主題顏色
            random = new Random();
            this.Resize += Form_Resize;
            btnOpenSubForm1.Click += btnClick_Subform1;
            btnOpenSubForm2.Click += btnClick_Subform2;
            btnOpenSubForm3.Click += btnClick_Subform3;
            btnHome.Click += btnCloseChildForm_Click;
            DisableButton();
            Reset();

        }

        #region Button Click觸發的委派
        private void btnClick_Subform1(object btnSender, EventArgs e)
        {
            OpenChildForm(new SubForms.SubForm1(), btnSender);
        }

        private void btnClick_Subform2(object btnSender, EventArgs e)
        {
            OpenChildForm(new SubForms.SubForm2(), btnSender);
        }

        private void btnClick_Subform3(object btnSender, EventArgs e)
        {
            OpenChildForm(new SubForms.SubForm3(), btnSender);
        }
        #endregion

        #region 自製Form Bar
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /// <summary>
        /// 定義視窗Bar可移動
        /// </summary>
        private void panelFormBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// 視窗關閉
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 視窗放大
        /// </summary>
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// 視窗縮小
        /// </summary>
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion


        #region// UI Methods
        /// <summary>
        /// 隨機選擇主題顏色
        /// </summary>
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        /// <summary>
        /// 選擇的按鍵，變更按鍵的外觀(顏色、字型)
        /// </summary>
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font(sFont_FamilName, intButtonFont_Size_Activate, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //panelTitleBar.BackColor = color;
                    btnHome.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;
                }
            }
        }

        /// <summary>
        /// Menu中的按鍵，回復按鍵的外觀(顏色、字型)
        /// </summary>
        private void DisableButton()
        {
            foreach (Control previousBtn in plMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.Text = previousBtn.Text;
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font(sFont_FamilName, intButtonFont_Size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        /// <summary>
        /// 開啟子視窗於指定的父容器(plDockSubform)
        /// </summary>
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.plDockSubform.Controls.Add(childForm);
            this.plDockSubform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        /// <summary>
        /// 關閉子視窗
        /// </summary>
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        /// <summary>
        /// 重新設定Home按鍵
        /// </summary>
        private void Reset()
        {
            DisableButton();
            btnHome.BackColor = Color.FromArgb(39, 39, 58);
            btnHome.ForeColor = Color.White;
            btnHome.Font = new System.Drawing.Font(sFont_FamilName, intButtonFont_Size, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            currentButton = null;
        }

        /// <summary>
        /// 當主視窗大小改變，回傳flag，讓子視窗也能接收到主視窗變化
        /// </summary>
        private void Form_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                GVAR.MainFormWindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                GVAR.MainFormWindowState = FormWindowState.Normal;
            }
        }
        #endregion
    }

    /// <summary>
    /// 全域變數的類別
    /// </summary>
    static partial class GVAR
    {
        public static FormWindowState MainFormWindowState = FormWindowState.Normal;
    }
}
