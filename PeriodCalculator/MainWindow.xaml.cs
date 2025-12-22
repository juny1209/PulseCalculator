namespace PeriodCalculator;

public partial class MainWindow
{
	private readonly System.Diagnostics.Stopwatch _stopwatch = new();

	public MainWindow()
	{
		InitializeComponent();

		_stopwatch.Start();
	}

	private void Button1_Click(object sender, System.Windows.RoutedEventArgs e)
	{
		Button1.Content = $"{_stopwatch.ElapsedMilliseconds}ms";
		_stopwatch.Restart();
	}
}
