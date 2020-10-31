using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Models;
using MessageBox = System.Windows.Forms.MessageBox;

namespace WpfApp1.ViewModel
{
    class SheetViewModel 
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
                           MessageBox.Show("Test");
                       }));
            }
        }

        public SpesSheetModel SelectedSheet
        {
            get { return selectedSheetModel; }
            set
            {
                selectedSheetModel = value;
                //OnPropertyChanged("SelectedSheet");
            }
        }

        public SheetViewModel()
        {
            Sheets = new ObservableCollection<SpesSheetModel>
            {
                new SpesSheetModel {SheetNumber = "7", DocNumber = "77",DocTitleEng = "title1"},
                new SpesSheetModel {SheetNumber = "1", DocNumber = "12", DocTitleEng = "title2"},
                new SpesSheetModel {SheetNumber = "3", DocNumber = "34", DocTitleEng = "title3"},
                new SpesSheetModel {SheetNumber = "2", DocNumber = "25", DocTitleEng = "title4"},
                new SpesSheetModel {SheetNumber = "3", DocNumber = "36", DocTitleEng = "title4"}
            };
        }
        //TODO command to button


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
