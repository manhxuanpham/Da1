namespace Quản_Lý_Điểm_SPKTHY
{
    partial class GUI_BaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_BaoCao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbLoaiBaoCao = new Bunifu.UI.WinForms.BunifuDropdown();
            this.dtgvBaoCao = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnXuat = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbHocKy = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBaoCao)).BeginInit();
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
            this.bunifuPanel1.Controls.Add(this.cbbHocKy);
            this.bunifuPanel1.Controls.Add(this.btnXuat);
            this.bunifuPanel1.Controls.Add(this.label6);
            this.bunifuPanel1.Controls.Add(this.cbbLoaiBaoCao);
            this.bunifuPanel1.Controls.Add(this.dtgvBaoCao);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1020, 805);
            this.bunifuPanel1.TabIndex = 1;
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(12, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 21);
            this.label6.TabIndex = 44;
            this.label6.Text = "Loại Báo Cáo";
            // 
            // cbbLoaiBaoCao
            // 
            this.cbbLoaiBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.cbbLoaiBaoCao.BackgroundColor = System.Drawing.Color.White;
            this.cbbLoaiBaoCao.BorderColor = System.Drawing.Color.Silver;
            this.cbbLoaiBaoCao.BorderRadius = 17;
            this.cbbLoaiBaoCao.Color = System.Drawing.Color.Silver;
            this.cbbLoaiBaoCao.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbbLoaiBaoCao.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbbLoaiBaoCao.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbbLoaiBaoCao.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbbLoaiBaoCao.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbbLoaiBaoCao.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbbLoaiBaoCao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoaiBaoCao.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbbLoaiBaoCao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiBaoCao.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbbLoaiBaoCao.FillDropDown = true;
            this.cbbLoaiBaoCao.FillIndicator = false;
            this.cbbLoaiBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbLoaiBaoCao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbbLoaiBaoCao.ForeColor = System.Drawing.Color.Black;
            this.cbbLoaiBaoCao.FormattingEnabled = true;
            this.cbbLoaiBaoCao.Icon = null;
            this.cbbLoaiBaoCao.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbbLoaiBaoCao.IndicatorColor = System.Drawing.Color.Gray;
            this.cbbLoaiBaoCao.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbbLoaiBaoCao.ItemBackColor = System.Drawing.Color.White;
            this.cbbLoaiBaoCao.ItemBorderColor = System.Drawing.Color.White;
            this.cbbLoaiBaoCao.ItemForeColor = System.Drawing.Color.Black;
            this.cbbLoaiBaoCao.ItemHeight = 26;
            this.cbbLoaiBaoCao.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbbLoaiBaoCao.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbbLoaiBaoCao.Items.AddRange(new object[] {
            "Thống Kê Sinh Viên Học Bổng",
            "Thống Kê Sinh Viên Học Lại"});
            this.cbbLoaiBaoCao.ItemTopMargin = 3;
            this.cbbLoaiBaoCao.Location = new System.Drawing.Point(164, 112);
            this.cbbLoaiBaoCao.Margin = new System.Windows.Forms.Padding(0);
            this.cbbLoaiBaoCao.Name = "cbbLoaiBaoCao";
            this.cbbLoaiBaoCao.Size = new System.Drawing.Size(394, 32);
            this.cbbLoaiBaoCao.TabIndex = 43;
            this.cbbLoaiBaoCao.Text = null;
            this.cbbLoaiBaoCao.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbbLoaiBaoCao.TextLeftMargin = 5;
            this.cbbLoaiBaoCao.SelectedIndexChanged += new System.EventHandler(this.cbbDSLop_SelectedIndexChanged);
            // 
            // dtgvBaoCao
            // 
            this.dtgvBaoCao.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtgvBaoCao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvBaoCao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvBaoCao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBaoCao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvBaoCao.ColumnHeadersHeight = 40;
            this.dtgvBaoCao.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dtgvBaoCao.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvBaoCao.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvBaoCao.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgvBaoCao.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvBaoCao.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dtgvBaoCao.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgvBaoCao.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtgvBaoCao.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtgvBaoCao.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvBaoCao.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dtgvBaoCao.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvBaoCao.CurrentTheme.Name = null;
            this.dtgvBaoCao.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBaoCao.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvBaoCao.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvBaoCao.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgvBaoCao.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBaoCao.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvBaoCao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvBaoCao.EnableHeadersVisualStyles = false;
            this.dtgvBaoCao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgvBaoCao.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dtgvBaoCao.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgvBaoCao.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvBaoCao.Location = new System.Drawing.Point(0, 231);
            this.dtgvBaoCao.Name = "dtgvBaoCao";
            this.dtgvBaoCao.RowHeadersVisible = false;
            this.dtgvBaoCao.RowHeadersWidth = 51;
            this.dtgvBaoCao.RowTemplate.Height = 40;
            this.dtgvBaoCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBaoCao.Size = new System.Drawing.Size(1020, 574);
            this.dtgvBaoCao.TabIndex = 1;
            this.dtgvBaoCao.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnXuat
            // 
            this.btnXuat.AllowAnimations = true;
            this.btnXuat.AllowMouseEffects = true;
            this.btnXuat.AllowToggling = false;
            this.btnXuat.AnimationSpeed = 200;
            this.btnXuat.AutoGenerateColors = false;
            this.btnXuat.AutoRoundBorders = false;
            this.btnXuat.AutoSizeLeftIcon = true;
            this.btnXuat.AutoSizeRightIcon = true;
            this.btnXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnXuat.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnXuat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuat.BackgroundImage")));
            this.btnXuat.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXuat.ButtonText = "Xuất Excel";
            this.btnXuat.ButtonTextMarginLeft = 0;
            this.btnXuat.ColorContrastOnClick = 45;
            this.btnXuat.ColorContrastOnHover = 45;
            this.btnXuat.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnXuat.CustomizableEdges = borderEdges1;
            this.btnXuat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXuat.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXuat.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXuat.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXuat.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnXuat.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnXuat.ForeColor = System.Drawing.Color.White;
            this.btnXuat.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnXuat.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.btnXuat.IconMarginLeft = 11;
            this.btnXuat.IconPadding = 10;
            this.btnXuat.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuat.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnXuat.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnXuat.IconSize = 25;
            this.btnXuat.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnXuat.IdleBorderRadius = 20;
            this.btnXuat.IdleBorderThickness = 1;
            this.btnXuat.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnXuat.IdleIconLeftImage = null;
            this.btnXuat.IdleIconRightImage = null;
            this.btnXuat.IndicateFocus = false;
            this.btnXuat.Location = new System.Drawing.Point(787, 188);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXuat.OnDisabledState.BorderRadius = 20;
            this.btnXuat.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXuat.OnDisabledState.BorderThickness = 1;
            this.btnXuat.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXuat.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXuat.OnDisabledState.IconLeftImage = null;
            this.btnXuat.OnDisabledState.IconRightImage = null;
            this.btnXuat.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(73)))));
            this.btnXuat.onHoverState.BorderRadius = 20;
            this.btnXuat.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXuat.onHoverState.BorderThickness = 1;
            this.btnXuat.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(217)))), ((int)(((byte)(73)))));
            this.btnXuat.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnXuat.onHoverState.IconLeftImage = null;
            this.btnXuat.onHoverState.IconRightImage = null;
            this.btnXuat.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnXuat.OnIdleState.BorderRadius = 20;
            this.btnXuat.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXuat.OnIdleState.BorderThickness = 1;
            this.btnXuat.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnXuat.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnXuat.OnIdleState.IconLeftImage = null;
            this.btnXuat.OnIdleState.IconRightImage = null;
            this.btnXuat.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXuat.OnPressedState.BorderRadius = 20;
            this.btnXuat.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXuat.OnPressedState.BorderThickness = 1;
            this.btnXuat.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXuat.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnXuat.OnPressedState.IconLeftImage = null;
            this.btnXuat.OnPressedState.IconRightImage = null;
            this.btnXuat.Size = new System.Drawing.Size(185, 37);
            this.btnXuat.TabIndex = 85;
            this.btnXuat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXuat.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXuat.TextMarginLeft = 0;
            this.btnXuat.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnXuat.UseDefaultRadiusAndThickness = true;
            this.btnXuat.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 87;
            this.label1.Text = "Học Kỳ";
            // 
            // cbbHocKy
            // 
            this.cbbHocKy.BackColor = System.Drawing.Color.Transparent;
            this.cbbHocKy.BackgroundColor = System.Drawing.Color.White;
            this.cbbHocKy.BorderColor = System.Drawing.Color.Silver;
            this.cbbHocKy.BorderRadius = 17;
            this.cbbHocKy.Color = System.Drawing.Color.Silver;
            this.cbbHocKy.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbbHocKy.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbbHocKy.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbbHocKy.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbbHocKy.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbbHocKy.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbbHocKy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbHocKy.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHocKy.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbbHocKy.FillDropDown = true;
            this.cbbHocKy.FillIndicator = false;
            this.cbbHocKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbHocKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbbHocKy.ForeColor = System.Drawing.Color.Black;
            this.cbbHocKy.FormattingEnabled = true;
            this.cbbHocKy.Icon = null;
            this.cbbHocKy.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbbHocKy.IndicatorColor = System.Drawing.Color.Gray;
            this.cbbHocKy.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbbHocKy.ItemBackColor = System.Drawing.Color.White;
            this.cbbHocKy.ItemBorderColor = System.Drawing.Color.White;
            this.cbbHocKy.ItemForeColor = System.Drawing.Color.Black;
            this.cbbHocKy.ItemHeight = 26;
            this.cbbHocKy.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbbHocKy.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbbHocKy.ItemTopMargin = 3;
            this.cbbHocKy.Location = new System.Drawing.Point(164, 22);
            this.cbbHocKy.Margin = new System.Windows.Forms.Padding(0);
            this.cbbHocKy.Name = "cbbHocKy";
            this.cbbHocKy.Size = new System.Drawing.Size(394, 32);
            this.cbbHocKy.TabIndex = 86;
            this.cbbHocKy.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbbHocKy.TextLeftMargin = 5;
            // 
            // GUI_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 805);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_BaoCao";
            this.Text = "GUI_BaoCaocs";
            this.Load += new System.EventHandler(this.GUI_BaoCao_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuDropdown cbbLoaiBaoCao;
        private Bunifu.UI.WinForms.BunifuDataGridView dtgvBaoCao;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnXuat;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDropdown cbbHocKy;
    }
}