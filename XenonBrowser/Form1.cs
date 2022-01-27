using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;

using System.Runtime.InteropServices;

namespace XenonBrowser
{    

    public partial class Form1 : MaterialForm
    {

        public Form1()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
               Primary.DeepOrange300, Primary.BlueGrey900,
               Primary.BlueGrey500, Accent.LightBlue200,
               TextShade.WHITE
            );
        }


        private TabPage settingsPage;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            AllocConsole();
            // Set window fs
            Size = new Size(Screen.PrimaryScreen.Bounds.Size.Width, Screen.PrimaryScreen.Bounds.Size.Height - 80);
            this.CenterToScreen();

            

            // Get bookmarks
            bookmarksList = GetListFromFile(bookmarksFileName);
            // Get history
            historyList = GetListFromFile(historyFileName);
            
            AddBookmarksToFlowLayout();
            AddHistoryToFlowLayout();

            settingsPage = tabControl.TabPages[0];

            tabControl.TabPages.Clear();

            CefSettings settings = new CefSettings();

            Cef.Initialize(settings);
            OpenNewTab();


        }


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void loadPageBtn_Click(object sender, EventArgs e) => LoadPage();

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser chromium = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (chromium.CanGoBack)
                chromium.Back();
        }

        private void goFwdBtn_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser chromium = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (chromium.CanGoForward)
                chromium.Forward();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser chromium = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            chromium.Refresh();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void newTabBtn_Click(object sender, EventArgs e) => OpenNewTab();


        public void OpenNewTab(string url = "")
        {
            if (url.Length == 0)
                url = BrowserSettings.defaultSearchEngine;

            TabPage tab = new TabPage();
            tab.Text = "New tab";
            tabControl.Controls.Add(tab);


            tabControl.SelectTab(tabControl.TabCount - 1);
            ChromiumWebBrowser chromium = new ChromiumWebBrowser(url);
            chromium.Parent = tabControl.SelectedTab;
            chromium.Dock = DockStyle.Fill;
            searchBar.Text = url;

            LifespanHandler life = new LifespanHandler();
            chromium.LifeSpanHandler = life;

            chromium.AddressChanged += Chrome_AddressChanged;
            chromium.TitleChanged += Chrome_TitleChanged;
        }

  
        private void Chrome_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                tabControl.SelectedTab.Text = e.Title;
            }));
        }

        private void Chrome_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                searchBar.Text = e.Address;
            }));
        }

        private void searchBar_Click(object sender, EventArgs e)
        {
            // Convert url to request in search bar
            searchBar.Text = UrlUtils.ConvertUrlToRequest(searchBar.Text);
            // Highlight search bar text
            searchBar.SelectionStart = 0;
            searchBar.SelectionLength = searchBar.Text.Length;
        }

        public void RemoveTab()
        {
            if (tabControl.TabPages.Count > 1)
            {
                int selectedIndex = tabControl.SelectedIndex;
                tabControl.TabPages.RemoveAt(selectedIndex);
                if (selectedIndex < tabControl.TabCount)
                    tabControl.SelectTab(selectedIndex);
                else
                    tabControl.SelectTab(selectedIndex - 1);
            }
            else
            {
                tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
                OpenNewTab();
            }

        }

      

        public void LoadPage(TabPage tab = null)
        {
            if (tab == null)
                tab = tabControl.SelectedTab;
            ChromiumWebBrowser chromium = tab.Controls[0] as ChromiumWebBrowser;

            LifespanHandler life = new LifespanHandler();
            chromium.LifeSpanHandler = life;

            // Check if search bar text is not an url 
            if (searchBar.Text.Contains('.') && !searchBar.Text.Contains(' ') && searchBar.Text[0] != '.')
            {
                CreateHistoryRecord(searchBar.Text, UrlUtils.ConvertUrlToRequest(searchBar.Text));
                chromium.Load(searchBar.Text); // Load url
            }
            else
            {
                CreateHistoryRecord(UrlUtils.ConvertRequestToUrl(searchBar.Text), searchBar.Text);
                chromium.Load(UrlUtils.ConvertRequestToUrl(searchBar.Text)); // Load req
            }
        }




        private void LoadPageWithEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoadPage();
        }

        private void closeTabBtn_Click(object sender, EventArgs e) => RemoveTab();



        
        private void openBookMksBtn_Click(object sender, EventArgs e)
        {
            if (!tabControl.TabPages.Contains(settingsPage))
                tabControl.TabPages.Add(settingsPage);
            tabControl.SelectTab(settingsPage);
            tabControl.SelectedTab.Text = "Настройки";
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == settingsPage)
            {
                fwdBtn.Visible = false;
                backBtn.Visible = false;
                refreshBtn.Visible = false;
                searchBar.Visible = false;
                createBkmkBtn.Visible = false;
                loadPageBtn.Visible = false;
            }
            else
            {
                fwdBtn.Visible = true;
                backBtn.Visible = true;
                refreshBtn.Visible = true;
                searchBar.Visible = true;
                createBkmkBtn.Visible = true;
                loadPageBtn.Visible = true;

                //if(tabControl.SelectedTab != null && tabControl.SelectedTab.Controls[0] != null)
                //{
                //    ChromiumWebBrowser chromium = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
                //    searchBar.Text = chromium.Address;
                //    chromium.TitleChanged += Chrome_TitleChanged;
                //}
              
            }
        }

      
    }
}
