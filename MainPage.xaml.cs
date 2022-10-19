using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Windows.UI.Xaml.Controls;

namespace EditingServiceBug
{
    public sealed partial class MainPage : Page
    {
        // A few rows of sample data.
        ObservableCollection<TestRow> TestCollection = new ObservableCollection<TestRow>()
        {
            new TestRow { MvvmProperty = "A", NonMvvmProperty = "B" },
            new TestRow { MvvmProperty = "C", NonMvvmProperty = "D" },
            new TestRow { MvvmProperty = "E", NonMvvmProperty = "F" },
            new TestRow { MvvmProperty = "G", NonMvvmProperty = "H" },
            new TestRow { MvvmProperty = "I", NonMvvmProperty = "J" },
            new TestRow { MvvmProperty = "K", NonMvvmProperty = "L" },
            new TestRow { MvvmProperty = "M", NonMvvmProperty = "N" },
            new TestRow { MvvmProperty = "O", NonMvvmProperty = "P" },
            new TestRow { MvvmProperty = "Q", NonMvvmProperty = "R" },
            new TestRow { MvvmProperty = "S", NonMvvmProperty = "T" },
            new TestRow { MvvmProperty = "U", NonMvvmProperty = "V" },
            new TestRow { MvvmProperty = "W", NonMvvmProperty = "X" },
            new TestRow { MvvmProperty = "Y", NonMvvmProperty = "Z" },
        };

        public MainPage()
        {
            this.InitializeComponent();

            foreach (var row in TestCollection)
            {
                row.PropertyChanged += Row_PropertyChanged;
            }

            DataGrid.ItemsSource = TestCollection;
        }

        private void Row_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (sender is TestRow row)
            {
                Debug.WriteLine($"TestRow.PropertyChanged: property={e.PropertyName} value={row.MvvmProperty} instanceId={row.InstanceId}");
            }
        }
    }
}
