namespace CSharp_Design_UI
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plFormBar = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.plMenu = new System.Windows.Forms.Panel();
            this.btnOpenSubForm3 = new System.Windows.Forms.Button();
            this.btnOpenSubForm2 = new System.Windows.Forms.Button();
            this.btnOpenSubForm1 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.plDockSubform = new System.Windows.Forms.Panel();
            this.plFormBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.plMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // plFormBar
            // 
            this.plFormBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.plFormBar.Controls.Add(this.pbLogo);
            this.plFormBar.Controls.Add(this.btnMinimize);
            this.plFormBar.Controls.Add(this.btnMaximize);
            this.plFormBar.Controls.Add(this.btnCancel);
            this.plFormBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.plFormBar.Location = new System.Drawing.Point(0, 0);
            this.plFormBar.Margin = new System.Windows.Forms.Padding(6);
            this.plFormBar.Name = "plFormBar";
            this.plFormBar.Size = new System.Drawing.Size(1184, 30);
            this.plFormBar.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(33, 30);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1094, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 8;
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1124, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(6);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 7;
            this.btnMaximize.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(1154, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(30, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // plMenu
            // 
            this.plMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.plMenu.Controls.Add(this.btnOpenSubForm3);
            this.plMenu.Controls.Add(this.btnOpenSubForm2);
            this.plMenu.Controls.Add(this.btnOpenSubForm1);
            this.plMenu.Controls.Add(this.btnHome);
            this.plMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.plMenu.Location = new System.Drawing.Point(0, 30);
            this.plMenu.Margin = new System.Windows.Forms.Padding(6);
            this.plMenu.Name = "plMenu";
            this.plMenu.Size = new System.Drawing.Size(279, 731);
            this.plMenu.TabIndex = 1;
            // 
            // btnOpenSubForm3
            // 
            this.btnOpenSubForm3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenSubForm3.FlatAppearance.BorderSize = 0;
            this.btnOpenSubForm3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSubForm3.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOpenSubForm3.Location = new System.Drawing.Point(0, 150);
            this.btnOpenSubForm3.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpenSubForm3.Name = "btnOpenSubForm3";
            this.btnOpenSubForm3.Size = new System.Drawing.Size(279, 50);
            this.btnOpenSubForm3.TabIndex = 5;
            this.btnOpenSubForm3.Text = "SubForm3";
            this.btnOpenSubForm3.UseVisualStyleBackColor = true;
            // 
            // btnOpenSubForm2
            // 
            this.btnOpenSubForm2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenSubForm2.FlatAppearance.BorderSize = 0;
            this.btnOpenSubForm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSubForm2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOpenSubForm2.Location = new System.Drawing.Point(0, 100);
            this.btnOpenSubForm2.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpenSubForm2.Name = "btnOpenSubForm2";
            this.btnOpenSubForm2.Size = new System.Drawing.Size(279, 50);
            this.btnOpenSubForm2.TabIndex = 4;
            this.btnOpenSubForm2.Text = "SubForm2";
            this.btnOpenSubForm2.UseVisualStyleBackColor = true;
            // 
            // btnOpenSubForm1
            // 
            this.btnOpenSubForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenSubForm1.FlatAppearance.BorderSize = 0;
            this.btnOpenSubForm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSubForm1.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOpenSubForm1.Location = new System.Drawing.Point(0, 50);
            this.btnOpenSubForm1.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpenSubForm1.Name = "btnOpenSubForm1";
            this.btnOpenSubForm1.Size = new System.Drawing.Size(279, 50);
            this.btnOpenSubForm1.TabIndex = 3;
            this.btnOpenSubForm1.Text = "SubForm1";
            this.btnOpenSubForm1.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(279, 50);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // plDockSubform
            // 
            this.plDockSubform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plDockSubform.Location = new System.Drawing.Point(279, 30);
            this.plDockSubform.Name = "plDockSubform";
            this.plDockSubform.Size = new System.Drawing.Size(905, 731);
            this.plDockSubform.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.plDockSubform);
            this.Controls.Add(this.plMenu);
            this.Controls.Add(this.plFormBar);
            this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.plFormBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.plMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plFormBar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel plMenu;
        private System.Windows.Forms.Button btnOpenSubForm3;
        private System.Windows.Forms.Button btnOpenSubForm2;
        private System.Windows.Forms.Button btnOpenSubForm1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel plDockSubform;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

