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

    class BookmarksAndHistory
    {
        public string title;
        public string url;

        public void Print()
        {
            Console.WriteLine($"Title: {title}, URL: {url}");
        }
        public BookmarksAndHistory(string title, string url)
        {
            this.title = title;
            this.url = url;
        }
    }

    public partial class Form1 : MaterialForm
    {
        string bookmarksFileName = "Bookmarks";


        List<BookmarksAndHistory> bookmarksList;

        List<BookmarksAndHistory> GetListFromFile(string fileName)
        {
            List<BookmarksAndHistory> bookmarks = new List<BookmarksAndHistory>();

            if (!File.Exists(fileName = new DirectoryInfo(Directory.GetCurrentDirectory()).FullName + "\\" + fileName + ".dat"))
                File.Create(fileName).Close();
            Console.WriteLine("GET FROM FILE");
            Console.WriteLine(fileName);
            foreach (string record in File.ReadAllLines(fileName))
            {
                string[] lines = record.Split(';');
                bookmarks.Add(new BookmarksAndHistory(lines[0], lines[1]));
                Console.WriteLine(lines[0]);
            }

            return bookmarks;
        }

        private void createBkmkBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CREATE BKMK BUTTON ON CLICK");
            if (!ListIncludesRecord(new BookmarksAndHistory(tabControl.SelectedTab.Text, searchBar.Text), bookmarksList))
                CreateNewListRecord(tabControl.SelectedTab.Text, searchBar.Text, bookmarksList, bookmarksFileName, AddBookmarksToFlowLayout);
        }

        /// <summary> Writes new bookmark in file </summary>
        void CreateNewListRecord(string title, string url, List<BookmarksAndHistory> list, string fileName, Action AddToLayout, bool addFirst = false)
        {
            Console.WriteLine("CREATE NEW LIST RECORD");
            List<string> lines = new List<string>();
            // Add new bookmark to the list
            if (!addFirst)
                list.Add(new BookmarksAndHistory(title, url));
            else
                list.Insert(0, new BookmarksAndHistory(title, url));
            // Write new list to file
            foreach (var rec in list)
            {
                lines.Add(rec.title + ";" + rec.url);
                Console.WriteLine(rec.title);
            }
            if (!File.Exists(fileName = new DirectoryInfo(Directory.GetCurrentDirectory()).FullName + "\\" + fileName + ".dat"))
                File.Create(fileName).Close();
            File.WriteAllLines(fileName, lines);
            // Add bookmark to layout
            AddToLayout();
        }

        /// <summary> Removes bookmark from file </summary>
        void RemoveRecordFromTheList(string title, string url, List<BookmarksAndHistory> list, string fileName, Action AddToLayout)
        {
            List<string> lines = new List<string>();
            int i = 0;
            // Remove bookmark the list
            foreach (var bookmark in list.ToList())
            {
                if (bookmark.title == title && bookmark.url == url)
                    list.RemoveAt(i);
                i++;
            }
            // Write new list to file
            foreach (var bookmark in list.ToList())
                lines.Add(bookmark.title + ";" + bookmark.url);
            File.WriteAllLines(fileName, lines);
            // Add bookmark to layout
            AddToLayout();
        }

        private bool ListIncludesRecord(BookmarksAndHistory bkmk, List<BookmarksAndHistory> list)
        {
            foreach (var bookmark in list)
                if (bookmark.title == bkmk.title && bookmark.url == bkmk.url)
                    return true;
            return false;
        }





        private void AddBookmarksToFlowLayout()
        {
            tableBkmksPanel.Controls.Clear();
            MaterialFlatButton CreateBookmarkButton(BookmarksAndHistory bookmark)
            {
                MaterialFlatButton button = new MaterialFlatButton();
                button.Text = bookmark.title;
                button.Click += (object sender, EventArgs e) => OpenNewTab(bookmark.url);
                button.BackColor = Color.Green;
                button.Dock = DockStyle.Top;
                return button;
            }

            MaterialFlatButton CreateRemoveBookmarkButton(BookmarksAndHistory bookmark)
            {
                MaterialFlatButton button = new MaterialFlatButton();
                button.Text = "[X]";
                button.Click += (object sender, EventArgs e) =>
                {
                    RemoveRecordFromTheList(bookmark.title, bookmark.url, bookmarksList, bookmarksFileName, AddBookmarksToFlowLayout);
                };
                button.BackColor = Color.Green;
                button.Dock = DockStyle.Top;
                return button;
            }

            if (bookmarksList.Count != 0)
                noBkmksText.Visible = false;


            for (int i = 0; i < bookmarksList.Count; i++)
            {
                MaterialFlatButton openBkmkBtn = CreateBookmarkButton(bookmarksList[i]);
                MaterialFlatButton rmBkmkBtn = CreateRemoveBookmarkButton(bookmarksList[i]);
                tableBkmksPanel.Controls.Add(openBkmkBtn);
                tableBkmksPanel.Controls.Add(rmBkmkBtn);
                tableBkmksPanel.RowCount++;
            }


            for (int i = 0; i < tableBkmksPanel.RowStyles.Count; i++)
                tableBkmksPanel.RowStyles[i].SizeType = SizeType.AutoSize;


        }
    }
}
