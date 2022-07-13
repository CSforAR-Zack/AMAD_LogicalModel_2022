namespace LogicalModel;

public partial class LogicalPage : ContentPage
{
	public LogicalPage()
	{
		InitializeComponent();
	}

	private void EvaluateBool(object sender, EventArgs args)
	{
		try
		{
            Button button = (Button)sender;

            if (button.Text == "True")
            {
                button.Text = "False";
				button.SetDynamicResource(BackgroundColorProperty, "OffState");
            }
            else
            {
                button.Text = "True";
                button.SetDynamicResource(BackgroundColorProperty, "OnState");
            }
        }
		catch(InvalidCastException ex)
		{

		}

		if (operatorPicker.SelectedItem == null) 
			return;

		string selectedO = operatorPicker.SelectedItem.ToString();

		if (selectedO == "AND")
			resultLabel.Text = (leftButton.Text == "True" && rightButton.Text == "True").ToString();
		else if(selectedO == "OR")
            resultLabel.Text = (leftButton.Text == "True" || rightButton.Text == "True").ToString();
        else if (selectedO == "XOR")
            resultLabel.Text = (leftButton.Text == "True" ^ rightButton.Text == "True").ToString();

		if (resultLabel.Text == "True")
			resultLabel.SetDynamicResource(BackgroundColorProperty, "OnState");
        else
			resultLabel.SetDynamicResource(BackgroundColorProperty, "OffState");

    }
}