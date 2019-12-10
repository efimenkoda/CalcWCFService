using My05_WPF_UI.CalcBusinessLogicProxy;
using My05_WPF_UI.View.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My05_WPF_UI
{
    class CalcViewModel: INotifyPropertyChanged
    {
        public int X { get; set; }
        public int Y { get; set; }
        private int z;
        public int Z
        {
            get { return z; }
            set
            {
                z = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Z"));
            }
        }

        private RelayCommand calcCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        public RelayCommand CalcCommand
        {
            get
            {
                return calcCommand ?? (calcCommand = new RelayCommand(obj =>
                  {
                      CalcBusinessLogicClient
                        proxy = new CalcBusinessLogicClient("HTTPEndpoint");
                      if (obj.ToString() == "plus")
                      {
                          Z = proxy.Plus(X, Y);
                      }
                                           
                    if (obj.ToString() == "minus")
                    {
                        Z = proxy.Minus(X, Y);
                    }                     

                      
                  }
                ));
            }
        }

    }
}
