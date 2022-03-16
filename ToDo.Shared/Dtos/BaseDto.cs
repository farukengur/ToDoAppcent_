using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace ToDo.Shared.Dtos
{
    public class BaseDto : INotifyPropertyChanged
    {
        public int Id { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        
        public void OnPropertyChanged([CallerMemberName] string propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        

    }
}
