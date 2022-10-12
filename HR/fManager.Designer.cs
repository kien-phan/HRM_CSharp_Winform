namespace HR
{
    partial class fManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_user_option = new System.Windows.Forms.Button();
            this.panel_user_container = new System.Windows.Forms.Panel();
            this.btn_user_option_logOut = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_statistic = new System.Windows.Forms.Button();
            this.btn_training = new System.Windows.Forms.Button();
            this.btn_salary = new System.Windows.Forms.Button();
            this.btn_hrm = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lbLogo = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panel_user_container.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelMenu.Controls.Add(this.btn_user_option);
            this.panelMenu.Controls.Add(this.panel_user_container);
            this.panelMenu.Controls.Add(this.btn_setting);
            this.panelMenu.Controls.Add(this.btn_statistic);
            this.panelMenu.Controls.Add(this.btn_training);
            this.panelMenu.Controls.Add(this.btn_salary);
            this.panelMenu.Controls.Add(this.btn_hrm);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.MinimumSize = new System.Drawing.Size(220, 700);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 700);
            this.panelMenu.TabIndex = 0;
            // 
            // btn_user_option
            // 
            this.btn_user_option.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_user_option.FlatAppearance.BorderSize = 0;
            this.btn_user_option.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user_option.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user_option.ForeColor = System.Drawing.Color.LightGreen;
            this.btn_user_option.Image = global::HR.Properties.Resources.user_info_30px;
            this.btn_user_option.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_user_option.Location = new System.Drawing.Point(0, 520);
            this.btn_user_option.Name = "btn_user_option";
            this.btn_user_option.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_user_option.Size = new System.Drawing.Size(220, 60);
            this.btn_user_option.TabIndex = 3;
            this.btn_user_option.Text = "  Welcome user";
            this.btn_user_option.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_user_option.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_user_option.UseVisualStyleBackColor = true;
            this.btn_user_option.Click += new System.EventHandler(this.btn_user_option_Click);
            // 
            // panel_user_container
            // 
            this.panel_user_container.Controls.Add(this.btn_user_option_logOut);
            this.panel_user_container.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_user_container.Location = new System.Drawing.Point(0, 580);
            this.panel_user_container.Name = "panel_user_container";
            this.panel_user_container.Size = new System.Drawing.Size(220, 60);
            this.panel_user_container.TabIndex = 6;
            // 
            // btn_user_option_logOut
            // 
            this.btn_user_option_logOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btn_user_option_logOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_user_option_logOut.FlatAppearance.BorderSize = 0;
            this.btn_user_option_logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user_option_logOut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user_option_logOut.ForeColor = System.Drawing.Color.LightGreen;
            this.btn_user_option_logOut.Image = global::HR.Properties.Resources.arrow_right_20px;
            this.btn_user_option_logOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_user_option_logOut.Location = new System.Drawing.Point(0, 0);
            this.btn_user_option_logOut.Name = "btn_user_option_logOut";
            this.btn_user_option_logOut.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_user_option_logOut.Size = new System.Drawing.Size(220, 60);
            this.btn_user_option_logOut.TabIndex = 2;
            this.btn_user_option_logOut.Text = "Thoát";
            this.btn_user_option_logOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_user_option_logOut.UseVisualStyleBackColor = false;
            this.btn_user_option_logOut.Click += new System.EventHandler(this.btn_user_option_logOut_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_setting.FlatAppearance.BorderSize = 0;
            this.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setting.ForeColor = System.Drawing.Color.LightGreen;
            this.btn_setting.Image = global::HR.Properties.Resources.settings_30px;
            this.btn_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setting.Location = new System.Drawing.Point(0, 640);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_setting.Size = new System.Drawing.Size(220, 60);
            this.btn_setting.TabIndex = 5;
            this.btn_setting.Text = "  Cài đặt";
            this.btn_setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_statistic
            // 
            this.btn_statistic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_statistic.FlatAppearance.BorderSize = 0;
            this.btn_statistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_statistic.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_statistic.ForeColor = System.Drawing.Color.LightGreen;
            this.btn_statistic.Image = global::HR.Properties.Resources.combo_chart_30px;
            this.btn_statistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_statistic.Location = new System.Drawing.Point(0, 260);
            this.btn_statistic.Name = "btn_statistic";
            this.btn_statistic.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_statistic.Size = new System.Drawing.Size(220, 60);
            this.btn_statistic.TabIndex = 4;
            this.btn_statistic.Text = "  Thống kê";
            this.btn_statistic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_statistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_statistic.UseVisualStyleBackColor = true;
            this.btn_statistic.Click += new System.EventHandler(this.btn_statistic_Click);
            // 
            // btn_training
            // 
            this.btn_training.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_training.FlatAppearance.BorderSize = 0;
            this.btn_training.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_training.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_training.ForeColor = System.Drawing.Color.LightGreen;
            this.btn_training.Image = global::HR.Properties.Resources.training_30px;
            this.btn_training.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_training.Location = new System.Drawing.Point(0, 200);
            this.btn_training.Name = "btn_training";
            this.btn_training.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_training.Size = new System.Drawing.Size(220, 60);
            this.btn_training.TabIndex = 3;
            this.btn_training.Text = "  Tuyển dụng, training";
            this.btn_training.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_training.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_training.UseVisualStyleBackColor = true;
            this.btn_training.Click += new System.EventHandler(this.btn_training_Click);
            // 
            // btn_salary
            // 
            this.btn_salary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_salary.FlatAppearance.BorderSize = 0;
            this.btn_salary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salary.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salary.ForeColor = System.Drawing.Color.LightGreen;
            this.btn_salary.Image = global::HR.Properties.Resources.get_cash_30px;
            this.btn_salary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salary.Location = new System.Drawing.Point(0, 140);
            this.btn_salary.Name = "btn_salary";
            this.btn_salary.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_salary.Size = new System.Drawing.Size(220, 60);
            this.btn_salary.TabIndex = 2;
            this.btn_salary.Text = "  Tiền lương";
            this.btn_salary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salary.UseVisualStyleBackColor = true;
            this.btn_salary.Click += new System.EventHandler(this.btn_salary_Click);
            // 
            // btn_hrm
            // 
            this.btn_hrm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_hrm.FlatAppearance.BorderSize = 0;
            this.btn_hrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hrm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hrm.ForeColor = System.Drawing.Color.LightGreen;
            this.btn_hrm.Image = global::HR.Properties.Resources.people_30px;
            this.btn_hrm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hrm.Location = new System.Drawing.Point(0, 80);
            this.btn_hrm.Name = "btn_hrm";
            this.btn_hrm.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_hrm.Size = new System.Drawing.Size(220, 60);
            this.btn_hrm.TabIndex = 1;
            this.btn_hrm.Text = "  Quản lý nhân sự";
            this.btn_hrm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hrm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_hrm.UseVisualStyleBackColor = true;
            this.btn_hrm.Click += new System.EventHandler(this.btn_hrm_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.panelLogo.Controls.Add(this.lbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // lbLogo
            // 
            this.lbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbLogo.AutoSize = true;
            this.lbLogo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogo.ForeColor = System.Drawing.Color.LightGreen;
            this.lbLogo.Location = new System.Drawing.Point(75, 25);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(56, 24);
            this.lbLogo.TabIndex = 2;
            this.lbLogo.Text = "HRM";
            this.lbLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lbTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(980, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnMinimize.Location = new System.Drawing.Point(878, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnMaximize.Location = new System.Drawing.Point(914, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.Text = "o";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnClose.Location = new System.Drawing.Point(950, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCloseChildForm.Image = global::HR.Properties.Resources.close_30px;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 80);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.LightGreen;
            this.lbTitle.Location = new System.Drawing.Point(394, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(72, 24);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "HOME";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoScroll = true;
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(980, 620);
            this.panelDesktop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(379, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 112);
            this.label1.TabIndex = 0;
            this.label1.Text = "HRM";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 80);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "fManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân sự";
            this.panelMenu.ResumeLayout(false);
            this.panel_user_container.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btn_hrm;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_statistic;
        private System.Windows.Forms.Button btn_training;
        private System.Windows.Forms.Button btn_salary;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Panel panel_user_container;
        private System.Windows.Forms.Button btn_user_option;
        private System.Windows.Forms.Button btn_user_option_logOut;
    }
}