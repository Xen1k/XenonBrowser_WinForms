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
namespace XenonBrowser
{
    public partial class Form1 : MaterialForm
    {
        string historyFileName = "History";

        List<BookmarksAndHistory> historyList;


        private void CreateHistoryRecord(string title, string url)
        {
            if (!ListIncludesRecord(new BookmarksAndHistory(title, url), historyList))
                CreateNewListRecord(title, url, historyList, historyFileName, AddHistoryToFlowLayout, addFirst: true);
        }

        private void AddHistoryToFlowLayout()
        {
            tableHistoryPanel.Controls.Clear();
            MaterialFlatButton CreateHistoryButton(BookmarksAndHistory historyRecord)
            {
                MaterialFlatButton button = new MaterialFlatButton();
                button.Text = historyRecord.title;
                button.Click += (object sender, EventArgs e) => OpenNewTab(historyRecord.url);
                button.BackColor = Color.Green;
                button.Dock = DockStyle.Top;
                return button;
            }

            MaterialFlatButton CreateRemoveFromHistoryButton(BookmarksAndHistory historyRecord)
            {
                MaterialFlatButton button = new MaterialFlatButton();
                button.Text = "[X]";
                button.Click += (object sender, EventArgs e) =>
                {
                    RemoveRecordFromTheList(historyRecord.title, historyRecord.url, historyList, historyFileName, AddHistoryToFlowLayout);
                };
                button.BackColor = Color.Green;
                button.Dock = DockStyle.Top;
                return button;
            }

            if (historyList.Count != 0)
                noHistoryText.Visible = false;

            for (int i = 0; i < historyList.Count; i++)
            {
                MaterialFlatButton openHistRecBtn = CreateHistoryButton(historyList[i]);
                MaterialFlatButton rmHistRecBtn = CreateRemoveFromHistoryButton(historyList[i]);
                tableHistoryPanel.Controls.Add(openHistRecBtn);
                tableHistoryPanel.Controls.Add(rmHistRecBtn);
                tableHistoryPanel.RowCount++;
            }



            for (int i = 0; i < tableHistoryPanel.RowStyles.Count; i++)
                tableHistoryPanel.RowStyles[i].SizeType = SizeType.AutoSize;

        }

    }
}
