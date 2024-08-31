namespace HelloWorldWinFormsApp;

partial class HelloWorldForm
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
        if(disposing && (components != null))
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
        firstNameLabel = new Label();
        firstNameTextBox = new TextBox();
        lastNameTextBox = new TextBox();
        lasyNamelabel = new Label();
        provinceLabel = new Label();
        helplinkLabel = new LinkLabel();
        closeButton = new Button();
        residentCheckBox = new CheckBox();
        provinceComboBox = new ComboBox();
        dateOfBirthDateTimePicker = new DateTimePicker();
        dateofBirthlabel = new Label();
        clearButton = new Button();
        detailsGroupBox = new GroupBox();
        optionsGroupBox = new GroupBox();
        detailsGroupBox.SuspendLayout();
        optionsGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // firstNameLabel
        // 
        firstNameLabel.AutoSize = true;
        firstNameLabel.Location = new Point(12, 43);
        firstNameLabel.Name = "firstNameLabel";
        firstNameLabel.Size = new Size(97, 25);
        firstNameLabel.TabIndex = 0;
        firstNameLabel.Text = "First Name";
        // 
        // firstNameTextBox
        // 
        firstNameTextBox.Location = new Point(130, 43);
        firstNameTextBox.Name = "firstNameTextBox";
        firstNameTextBox.Size = new Size(250, 31);
        firstNameTextBox.TabIndex = 1;
        // 
        // lastNameTextBox
        // 
        lastNameTextBox.Location = new Point(130, 80);
        lastNameTextBox.Name = "lastNameTextBox";
        lastNameTextBox.Size = new Size(250, 31);
        lastNameTextBox.TabIndex = 3;
        // 
        // lasyNamelabel
        // 
        lasyNamelabel.AutoSize = true;
        lasyNamelabel.Location = new Point(12, 80);
        lasyNamelabel.Name = "lasyNamelabel";
        lasyNamelabel.Size = new Size(95, 25);
        lasyNamelabel.TabIndex = 2;
        lasyNamelabel.Text = "Last Name";
        // 
        // provinceLabel
        // 
        provinceLabel.AutoSize = true;
        provinceLabel.Location = new Point(12, 117);
        provinceLabel.Name = "provinceLabel";
        provinceLabel.Size = new Size(79, 25);
        provinceLabel.TabIndex = 4;
        provinceLabel.Text = "Province";
        // 
        // helplinkLabel
        // 
        helplinkLabel.AutoSize = true;
        helplinkLabel.Location = new Point(330, 34);
        helplinkLabel.Name = "helplinkLabel";
        helplinkLabel.Size = new Size(49, 25);
        helplinkLabel.TabIndex = 2;
        helplinkLabel.TabStop = true;
        helplinkLabel.Text = "Help";
        helplinkLabel.LinkClicked += HelpLinkLabel_LinkClicked;
        // 
        // closeButton
        // 
        closeButton.Location = new Point(130, 30);
        closeButton.Name = "closeButton";
        closeButton.Size = new Size(94, 29);
        closeButton.TabIndex = 0;
        closeButton.Text = "Close";
        closeButton.UseVisualStyleBackColor = true;
        closeButton.Click += CloseButton_Click;
        // 
        // residentCheckBox
        // 
        residentCheckBox.AutoSize = true;
        residentCheckBox.Location = new Point(12, 188);
        residentCheckBox.Name = "residentCheckBox";
        residentCheckBox.RightToLeft = RightToLeft.Yes;
        residentCheckBox.Size = new Size(101, 29);
        residentCheckBox.TabIndex = 8;
        residentCheckBox.Text = "Resident";
        residentCheckBox.UseVisualStyleBackColor = true;
        // 
        // provinceComboBox
        // 
        provinceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        provinceComboBox.FormattingEnabled = true;
        provinceComboBox.Items.AddRange(new object[] { "Connacht", "Leinster", "Munster", "Ulster" });
        provinceComboBox.Location = new Point(130, 114);
        provinceComboBox.Name = "provinceComboBox";
        provinceComboBox.Size = new Size(250, 33);
        provinceComboBox.TabIndex = 5;
        // 
        // dateOfBirthDateTimePicker
        // 
        dateOfBirthDateTimePicker.Location = new Point(130, 153);
        dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
        dateOfBirthDateTimePicker.Size = new Size(250, 31);
        dateOfBirthDateTimePicker.TabIndex = 7;
        // 
        // dateofBirthlabel
        // 
        dateofBirthlabel.AutoSize = true;
        dateofBirthlabel.Location = new Point(12, 153);
        dateofBirthlabel.Name = "dateofBirthlabel";
        dateofBirthlabel.Size = new Size(112, 25);
        dateofBirthlabel.TabIndex = 6;
        dateofBirthlabel.Text = "Date of Birth";
        // 
        // clearButton
        // 
        clearButton.Location = new Point(230, 30);
        clearButton.Name = "clearButton";
        clearButton.Size = new Size(94, 29);
        clearButton.TabIndex = 1;
        clearButton.Text = "Clear";
        clearButton.UseVisualStyleBackColor = true;
        clearButton.Click += ClearButton_Click;
        // 
        // detailsGroupBox
        // 
        detailsGroupBox.Controls.Add(provinceComboBox);
        detailsGroupBox.Controls.Add(firstNameLabel);
        detailsGroupBox.Controls.Add(firstNameTextBox);
        detailsGroupBox.Controls.Add(dateofBirthlabel);
        detailsGroupBox.Controls.Add(lastNameTextBox);
        detailsGroupBox.Controls.Add(dateOfBirthDateTimePicker);
        detailsGroupBox.Controls.Add(lasyNamelabel);
        detailsGroupBox.Controls.Add(provinceLabel);
        detailsGroupBox.Controls.Add(residentCheckBox);
        detailsGroupBox.Location = new Point(12, 12);
        detailsGroupBox.Name = "detailsGroupBox";
        detailsGroupBox.Size = new Size(407, 234);
        detailsGroupBox.TabIndex = 0;
        detailsGroupBox.TabStop = false;
        detailsGroupBox.Text = "Details";
        // 
        // optionsGroupBox
        // 
        optionsGroupBox.Controls.Add(closeButton);
        optionsGroupBox.Controls.Add(helplinkLabel);
        optionsGroupBox.Controls.Add(clearButton);
        optionsGroupBox.Location = new Point(12, 252);
        optionsGroupBox.Name = "optionsGroupBox";
        optionsGroupBox.Size = new Size(404, 85);
        optionsGroupBox.TabIndex = 1;
        optionsGroupBox.TabStop = false;
        optionsGroupBox.Text = "Options";
        // 
        // HelloWorldForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(440, 361);
        Controls.Add(optionsGroupBox);
        Controls.Add(detailsGroupBox);
        Name = "HelloWorldForm";
        Text = "Hello World Form";
        detailsGroupBox.ResumeLayout(false);
        detailsGroupBox.PerformLayout();
        optionsGroupBox.ResumeLayout(false);
        optionsGroupBox.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label firstNameLabel;
    private TextBox firstNameTextBox;
    private TextBox lastNameTextBox;
    private Label lasyNamelabel;
    private Label provinceLabel;
    private LinkLabel helplinkLabel;
    private Button closeButton;
    private CheckBox residentCheckBox;
    private ComboBox provinceComboBox;
    private DateTimePicker dateOfBirthDateTimePicker;
    private Label dateofBirthlabel;
    private Button clearButton;
    private GroupBox detailsGroupBox;
    private GroupBox optionsGroupBox;
}
