using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace TrayIconExp
{
    public partial class frmTrayIcon : Form
    {
        public frmTrayIcon()
        {
            InitializeComponent();
        }
        
        //Tray_01: Variable to know when should I exit the form
        private bool EndNow = false;

        //Tray_02: Simply wait for the Seconds to elapse
        public void btnMonitor_Click(object sender, EventArgs e)
        {
            lblCurrentTime.Text = "";
            lblCurrentTime.Text = "Searching...";
            string searchResult = search(txtAreaCode.Text);
            lblCurrentTime.Text = "Searching...";
            if (searchResult != "")
            {
                lblCurrentTime.Text = searchResult;
            }
            else
            {
                lblCurrentTime.Text = "Not an Area Code... :(";
            }
            
        }

        private static string GetLocationData(string text)
        {
            string retString = "";
            string pattern = "<a.*?>(.*?)<\\/a>";

            MatchCollection matches = Regex.Matches(text, pattern);
            Console.WriteLine("Matches found: {0}", matches.Count);

            if (matches.Count > 0)
            {
                Console.WriteLine("Matched: " + matches[0].Groups[1]);
                retString = matches[0].Groups[1].ToString().Replace("<br>", ", ");
            }
            return retString;
        }

        private static string search(string query)
        {
            int i = 0;
            HtmlWeb client = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = client.Load("http://www.allareacodes.com/" + query);
            HtmlNodeCollection Nodes = doc.DocumentNode.SelectNodes("//td");
            string LabelString = "";
            foreach (var link in Nodes)
            {
                //Console.WriteLine("Line: " + i);
                //Console.WriteLine(link.InnerText);
                if (i == 1)
                {
                    LabelString = GetLocationData(link.InnerHtml); //get the state for the area code. ( And country if outside the US)
                    //Console.WriteLine(i + ": " + LabelString);
                }
                if (i == 3)
                {
                    if (link.InnerHtml == "Area Code")
                    {
                        break;
                    }
                    LabelString = link.InnerHtml + " " + LabelString; //get the city for the area code.
                    //Console.WriteLine(i + ": " + LabelString);
                }
                if (i == 5)
                {
                    LabelString = LabelString + " " + link.InnerHtml; //current time for the area code.
                    //Console.WriteLine(i + ": " + LabelString);
                }
                if (i == 7)
                {
                    LabelString = LabelString + " " + link.InnerHtml; //current time for the area code.
                    //Console.WriteLine(i + ": " + LabelString);
                    break;
                }
                i++;
            }
            return LabelString;
        }

        //Tray_03: Implement Context Menu 
        private void mnuRemaining_Click(object sender, EventArgs e)
        {
            this.Show();
        }
        private void mnuExit_Click(object sender, EventArgs e)
        {
            EndNow = true;
            this.Close();
        }

        //Tray_05: When the close button clicked, hide the form.
        private void frmTrayIcon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EndNow == false)
            {
                e.Cancel = true;
                Application.DoEvents();
                this.Hide();
            }
        }

        //Tray_06: Set the Tray Icon visibility to False
        private void frmTrayIcon_Load(object sender, EventArgs e)
        {
            TrayIcon.Visible = true;
        }

    }
}