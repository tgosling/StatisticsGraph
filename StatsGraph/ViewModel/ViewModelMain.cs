using System.Collections.ObjectModel;
using StatsGraph.Helper;
using StatsGraph.Model;
using System.ComponentModel;


namespace StatsGraph.ViewModel
{
    class ViewModelMain : ViewModelBase, INotifyPropertyChanged
    {
        public ObservableCollection<StatsModel> OCData { get; set; }
        object _SelectedRow;
        public object SelectedRow
        {
            get
            {
                return _SelectedRow;
            }
            set
            {
                _SelectedRow = value;
                RaisePropertyChanged("SelectedRow");
            }
        }

        //TODO: Remove Selected Row
        private void RemoveRow(object obj)
        {

        }

        public ViewModelMain()
        {
            OCData = new ObservableCollection<StatsModel>();
        }
    }
}
