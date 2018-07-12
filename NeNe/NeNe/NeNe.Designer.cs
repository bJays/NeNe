namespace NeNe
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MainProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.MainStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SetNextRangeBtn = new System.Windows.Forms.Button();
            this.SetPlayRangeBtn = new System.Windows.Forms.Button();
            this.GetProcessNameBtn = new System.Windows.Forms.Button();
            this.InfoSplitContainer = new System.Windows.Forms.SplitContainer();
            this.GlassPanel = new System.Windows.Forms.Panel();
            this.ProcessNameGrpBox = new System.Windows.Forms.GroupBox();
            this.ProcessNamesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoSplitContainer)).BeginInit();
            this.InfoSplitContainer.Panel1.SuspendLayout();
            this.InfoSplitContainer.Panel2.SuspendLayout();
            this.InfoSplitContainer.SuspendLayout();
            this.ProcessNameGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainProgressBar,
            this.MainStatusLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 539);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(1234, 22);
            this.MainStatusStrip.TabIndex = 0;
            this.MainStatusStrip.Text = "MainStatusStrip";
            // 
            // MainProgressBar
            // 
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.Size = new System.Drawing.Size(150, 16);
            // 
            // MainStatusLabel
            // 
            this.MainStatusLabel.Name = "MainStatusLabel";
            this.MainStatusLabel.Size = new System.Drawing.Size(132, 17);
            this.MainStatusLabel.Text = "NeNe (Auto Education)";
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainSplitContainer.IsSplitterFixed = true;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer.Name = "MainSplitContainer";
            this.MainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.button7);
            this.MainSplitContainer.Panel1.Controls.Add(this.button6);
            this.MainSplitContainer.Panel1.Controls.Add(this.button5);
            this.MainSplitContainer.Panel1.Controls.Add(this.button4);
            this.MainSplitContainer.Panel1.Controls.Add(this.SetNextRangeBtn);
            this.MainSplitContainer.Panel1.Controls.Add(this.SetPlayRangeBtn);
            this.MainSplitContainer.Panel1.Controls.Add(this.GetProcessNameBtn);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.MainSplitContainer.Panel2.Controls.Add(this.InfoSplitContainer);
            this.MainSplitContainer.Size = new System.Drawing.Size(1234, 539);
            this.MainSplitContainer.SplitterDistance = 47;
            this.MainSplitContainer.SplitterWidth = 1;
            this.MainSplitContainer.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(639, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 40);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(533, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 40);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(427, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(321, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // SetNextRangeBtn
            // 
            this.SetNextRangeBtn.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SetNextRangeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SetNextRangeBtn.Location = new System.Drawing.Point(215, 3);
            this.SetNextRangeBtn.Name = "SetNextRangeBtn";
            this.SetNextRangeBtn.Size = new System.Drawing.Size(100, 40);
            this.SetNextRangeBtn.TabIndex = 2;
            this.SetNextRangeBtn.Text = "&Next\r\nRange";
            this.SetNextRangeBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.SetNextRangeBtn.UseVisualStyleBackColor = true;
            this.SetNextRangeBtn.Click += new System.EventHandler(this.SetNextRangeBtn_Click);
            // 
            // SetPlayRangeBtn
            // 
            this.SetPlayRangeBtn.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SetPlayRangeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SetPlayRangeBtn.Location = new System.Drawing.Point(109, 3);
            this.SetPlayRangeBtn.Name = "SetPlayRangeBtn";
            this.SetPlayRangeBtn.Size = new System.Drawing.Size(100, 40);
            this.SetPlayRangeBtn.TabIndex = 1;
            this.SetPlayRangeBtn.Text = "&Player\r\nRange";
            this.SetPlayRangeBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.SetPlayRangeBtn.UseVisualStyleBackColor = true;
            this.SetPlayRangeBtn.Click += new System.EventHandler(this.SetPlayRangeBtn_Click);
            // 
            // GetProcessNameBtn
            // 
            this.GetProcessNameBtn.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GetProcessNameBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GetProcessNameBtn.Location = new System.Drawing.Point(3, 3);
            this.GetProcessNameBtn.Name = "GetProcessNameBtn";
            this.GetProcessNameBtn.Size = new System.Drawing.Size(100, 40);
            this.GetProcessNameBtn.TabIndex = 0;
            this.GetProcessNameBtn.Text = "&Get\r\nProcess Name";
            this.GetProcessNameBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.GetProcessNameBtn.UseVisualStyleBackColor = true;
            this.GetProcessNameBtn.Click += new System.EventHandler(this.GetProcessNameBtn_Click);
            // 
            // InfoSplitContainer
            // 
            this.InfoSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.InfoSplitContainer.Name = "InfoSplitContainer";
            // 
            // InfoSplitContainer.Panel1
            // 
            this.InfoSplitContainer.Panel1.Controls.Add(this.GlassPanel);
            // 
            // InfoSplitContainer.Panel2
            // 
            this.InfoSplitContainer.Panel2.Controls.Add(this.ProcessNameGrpBox);
            this.InfoSplitContainer.Size = new System.Drawing.Size(1234, 491);
            this.InfoSplitContainer.SplitterDistance = 800;
            this.InfoSplitContainer.SplitterWidth = 1;
            this.InfoSplitContainer.TabIndex = 2;
            // 
            // GlassPanel
            // 
            this.GlassPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.GlassPanel.Location = new System.Drawing.Point(12, 3);
            this.GlassPanel.Name = "GlassPanel";
            this.GlassPanel.Size = new System.Drawing.Size(200, 100);
            this.GlassPanel.TabIndex = 1;
            // 
            // ProcessNameGrpBox
            // 
            this.ProcessNameGrpBox.Controls.Add(this.ProcessNamesListView);
            this.ProcessNameGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcessNameGrpBox.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProcessNameGrpBox.Location = new System.Drawing.Point(0, 0);
            this.ProcessNameGrpBox.Name = "ProcessNameGrpBox";
            this.ProcessNameGrpBox.Size = new System.Drawing.Size(433, 491);
            this.ProcessNameGrpBox.TabIndex = 0;
            this.ProcessNameGrpBox.TabStop = false;
            this.ProcessNameGrpBox.Text = "Process Name";
            // 
            // ProcessNamesListView
            // 
            this.ProcessNamesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ProcessNamesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcessNamesListView.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProcessNamesListView.FullRowSelect = true;
            this.ProcessNamesListView.GridLines = true;
            this.ProcessNamesListView.Location = new System.Drawing.Point(3, 17);
            this.ProcessNamesListView.MultiSelect = false;
            this.ProcessNamesListView.Name = "ProcessNamesListView";
            this.ProcessNamesListView.Size = new System.Drawing.Size(427, 471);
            this.ProcessNamesListView.TabIndex = 0;
            this.ProcessNamesListView.UseCompatibleStateImageBehavior = false;
            this.ProcessNamesListView.View = System.Windows.Forms.View.Details;
            this.ProcessNamesListView.SelectedIndexChanged += new System.EventHandler(this.ProcessNamesListView_SelectedIndexChanged);
            this.ProcessNamesListView.Click += new System.EventHandler(this.ProcessNamesListView_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Process Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Titile Name";
            this.columnHeader3.Width = 200;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 561);
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.MainStatusStrip);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NeNe (Auto Edu)";
            this.TransparencyKey = System.Drawing.Color.LightSeaGreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.InfoSplitContainer.Panel1.ResumeLayout(false);
            this.InfoSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfoSplitContainer)).EndInit();
            this.InfoSplitContainer.ResumeLayout(false);
            this.ProcessNameGrpBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.Button GetProcessNameBtn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button SetNextRangeBtn;
        private System.Windows.Forms.Button SetPlayRangeBtn;
        private System.Windows.Forms.ToolStripProgressBar MainProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel MainStatusLabel;
        private System.Windows.Forms.Panel GlassPanel;
        private System.Windows.Forms.SplitContainer InfoSplitContainer;
        private System.Windows.Forms.GroupBox ProcessNameGrpBox;
        private System.Windows.Forms.ListView ProcessNamesListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

