using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Walker.DataAccess;

namespace Walker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly TubesheetViewModel _dataContext;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _dataContext = new TubesheetViewModel(new TubeLoader());
        }

        private void TubeSheetGrid_Loaded(object sender, RoutedEventArgs e)
        {
            var tubeGrid = sender as Grid;

            if (tubeGrid != null)
            {
                var cols = _dataContext.TubesheetData.Tubes.Max(tube => tube.Column);
                var rows = _dataContext.TubesheetData.Tubes.Max(tube => tube.Row);

                if (cols == rows)
                {
                    for (int i = 0; i <= cols; i++)
                    {
                        tubeGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
                        tubeGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                    }
                }
            }
        }
    }
}
