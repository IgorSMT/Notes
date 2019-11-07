using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Notes.VievModel;

namespace Notes.ViewModel
{
    /// <summary>
    /// 
    /// </summary>
    public class LabelViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private LabelModel labelmodel;

        public LabelViewModel()
        {
            labelmodel = new LabelModel();
        }

        public string Label
        {
            get { return labelmodel.Label; }
            set
            {
                if (labelmodel.Label != value)
                {
                    labelmodel.Label = value;
                    OnPropertyChanged("Label");
                }
            }
        }

        public DateTime Date
        {
            get { return labelmodel.Date; }
            set
            {
                if (labelmodel.Date != value)
                {
                    labelmodel.Date = value;
                    OnPropertyChanged("Date");
                }
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
