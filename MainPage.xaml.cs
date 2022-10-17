using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;

namespace EditingServiceBug
{
    public sealed partial class MainPage : Page
    {
        // A few rows of sample data.
        ObservableCollection<TestRow> TestCollection = new ObservableCollection<TestRow>()
        {
            new TestRow { MvvmProperty = "A", NonMvvmProperty = "B" },
            new TestRow { MvvmProperty = "C", NonMvvmProperty = "D" }
        };

        public MainPage()
        {
            this.InitializeComponent();

            DataGrid.ItemsSource = TestCollection;
        }
    }
}
