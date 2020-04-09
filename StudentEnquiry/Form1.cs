using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEnquiry
{
  public partial class Form1 : Form
  {
    SortedList<string, string[]> programs;

    string[] ITPrograms = { "Progamming", "Security", "Networking" };
    string[] EngineeringPrograms = { "Mechanical", "Electrical", "Chemical", "Material" };
    public Form1()
    {
      InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e)
    {
      // set up.
      programs = new SortedList<string, string[]>
      {
        {"Information Technology", ITPrograms },
        {"Engineeing", EngineeringPrograms }
      };

      cbxDepartment.Items.AddRange(programs.Keys.ToArray());
      cbxDepartment.SelectedIndex = 0;

      cbxHowHeard.Items.Add("Another Student");
      cbxHowHeard.Items.Add("Another School");
      cbxHowHeard.Items.Add("Internet Search");
    }

    private void btnSubmit_Click(object sender, EventArgs e)
    {
      List<string> errors = new List<string>();

      // data validation
      if (cbxDepartment.SelectedIndex == -1)
      {
        errors.Add("Select a Dempartment.");
      }
      
      if (lstDegree.SelectedIndex == -1)
      {
        errors.Add("Select at least one degree.");
      }

      if (String.IsNullOrEmpty(cbxHowHeard.Text))
      {
        errors.Add("Please tell us how you heard about us.");
      }

      if(errors.Count > 0)
      {
        MessageBox.Show(String.Join("\n", errors), "Errors");
        return;
      }

      // Enter the summary.
      StringBuilder summaryBuilder = new StringBuilder();

      summaryBuilder.Append("Summary");
      summaryBuilder.Append("\n\nDepartment:\n");
      summaryBuilder.Append(cbxDepartment.Text);
      summaryBuilder.Append("\n\nPrograms:\n");

      foreach (object degree in lstDegree.SelectedItems) 
      {
        summaryBuilder.Append(degree + "\n");
      }

      summaryBuilder.Append("\nHow you heard about us:\n");
      summaryBuilder.Append(cbxHowHeard.Text);

      string summary = summaryBuilder.ToString();

      MessageBox.Show(summary, "Thank you!");

      this.Close();
    }

    

    private void cbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
    {
      // setting the listbox based on what's in the combobox
      lstDegree.ClearSelected();
      lstDegree.Items.Clear();
      string department = cbxDepartment.Text;

      if (department != null)
      {
        string[] degrees = programs[department];
        lstDegree.Items.AddRange(degrees);
      }
    }

    private void lstDegree_SelectedIndexChanged(object sender, EventArgs e)
    {
      // ♫♪♪ adding feedback, adding adding feedback. You take the input and give the user feedback. ♫♪♪
      int numSelected = lstDegree.SelectedItems.Count;
      lblDegreeCount.Text = $"{numSelected} selected";
    }
  }
}
