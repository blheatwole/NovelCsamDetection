namespace NovelCsam.UI.Maui;

public partial class AnalyzePage : ContentPage
{

	public AnalyzePage()
	{
		InitializeComponent();
	}
    
	// There should be two tabs on the main page. The first tab is to upload files for analysis. The second tab is to
	// view the results of the analysis.
	//
	// On the first tab, the user can browse for files or drop a file into the app. The user may also choose or drop a
	// folder. The application will can the file/folder and find all image and video files, displaying the list of files
	// found below the file/folder selection.
	//
	// The user may then click a button next to each file to de-select it from the list. Before clicking 'Analyze', the
	// user may choose how many seconds between frames to analyze for videos. The user may also choose to enable text
	// summaries of each frame and/or to enable child detection.
	//
	// The user may then click 'Analyze' to begin the analysis. Each file that was selected will be moved to the
	// 'Results' tab, where the user can view the results of the analysis. For each file, the UI will show the current
	// progress of the analysis, and when complete, the user may click a button to download the results of the analysis.

}

