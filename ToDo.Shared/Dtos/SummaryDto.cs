using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Shared.Dtos
{
    /// <summary>
    /// Özet
    /// </summary>
    public class SummaryDto : BaseDto
    {
        private int sum;
        private int completedCount;
        private int memoeCount;
        private string completedRatio;


        /// <summary>
        /// ToDo
        /// </summary>
        public int Sum
        {
            get { return sum; }
            set { sum = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Tamamlanan
        /// </summary>
        public int CompletedCount
        {
            get { return completedCount; }
            set { completedCount = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Not Sayısı
        /// </summary>
        public int MemoeCount
        {
            get { return memoeCount; }
            set { memoeCount = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Tamamlanma Oranı
        /// </summary>
        public string CompletedRatio
        {
            get { return completedRatio; }
            set { completedRatio = value; OnPropertyChanged(); }
        }

        private ObservableCollection<ToDoDto> todoList;
        private ObservableCollection<MemoDto> memoList;

        /// <summary>
        /// To Do list
        /// </summary>
        public ObservableCollection<ToDoDto> ToDoList
        {
            get { return todoList; }
            set { todoList = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Not listesi
        /// </summary>
        public ObservableCollection<MemoDto> MemoList
        {
            get { return memoList; }
            set { memoList = value; OnPropertyChanged(); }
        }
    }
}
