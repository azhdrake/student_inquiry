namespace StudentEnquiry
{
  partial class Form1
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
      this.cbxDepartment = new System.Windows.Forms.ComboBox();
      this.lstDegree = new System.Windows.Forms.ListBox();
      this.cbxHowHeard = new System.Windows.Forms.ComboBox();
      this.btnSubmit = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lblDegreeCount = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cbxDepartment
      // 
      this.cbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxDepartment.FormattingEnabled = true;
      this.cbxDepartment.Location = new System.Drawing.Point(79, 65);
      this.cbxDepartment.Name = "cbxDepartment";
      this.cbxDepartment.Size = new System.Drawing.Size(617, 33);
      this.cbxDepartment.Sorted = true;
      this.cbxDepartment.TabIndex = 0;
      this.cbxDepartment.SelectedIndexChanged += new System.EventHandler(this.cbxDepartment_SelectedIndexChanged);
      // 
      // lstDegree
      // 
      this.lstDegree.FormattingEnabled = true;
      this.lstDegree.ItemHeight = 25;
      this.lstDegree.Location = new System.Drawing.Point(79, 142);
      this.lstDegree.Name = "lstDegree";
      this.lstDegree.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
      this.lstDegree.Size = new System.Drawing.Size(617, 154);
      this.lstDegree.Sorted = true;
      this.lstDegree.TabIndex = 1;
      this.lstDegree.SelectedIndexChanged += new System.EventHandler(this.lstDegree_SelectedIndexChanged);
      // 
      // cbxHowHeard
      // 
      this.cbxHowHeard.FormattingEnabled = true;
      this.cbxHowHeard.Location = new System.Drawing.Point(79, 339);
      this.cbxHowHeard.Name = "cbxHowHeard";
      this.cbxHowHeard.Size = new System.Drawing.Size(617, 33);
      this.cbxHowHeard.TabIndex = 2;
      // 
      // btnSubmit
      // 
      this.btnSubmit.Location = new System.Drawing.Point(343, 397);
      this.btnSubmit.Name = "btnSubmit";
      this.btnSubmit.Size = new System.Drawing.Size(121, 41);
      this.btnSubmit.TabIndex = 3;
      this.btnSubmit.Text = "Submit";
      this.btnSubmit.UseVisualStyleBackColor = true;
      this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(74, 37);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(400, 25);
      this.label1.TabIndex = 4;
      this.label1.Text = "Which department are you interested in?";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(74, 114);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(360, 25);
      this.label2.TabIndex = 5;
      this.label2.Text = "What degrees are you interested in?";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(74, 311);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(280, 25);
      this.label3.TabIndex = 6;
      this.label3.Text = "How did you hear about us?";
      // 
      // lblDegreeCount
      // 
      this.lblDegreeCount.AutoSize = true;
      this.lblDegreeCount.Location = new System.Drawing.Point(585, 299);
      this.lblDegreeCount.Name = "lblDegreeCount";
      this.lblDegreeCount.Size = new System.Drawing.Size(111, 25);
      this.lblDegreeCount.TabIndex = 7;
      this.lblDegreeCount.Text = "0 selected";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.lblDegreeCount);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnSubmit);
      this.Controls.Add(this.cbxHowHeard);
      this.Controls.Add(this.lstDegree);
      this.Controls.Add(this.cbxDepartment);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.ListBox lstDegree;
        private System.Windows.Forms.ComboBox cbxHowHeard;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDegreeCount;
    }
}

