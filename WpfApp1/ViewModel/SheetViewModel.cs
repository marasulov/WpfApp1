using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.ViewModel
{
    class SheetViewModel : INotifyPropertyChanged
    {
        private SpesSheetModel selectedSheetModel;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<SpesSheetModel> Sheets { get; set; }

        private RelayCommand addCommand;

        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                       (addCommand = new RelayCommand(obj =>
                       {
                           SpesSheetModel sheet = new SpesSheetModel();
                           Sheets.Insert(0, sheet);
                           SelectedSheet = sheet;
                       }));
            }
        }

        public SpesSheetModel SelectedSheet
        {
            get { return selectedSheetModel; }
            set
            {
                selectedSheetModel = value;
                OnPropertyChanged("SelectedSheet");
            }
        }

        public SheetViewModel()
        {
            Sheets = new ObservableCollection<SpesSheetModel>
            {
                new SpesSheetModel {SheetNumber = "7", DocNumber = "acaaa"},
                new SpesSheetModel {SheetNumber = "1", DocNumber = "acaasdsadaa"},
                new SpesSheetModel {SheetNumber = "3", DocNumber = "acaasadsada"},
                new SpesSheetModel {SheetNumber = "2", DocNumber = "acaasadsada"}
            };
        }

        /// <summary>
        /// Raises OnPropertychangedEvent when property changes
        /// </summary>
        /// <param name="name">String representing the property name</param>
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


    }

}
