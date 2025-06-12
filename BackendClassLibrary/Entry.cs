using System.ComponentModel;

namespace bakk_project_task 
{
    public class Entry(string name, char tag, long id = -1) : INotifyPropertyChanged
    {
        public string Name { get; set; } = name;
        [ReadOnly(true)]
        public char Tag { get; set; } = tag;
        [Browsable(false)]
        public long Id { get; set; } = id;

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}