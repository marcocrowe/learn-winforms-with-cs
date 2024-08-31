namespace HelloWorldWinFormsApp;

/// <summary>
/// HelloWorldForm
/// </summary>
public partial class HelloWorldForm : Form
{

    /// <summary>
    /// My GitHub URL for help
    /// </summary>
    private const String HelpLink = "https://github.com/marcocrowe/WinForms-Refactor-Repair-Assignment.cs)";

    /// <summary>
    /// Constructor
    /// </summary>
    public HelloWorldForm() => InitializeComponent();

    /// <summary>
    /// Close Button Click Event
    /// </summary>
    /// <param name="sender">The Sender</param>
    /// <param name="e">The Event</param>
    private void CloseButton_Click(object sender, EventArgs e) => Close();

    /// <summary>
    /// Clear Button Click Event
    /// </summary>
    /// <param name="sender">The Sender</param>
    /// <param name="e">The Event</param>
    private void ClearButton_Click(object sender, EventArgs e)
    {
        firstNameTextBox.Text = string.Empty;
        lastNameTextBox.Text = string.Empty;
        provinceComboBox.SelectedIndex = -1;
        residentCheckBox.Checked = false;
        dateOfBirthDateTimePicker.Value = DateTime.Now;
    }
    /// <summary>
    /// Help Link Label Click Event
    /// </summary>
    /// <param name="sender">The Sender</param>
    /// <param name="e">The Link Label Click Event</param>
    private void HelpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        System.Diagnostics.Process.Start(HelpLink);
    }
}
