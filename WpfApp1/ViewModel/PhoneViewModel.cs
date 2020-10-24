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
    class PhoneViewModel:INotifyPropertyChanged
    {

        
        
            private Phone selectedPhone;
            public ObservableCollection<Phone> Phones { get; set; }

            // команда добавления нового объекта
            private RelayCommand addCommand;
            public RelayCommand AddCommand
            {
                get
                {
                    return addCommand ??
                           (addCommand = new RelayCommand(obj =>
                           {
                               Phone phone = new Phone();
                               Phones.Insert(0, phone);
                               SelectedPhone = phone;
                           }));
                }
            }

            public Phone SelectedPhone
            {
                get { return selectedPhone; }
                set
                {
                    selectedPhone = value;
                    OnPropertyChanged("SelectedPhone");
                }
            }

            public PhoneViewModel()
            {
                Phones = new ObservableCollection<Phone>
                {
                    new Phone {Title="iPhone 7", Company="Apple", Price=56000 },
                    new Phone {Title="Galaxy S7 Edge", Company="Samsung", Price =60000 },
                    new Phone {Title="Elite x3", Company="HP", Price=56000 },
                    new Phone {Title="Mi5S", Company="Xiaomi", Price=35000 }
                };
            }

            public event PropertyChangedEventHandler PropertyChanged;
            public void OnPropertyChanged([CallerMemberName] string prop = "")
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        
    }
}
