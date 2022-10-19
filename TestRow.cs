using System;
using System.ComponentModel;
using System.Diagnostics;

namespace EditingServiceBug
{
    internal class TestRow : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        static int InstanceCounter { get; set; } = 0;

        public int InstanceId { get; private set; }

        public TestRow()
        {
            InstanceId = InstanceCounter++;
            Debug.WriteLine($"TestRow() instanceId={InstanceId}");
        }

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
                    Debug.WriteLine($"TestRow.MvvmProperty={value} instanceId={InstanceId}");
                }
            }
        }

        private string NonMvvmPropertyValue { get; set; }

        public string NonMvvmProperty
        {
            get => NonMvvmPropertyValue; 
            set
            {
                if (value != NonMvvmPropertyValue)
                {
                    NonMvvmPropertyValue = value;
                    Debug.WriteLine($"TestRow.NonMvvmProperty={value} instanceId={InstanceId}");
                }
            }
        }
    }
}
