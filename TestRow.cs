using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    value = MvvmPropertyValue;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MvvmProperty)));
                }
            }
        }

        public string NonMvvmProperty { get; set; }
    }
}
