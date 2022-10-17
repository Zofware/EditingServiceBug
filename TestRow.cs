using System;
using System.ComponentModel;

namespace EditingServiceBug
{
    internal class TestRow : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string MvvmPropertyValue { get; set; }

        public string MvvmProperty
        {
            get => MvvmPropertyValue;
            set
            {
                if (value != MvvmPropertyValue)
                {
                    MvvmPropertyValue = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MvvmProperty)));
                }
            }
        }

        public string NonMvvmProperty { get; set; }
    }
}
