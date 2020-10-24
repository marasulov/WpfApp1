using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace WpfApp1.Models
{
    class SpesSheetModel : INotifyPropertyChanged
    {
        private List<string> repositoryData;

        private string sheetNumber;
        private string docNumber;
        private string objectNameEng;
        /// <summary>
        /// Номер листа
        /// </summary>
        public string SheetNumber
        {
            get
            {
                return sheetNumber;
            }
            set
            {
                sheetNumber = value;
                OnPropertyChanged("SheetNumber");
                
            }
        }

        /// <summary>
        /// Document Number
        /// </summary>
        public string DocNumber
        {
            get
            {
                return docNumber;
            }
            set
            {
                docNumber = value;
                OnPropertyChanged("SheetNumber");

            }
        }
        /// <summary>
        /// Document Name in English
        /// </summary>
        public string ObjectNameEng { get; set; }

        /// <summary>
        /// Document Title (English)
        /// </summary>
        public string DocTitleEng { get; set; }

        /// <summary>
        /// documnet name in rus
        /// </summary>
        public string ObjectNameRu { get; set; }
        /// <summary>
        /// Document Title (Rus)
        /// </summary>
        public string DocTitleRu { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public string ImportantInfo
        {
            get
            {
                return ConcatenateData(repositoryData);
            }
        }

        //public SpesSheetModel()
        //{
        //    repositoryData = GetData();
        //}

        /// <summary>
        /// Simulates data retrieval from a repository
        /// </summary>
        /// <returns>List of strings</returns>
        private List<string> GetData()
        {
            repositoryData = new List<string>()
            {
                "Hellossssss",
                "world"
            };
            return repositoryData;
        }

        /// <summary>
        /// Concatenate the information from the list into a fully formed sentence.
        /// </summary>
        /// <returns>A string</returns>
        private string ConcatenateData(List<string> dataList)
        {
            string importantInfo = dataList.ElementAt(0) + ", " + dataList.ElementAt(1) + "!";
            return importantInfo;
        }
    }
}
