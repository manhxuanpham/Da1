namespace Quản_Lý_Điểm_SPKTHY
{
    partial class GUI_QuanLyPhanTheoLopcs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_QuanLyPhanTheoLopcs));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbGiangVien = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMonHocPhan = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbDSLop = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btnXoa = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSua = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnThem = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.DTGVLopHP = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVLopHP)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Controls.Add(this.cbbGiangVien);
            this.bunifuPanel1.Controls.Add(this.label2);
            this.bunifuPanel1.Controls.Add(this.cbbMonHocPhan);
            this.bunifuPanel1.Controls.Add(this.label6);
            this.bunifuPanel1.Controls.Add(this.cbbDSLop);
            this.bunifuPanel1.Controls.Add(this.btnXoa);
            this.bunifuPanel1.Controls.Add(this.btnSua);
            this.bunifuPanel1.Controls.Add(this.btnThem);
            this.bunifuPanel1.Controls.Add(this.DTGVLopHP);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1071, 756);
            this.bunifuPanel1.TabIndex = 1;
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(196, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 69;
            this.label1.Text = "Danh Sách GV";
            // 
            // cbbGiangVien
            // 
            this.cbbGiangVien.BackColor = System.Drawing.Color.Transparent;
            this.cbbGiangVien.BackgroundColor = System.Drawing.Color.White;
            this.cbbGiangVien.BorderColor = System.Drawing.Color.Silver;
            this.cbbGiangVien.BorderRadius = 17;
            this.cbbGiangVien.Color = System.Drawing.Color.Silver;
            this.cbbGiangVien.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbbGiangVien.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbbGiangVien.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbbGiangVien.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbbGiangVien.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbbGiangVien.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbbGiangVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbGiangVien.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbbGiangVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGiangVien.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbbGiangVien.FillDropDown = true;
            this.cbbGiangVien.FillIndicator = false;
            this.cbbGiangVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbGiangVien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGiangVien.ForeColor = System.Drawing.Color.Black;
            this.cbbGiangVien.FormattingEnabled = true;
            this.cbbGiangVien.Icon = null;
            this.cbbGiangVien.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbbGiangVien.IndicatorColor = System.Drawing.Color.Gray;
            this.cbbGiangVien.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbbGiangVien.ItemBackColor = System.Drawing.Color.White;
            this.cbbGiangVien.ItemBorderColor = System.Drawing.Color.White;
            this.cbbGiangVien.ItemForeColor = System.Drawing.Color.Black;
            this.cbbGiangVien.ItemHeight = 26;
            this.cbbGiangVien.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbbGiangVien.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbbGiangVien.ItemTopMargin = 3;
            this.cbbGiangVien.Location = new System.Drawing.Point(360, 276);
            this.cbbGiangVien.Margin = new System.Windows.Forms.Padding(0);
            this.cbbGiangVien.Name = "cbbGiangVien";
            this.cbbGiangVien.Size = new System.Drawing.Size(266, 32);
            this.cbbGiangVien.TabIndex = 3;
            this.cbbGiangVien.Text = null;
            this.cbbGiangVien.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbbGiangVien.TextLeftMargin = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(196, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 67;
            this.label2.Text = "Môn Học Phần";
            // 
            // cbbMonHocPhan
            // 
            this.cbbMonHocPhan.BackColor = System.Drawing.Color.Transparent;
            this.cbbMonHocPhan.BackgroundColor = System.Drawing.Color.White;
            this.cbbMonHocPhan.BorderColor = System.Drawing.Color.Silver;
            this.cbbMonHocPhan.BorderRadius = 17;
            this.cbbMonHocPhan.Color = System.Drawing.Color.Silver;
            this.cbbMonHocPhan.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbbMonHocPhan.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbbMonHocPhan.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbbMonHocPhan.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbbMonHocPhan.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbbMonHocPhan.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbbMonHocPhan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbMonHocPhan.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbbMonHocPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonHocPhan.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbbMonHocPhan.FillDropDown = true;
            this.cbbMonHocPhan.FillIndicator = false;
            this.cbbMonHocPhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbMonHocPhan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMonHocPhan.ForeColor = System.Drawing.Color.Black;
            this.cbbMonHocPhan.FormattingEnabled = true;
            this.cbbMonHocPhan.Icon = null;
            this.cbbMonHocPhan.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbbMonHocPhan.IndicatorColor = System.Drawing.Color.Gray;
            this.cbbMonHocPhan.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbbMonHocPhan.ItemBackColor = System.Drawing.Color.White;
            this.cbbMonHocPhan.ItemBorderColor = System.Drawing.Color.White;
            this.cbbMonHocPhan.ItemForeColor = System.Drawing.Color.Black;
            this.cbbMonHocPhan.ItemHeight = 26;
            this.cbbMonHocPhan.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbbMonHocPhan.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbbMonHocPhan.ItemTopMargin = 3;
            this.cbbMonHocPhan.Location = new System.Drawing.Point(360, 112);
            this.cbbMonHocPhan.Margin = new System.Windows.Forms.Padding(0);
            this.cbbMonHocPhan.Name = "cbbMonHocPhan";
            this.cbbMonHocPhan.Size = new System.Drawing.Size(266, 32);
            this.cbbMonHocPhan.TabIndex = 1;
            this.cbbMonHocPhan.Text = null;
            this.cbbMonHocPhan.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbbMonHocPhan.TextLeftMargin = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(193, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 21);
            this.label6.TabIndex = 65;
            this.label6.Text = "Danh Sách Lớp";
            // 
            // cbbDSLop
            // 
            this.cbbDSLop.BackColor = System.Drawing.Color.Transparent;
            this.cbbDSLop.BackgroundColor = System.Drawing.Color.White;
            this.cbbDSLop.BorderColor = System.Drawing.Color.Silver;
            this.cbbDSLop.BorderRadius = 17;
            this.cbbDSLop.Color = System.Drawing.Color.Silver;
            this.cbbDSLop.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbbDSLop.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbbDSLop.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbbDSLop.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbbDSLop.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbbDSLop.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbbDSLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbDSLop.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbbDSLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDSLop.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbbDSLop.FillDropDown = true;
            this.cbbDSLop.FillIndicator = false;
            this.cbbDSLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbDSLop.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDSLop.ForeColor = System.Drawing.Color.Black;
            this.cbbDSLop.FormattingEnabled = true;
            this.cbbDSLop.Icon = null;
            this.cbbDSLop.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbbDSLop.IndicatorColor = System.Drawing.Color.Gray;
            this.cbbDSLop.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbbDSLop.ItemBackColor = System.Drawing.Color.White;
            this.cbbDSLop.ItemBorderColor = System.Drawing.Color.White;
            this.cbbDSLop.ItemForeColor = System.Drawing.Color.Black;
            this.cbbDSLop.ItemHeight = 26;
            this.cbbDSLop.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbbDSLop.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbbDSLop.ItemTopMargin = 3;
            this.cbbDSLop.Location = new System.Drawing.Point(360, 196);
            this.cbbDSLop.Margin = new System.Windows.Forms.Padding(0);
            this.cbbDSLop.Name = "cbbDSLop";
            this.cbbDSLop.Size = new System.Drawing.Size(266, 32);
            this.cbbDSLop.TabIndex = 2;
            this.cbbDSLop.Text = null;
            this.cbbDSLop.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbbDSLop.TextLeftMargin = 5;
            // 
            // btnXoa
            // 
            this.btnXoa.AllowAnimations = true;
            this.btnXoa.AllowMouseEffects = true;
            this.btnXoa.AllowToggling = false;
            this.btnXoa.AnimationSpeed = 200;
            this.btnXoa.AutoGenerateColors = false;
            this.btnXoa.AutoRoundBorders = false;
            this.btnXoa.AutoSizeLeftIcon = true;
            this.btnXoa.AutoSizeRightIcon = true;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.ButtonText = "Xoá";
            this.btnXoa.ButtonTextMarginLeft = 0;
            this.btnXoa.ColorContrastOnClick = 45;
            this.btnXoa.ColorContrastOnHover = 45;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnXoa.CustomizableEdges = borderEdges1;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoa.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXoa.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXoa.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXoa.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnXoa.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.btnXoa.IconMarginLeft = 11;
            this.btnXoa.IconPadding = 10;
            this.btnXoa.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnXoa.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnXoa.IconSize = 25;
            this.btnXoa.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnXoa.IdleBorderRadius = 20;
            this.btnXoa.IdleBorderThickness = 1;
            this.btnXoa.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnXoa.IdleIconLeftImage = null;
            this.btnXoa.IdleIconRightImage = null;
            this.btnXoa.IndicateFocus = false;
            this.btnXoa.Location = new System.Drawing.Point(712, 276);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXoa.OnDisabledState.BorderRadius = 20;
            this.btnXoa.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.OnDisabledState.BorderThickness = 1;
            this.btnXoa.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXoa.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXoa.OnDisabledState.IconLeftImage = null;
            this.btnXoa.OnDisabledState.IconRightImage = null;
            this.btnXoa.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(73)))));
            this.btnXoa.onHoverState.BorderRadius = 20;
            this.btnXoa.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.onHoverState.BorderThickness = 1;
            this.btnXoa.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(73)))));
            this.btnXoa.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.onHoverState.IconLeftImage = null;
            this.btnXoa.onHoverState.IconRightImage = null;
            this.btnXoa.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnXoa.OnIdleState.BorderRadius = 20;
            this.btnXoa.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.OnIdleState.BorderThickness = 1;
            this.btnXoa.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnXoa.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.OnIdleState.IconLeftImage = null;
            this.btnXoa.OnIdleState.IconRightImage = null;
            this.btnXoa.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXoa.OnPressedState.BorderRadius = 20;
            this.btnXoa.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.OnPressedState.BorderThickness = 1;
            this.btnXoa.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXoa.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.OnPressedState.IconLeftImage = null;
            this.btnXoa.OnPressedState.IconRightImage = null;
            this.btnXoa.Size = new System.Drawing.Size(190, 37);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoa.TextMarginLeft = 0;
            this.btnXoa.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnXoa.UseDefaultRadiusAndThickness = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AllowAnimations = true;
            this.btnSua.AllowMouseEffects = true;
            this.btnSua.AllowToggling = false;
            this.btnSua.AnimationSpeed = 200;
            this.btnSua.AutoGenerateColors = false;
            this.btnSua.AutoRoundBorders = false;
            this.btnSua.AutoSizeLeftIcon = true;
            this.btnSua.AutoSizeRightIcon = true;
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSua.ButtonText = "Sửa";
            this.btnSua.ButtonTextMarginLeft = 0;
            this.btnSua.ColorContrastOnClick = 45;
            this.btnSua.ColorContrastOnHover = 45;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSua.CustomizableEdges = borderEdges2;
            this.btnSua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSua.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSua.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSua.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSua.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSua.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSua.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.btnSua.IconMarginLeft = 11;
            this.btnSua.IconPadding = 10;
            this.btnSua.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSua.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSua.IconSize = 25;
            this.btnSua.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnSua.IdleBorderRadius = 20;
            this.btnSua.IdleBorderThickness = 1;
            this.btnSua.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnSua.IdleIconLeftImage = null;
            this.btnSua.IdleIconRightImage = null;
            this.btnSua.IndicateFocus = false;
            this.btnSua.Location = new System.Drawing.Point(712, 193);
            this.btnSua.Name = "btnSua";
            this.btnSua.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSua.OnDisabledState.BorderRadius = 20;
            this.btnSua.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSua.OnDisabledState.BorderThickness = 1;
            this.btnSua.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSua.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSua.OnDisabledState.IconLeftImage = null;
            this.btnSua.OnDisabledState.IconRightImage = null;
            this.btnSua.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(73)))));
            this.btnSua.onHoverState.BorderRadius = 20;
            this.btnSua.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSua.onHoverState.BorderThickness = 1;
            this.btnSua.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(73)))));
            this.btnSua.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSua.onHoverState.IconLeftImage = null;
            this.btnSua.onHoverState.IconRightImage = null;
            this.btnSua.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnSua.OnIdleState.BorderRadius = 20;
            this.btnSua.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSua.OnIdleState.BorderThickness = 1;
            this.btnSua.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnSua.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSua.OnIdleState.IconLeftImage = null;
            this.btnSua.OnIdleState.IconRightImage = null;
            this.btnSua.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSua.OnPressedState.BorderRadius = 20;
            this.btnSua.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSua.OnPressedState.BorderThickness = 1;
            this.btnSua.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSua.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSua.OnPressedState.IconLeftImage = null;
            this.btnSua.OnPressedState.IconRightImage = null;
            this.btnSua.Size = new System.Drawing.Size(190, 37);
            this.btnSua.TabIndex = 5;
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSua.TextMarginLeft = 0;
            this.btnSua.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSua.UseDefaultRadiusAndThickness = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.AllowAnimations = true;
            this.btnThem.AllowMouseEffects = true;
            this.btnThem.AllowToggling = false;
            this.btnThem.AnimationSpeed = 200;
            this.btnThem.AutoGenerateColors = false;
            this.btnThem.AutoRoundBorders = false;
            this.btnThem.AutoSizeLeftIcon = true;
            this.btnThem.AutoSizeRightIcon = true;
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThem.ButtonText = "Thêm";
            this.btnThem.ButtonTextMarginLeft = 0;
            this.btnThem.ColorContrastOnClick = 45;
            this.btnThem.ColorContrastOnHover = 45;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnThem.CustomizableEdges = borderEdges3;
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThem.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnThem.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnThem.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnThem.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnThem.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.btnThem.IconMarginLeft = 11;
            this.btnThem.IconPadding = 10;
            this.btnThem.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnThem.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnThem.IconSize = 25;
            this.btnThem.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnThem.IdleBorderRadius = 20;
            this.btnThem.IdleBorderThickness = 1;
            this.btnThem.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnThem.IdleIconLeftImage = null;
            this.btnThem.IdleIconRightImage = null;
            this.btnThem.IndicateFocus = false;
            this.btnThem.Location = new System.Drawing.Point(712, 112);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnThem.OnDisabledState.BorderRadius = 20;
            this.btnThem.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThem.OnDisabledState.BorderThickness = 1;
            this.btnThem.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnThem.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnThem.OnDisabledState.IconLeftImage = null;
            this.btnThem.OnDisabledState.IconRightImage = null;
            this.btnThem.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(73)))));
            this.btnThem.onHoverState.BorderRadius = 20;
            this.btnThem.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThem.onHoverState.BorderThickness = 1;
            this.btnThem.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(73)))));
            this.btnThem.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnThem.onHoverState.IconLeftImage = null;
            this.btnThem.onHoverState.IconRightImage = null;
            this.btnThem.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnThem.OnIdleState.BorderRadius = 20;
            this.btnThem.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThem.OnIdleState.BorderThickness = 1;
            this.btnThem.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnThem.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnThem.OnIdleState.IconLeftImage = null;
            this.btnThem.OnIdleState.IconRightImage = null;
            this.btnThem.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnThem.OnPressedState.BorderRadius = 20;
            this.btnThem.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThem.OnPressedState.BorderThickness = 1;
            this.btnThem.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnThem.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnThem.OnPressedState.IconLeftImage = null;
            this.btnThem.OnPressedState.IconRightImage = null;
            this.btnThem.Size = new System.Drawing.Size(190, 37);
            this.btnThem.TabIndex = 4;
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThem.TextMarginLeft = 0;
            this.btnThem.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnThem.UseDefaultRadiusAndThickness = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // DTGVLopHP
            // 
            this.DTGVLopHP.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DTGVLopHP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DTGVLopHP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTGVLopHP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTGVLopHP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DTGVLopHP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTGVLopHP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DTGVLopHP.ColumnHeadersHeight = 40;
            this.DTGVLopHP.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.DTGVLopHP.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DTGVLopHP.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DTGVLopHP.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DTGVLopHP.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DTGVLopHP.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.DTGVLopHP.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DTGVLopHP.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.DTGVLopHP.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DTGVLopHP.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DTGVLopHP.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.DTGVLopHP.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DTGVLopHP.CurrentTheme.Name = null;
            this.DTGVLopHP.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DTGVLopHP.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DTGVLopHP.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DTGVLopHP.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DTGVLopHP.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTGVLopHP.DefaultCellStyle = dataGridViewCellStyle3;
            this.DTGVLopHP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DTGVLopHP.EnableHeadersVisualStyles = false;
            this.DTGVLopHP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DTGVLopHP.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.DTGVLopHP.HeaderBgColor = System.Drawing.Color.Empty;
            this.DTGVLopHP.HeaderForeColor = System.Drawing.Color.White;
            this.DTGVLopHP.Location = new System.Drawing.Point(0, 378);
            this.DTGVLopHP.Name = "DTGVLopHP";
            this.DTGVLopHP.RowHeadersVisible = false;
            this.DTGVLopHP.RowHeadersWidth = 51;
            this.DTGVLopHP.RowTemplate.Height = 40;
            this.DTGVLopHP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGVLopHP.Size = new System.Drawing.Size(1071, 378);
            this.DTGVLopHP.TabIndex = 54;
            this.DTGVLopHP.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.DTGVLopHP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGVLopHP_CellClick);
            this.DTGVLopHP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGVLopHP_CellContentClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // GUI_QuanLyPhanTheoLopcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 756);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_QuanLyPhanTheoLopcs";
            this.Text = "GUI_ThemHocPhanChoLopcs";
            this.Load += new System.EventHandler(this.GUI_QuanLyPhanTheoLopcs_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVLopHP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnXoa;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSua;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnThem;
        private Bunifu.UI.WinForms.BunifuDataGridView DTGVLopHP;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuDropdown cbbDSLop;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuDropdown cbbMonHocPhan;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDropdown cbbGiangVien;
    }
}