
namespace XenonBrowser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.createBkmkBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.openBookMksBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.closeTabBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.loadPageBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.searchBar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.refreshBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.fwdBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.backBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableHistoryPanel = new System.Windows.Forms.TableLayoutPanel();
            this.noHistoryText = new MaterialSkin.Controls.MaterialLabel();
            this.tableBkmksPanel = new System.Windows.Forms.TableLayoutPanel();
            this.noBkmksText = new MaterialSkin.Controls.MaterialLabel();
            this.bkmksList = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableHistoryPanel.SuspendLayout();
            this.tableBkmksPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.createBkmkBtn);
            this.panel1.Controls.Add(this.openBookMksBtn);
            this.panel1.Controls.Add(this.closeTabBtn);
            this.panel1.Controls.Add(this.materialFlatButton4);
            this.panel1.Controls.Add(this.loadPageBtn);
            this.panel1.Controls.Add(this.searchBar);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.fwdBtn);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 45);
            this.panel1.TabIndex = 1;
            // 
            // createBkmkBtn
            // 
            this.createBkmkBtn.AutoSize = true;
            this.createBkmkBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createBkmkBtn.Depth = 0;
            this.createBkmkBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.createBkmkBtn.Location = new System.Drawing.Point(769, 0);
            this.createBkmkBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createBkmkBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.createBkmkBtn.Name = "createBkmkBtn";
            this.createBkmkBtn.Primary = false;
            this.createBkmkBtn.Size = new System.Drawing.Size(51, 45);
            this.createBkmkBtn.TabIndex = 15;
            this.createBkmkBtn.Text = "[+✭]";
            this.createBkmkBtn.UseVisualStyleBackColor = true;
            this.createBkmkBtn.Click += new System.EventHandler(this.createBkmkBtn_Click);
            // 
            // openBookMksBtn
            // 
            this.openBookMksBtn.AutoSize = true;
            this.openBookMksBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openBookMksBtn.Depth = 0;
            this.openBookMksBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.openBookMksBtn.Location = new System.Drawing.Point(820, 0);
            this.openBookMksBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.openBookMksBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.openBookMksBtn.Name = "openBookMksBtn";
            this.openBookMksBtn.Primary = false;
            this.openBookMksBtn.Size = new System.Drawing.Size(32, 45);
            this.openBookMksBtn.TabIndex = 14;
            this.openBookMksBtn.Text = "✭";
            this.openBookMksBtn.UseVisualStyleBackColor = true;
            this.openBookMksBtn.Click += new System.EventHandler(this.openBookMksBtn_Click);
            // 
            // closeTabBtn
            // 
            this.closeTabBtn.AutoSize = true;
            this.closeTabBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeTabBtn.Depth = 0;
            this.closeTabBtn.Location = new System.Drawing.Point(716, 6);
            this.closeTabBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeTabBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeTabBtn.Name = "closeTabBtn";
            this.closeTabBtn.Primary = false;
            this.closeTabBtn.Size = new System.Drawing.Size(24, 36);
            this.closeTabBtn.TabIndex = 13;
            this.closeTabBtn.Text = "x";
            this.closeTabBtn.UseVisualStyleBackColor = true;
            this.closeTabBtn.Click += new System.EventHandler(this.closeTabBtn_Click);
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Location = new System.Drawing.Point(685, 6);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(23, 36);
            this.materialFlatButton4.TabIndex = 11;
            this.materialFlatButton4.Text = "+";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            this.materialFlatButton4.Click += new System.EventHandler(this.newTabBtn_Click);
            // 
            // loadPageBtn
            // 
            this.loadPageBtn.AutoSize = true;
            this.loadPageBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadPageBtn.Depth = 0;
            this.loadPageBtn.Location = new System.Drawing.Point(640, 6);
            this.loadPageBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loadPageBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.loadPageBtn.Name = "loadPageBtn";
            this.loadPageBtn.Primary = false;
            this.loadPageBtn.Size = new System.Drawing.Size(22, 36);
            this.loadPageBtn.TabIndex = 10;
            this.loadPageBtn.Text = "↲";
            this.loadPageBtn.UseVisualStyleBackColor = true;
            this.loadPageBtn.Click += new System.EventHandler(this.loadPageBtn_Click);
            // 
            // searchBar
            // 
            this.searchBar.Depth = 0;
            this.searchBar.Hint = "";
            this.searchBar.Location = new System.Drawing.Point(87, 10);
            this.searchBar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchBar.Name = "searchBar";
            this.searchBar.PasswordChar = '\0';
            this.searchBar.SelectedText = "";
            this.searchBar.SelectionLength = 0;
            this.searchBar.SelectionStart = 0;
            this.searchBar.Size = new System.Drawing.Size(531, 28);
            this.searchBar.TabIndex = 9;
            this.searchBar.UseSystemPasswordChar = false;
            this.searchBar.Click += new System.EventHandler(this.searchBar_Click);
            this.searchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoadPageWithEnter);
            // 
            // refreshBtn
            // 
            this.refreshBtn.AutoSize = true;
            this.refreshBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refreshBtn.Depth = 0;
            this.refreshBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.refreshBtn.Location = new System.Drawing.Point(44, 0);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.refreshBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Primary = false;
            this.refreshBtn.Size = new System.Drawing.Size(28, 45);
            this.refreshBtn.TabIndex = 8;
            this.refreshBtn.Text = "⟳";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // fwdBtn
            // 
            this.fwdBtn.AutoSize = true;
            this.fwdBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fwdBtn.Depth = 0;
            this.fwdBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.fwdBtn.Location = new System.Drawing.Point(22, 0);
            this.fwdBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.fwdBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.fwdBtn.Name = "fwdBtn";
            this.fwdBtn.Primary = false;
            this.fwdBtn.Size = new System.Drawing.Size(22, 45);
            this.fwdBtn.TabIndex = 7;
            this.fwdBtn.Text = ">";
            this.fwdBtn.UseVisualStyleBackColor = true;
            this.fwdBtn.Click += new System.EventHandler(this.goFwdBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.AutoSize = true;
            this.backBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBtn.Depth = 0;
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.backBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.backBtn.Name = "backBtn";
            this.backBtn.Primary = false;
            this.backBtn.Size = new System.Drawing.Size(22, 45);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "<";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 466);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(852, 421);
            this.panel3.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(0, 35);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(46, 8);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(852, 421);
            this.tabControl.TabIndex = 0;
            this.tabControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabControl.UseSelectable = true;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableHistoryPanel);
            this.tabPage1.Controls.Add(this.tableBkmksPanel);
            this.tabPage1.Controls.Add(this.bkmksList);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(844, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Закладки";
            // 
            // tableHistoryPanel
            // 
            this.tableHistoryPanel.AutoScroll = true;
            this.tableHistoryPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tableHistoryPanel.ColumnCount = 2;
            this.tableHistoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableHistoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableHistoryPanel.Controls.Add(this.noHistoryText, 0, 0);
            this.tableHistoryPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableHistoryPanel.Location = new System.Drawing.Point(594, 0);
            this.tableHistoryPanel.Name = "tableHistoryPanel";
            this.tableHistoryPanel.RowCount = 2;
            this.tableHistoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableHistoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableHistoryPanel.Size = new System.Drawing.Size(250, 378);
            this.tableHistoryPanel.TabIndex = 3;
            // 
            // noHistoryText
            // 
            this.noHistoryText.AutoSize = true;
            this.noHistoryText.Depth = 0;
            this.noHistoryText.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noHistoryText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.noHistoryText.Location = new System.Drawing.Point(3, 0);
            this.noHistoryText.MouseState = MaterialSkin.MouseState.HOVER;
            this.noHistoryText.Name = "noHistoryText";
            this.noHistoryText.Size = new System.Drawing.Size(86, 48);
            this.noHistoryText.TabIndex = 0;
            this.noHistoryText.Text = "История пуста";
            this.noHistoryText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableBkmksPanel
            // 
            this.tableBkmksPanel.AutoScroll = true;
            this.tableBkmksPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tableBkmksPanel.ColumnCount = 2;
            this.tableBkmksPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBkmksPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBkmksPanel.Controls.Add(this.noBkmksText, 0, 0);
            this.tableBkmksPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableBkmksPanel.Location = new System.Drawing.Point(0, 0);
            this.tableBkmksPanel.Name = "tableBkmksPanel";
            this.tableBkmksPanel.RowCount = 2;
            this.tableBkmksPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBkmksPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBkmksPanel.Size = new System.Drawing.Size(250, 378);
            this.tableBkmksPanel.TabIndex = 2;
            // 
            // noBkmksText
            // 
            this.noBkmksText.AutoSize = true;
            this.noBkmksText.Depth = 0;
            this.noBkmksText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noBkmksText.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noBkmksText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.noBkmksText.Location = new System.Drawing.Point(3, 0);
            this.noBkmksText.MouseState = MaterialSkin.MouseState.HOVER;
            this.noBkmksText.Name = "noBkmksText";
            this.noBkmksText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.noBkmksText.Size = new System.Drawing.Size(119, 189);
            this.noBkmksText.TabIndex = 1;
            this.noBkmksText.Text = "Закладок нет";
            this.noBkmksText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bkmksList
            // 
            this.bkmksList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.bkmksList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bkmksList.HideSelection = false;
            this.bkmksList.Location = new System.Drawing.Point(0, 0);
            this.bkmksList.Name = "bkmksList";
            this.bkmksList.Size = new System.Drawing.Size(844, 378);
            this.bkmksList.TabIndex = 0;
            this.bkmksList.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 496);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xenon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableHistoryPanel.ResumeLayout(false);
            this.tableHistoryPanel.PerformLayout();
            this.tableBkmksPanel.ResumeLayout(false);
            this.tableBkmksPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField searchBar;
        private MaterialSkin.Controls.MaterialFlatButton refreshBtn;
        private MaterialSkin.Controls.MaterialFlatButton fwdBtn;
        private MaterialSkin.Controls.MaterialFlatButton backBtn;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private MaterialSkin.Controls.MaterialFlatButton loadPageBtn;
        private MaterialSkin.Controls.MaterialFlatButton closeTabBtn;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialFlatButton openBookMksBtn;
        private System.Windows.Forms.ListView bkmksList;
        private MaterialSkin.Controls.MaterialFlatButton createBkmkBtn;
        private System.Windows.Forms.TableLayoutPanel tableBkmksPanel;
        private MaterialSkin.Controls.MaterialLabel noBkmksText;
        private System.Windows.Forms.TableLayoutPanel tableHistoryPanel;
        private MaterialSkin.Controls.MaterialLabel noHistoryText;
    }
}

