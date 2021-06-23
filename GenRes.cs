using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace createResourceText
{
  public partial class GenRes : Form
  {
    public string pathRootName = "";
    List<string> myResources = new List<string>();

    public GenRes()
    {
      InitializeComponent();
    }

    private void btnEvent_Click(object sender, EventArgs e)
    {
      Button tmp = (Button)sender;

      switch(tmp.Name)
      {
        case "btnOpenDir":
          FolderBrowserDialog fDialEx = new FolderBrowserDialog();
          DialogResult result = fDialEx.ShowDialog();
          if (result == DialogResult.OK)
          {
            pathRootName = fDialEx.SelectedPath;
            tbPath.Text = pathRootName;
            dgvList.Rows.Clear();
            LoadSubDirs(pathRootName);
          }
          break;

        case "btnGenResource":
          writeFile();
          break;

        case "btnClipBoard":
          Clipboard.SetText(prepareText());
          break;
      }
    }

    private void LoadSubDirs(string dir)
    {
      string[] subdirectoryEntries = Directory.GetDirectories(dir);
      foreach (string subdirectory in subdirectoryEntries)
      {
        string nameDir = Path.GetFileName(subdirectory);
        if (nameDir.Contains("["))
        {
          LoadSubDirs(subdirectory);
        }
        else
        {
          insertRow(ref dgvList, Path.GetFileName(subdirectory));
        }
      }
    }

    private void insertRow(ref DataGridView dgv, string textSub)
    {
      dgv.Rows.Add(textSub, true, false, "start");
    }

   
    public string prepareText()
    {
      StringBuilder myClipboard = new StringBuilder();
      string comment = "";
      string appText = "";
      foreach (DataGridViewRow row in dgvList.Rows)
      {
        comment = "";
        if (row.Cells[1].Value != null)
        {
          if ((bool)row.Cells[1].Value)
          {
            if ((bool)row.Cells[2].Value)
            {
              comment = "# ";
            }
            appText = comment + row.Cells[3].Value + " " + row.Cells[0].Value;
            myClipboard.Append(appText + "\n");
          }
        }
      }
      return myClipboard.ToString();
    }

    public void writeFile()
    {
      string fileName = pathRootName + "\\ResourceToStart.txt";

      if (!File.Exists(fileName))
      {
        // Create a file to write to.
        using (StreamWriter sw = File.CreateText(fileName))
        {
          sw.WriteLine(prepareText());
        }
      }
      else
      {
        DialogResult myRes = MessageBox.Show("Would do you want overwrite an exist file?", "Attention!", MessageBoxButtons.YesNo);
        if (myRes == DialogResult.Yes)
        {
          File.Delete(fileName);
          writeFile();
        }
      }
    }

    private void aBCToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem tmp = (ToolStripMenuItem)sender;

      bool value = tmp.AccessibilityObject.Name == "> Includi tutti ";


      foreach (DataGridViewRow row in dgvList.Rows)
      {

        row.Cells[1].Value = value;


      }


    }
  }
}
