namespace NovelCsam.UI.Maui;

public partial class ResultsPage : ContentPage
{

	public ResultsPage()
	{
		InitializeComponent();
	}
    
	// There should be two tabs on the main page. The first tab is to upload files for analysis. The second tab is to
	// view the results of the analysis.
    //
	// The user may then click 'Analyze' to begin the analysis. Each file that was selected will be moved to the
	// 'Results' tab, where the user can view the results of the analysis. For each file, the UI will show the current
	// progress of the analysis, and when complete, the user may click a button to download the results of the analysis.

}

