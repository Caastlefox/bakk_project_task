using System.ComponentModel;

namespace bakk_project_task
{
    public class Entry(string name, char tag, long entryid , long id = -1)
    {
        public string Name { get; set; } = name;
        public char Tag { get; set; } = tag;
        [Browsable(false)]
        public long Id { get; set; } = id;
        [Browsable(false)]
        public long EntryId { get; set; } = entryid;
        [Browsable(false)]
        public string EntryName => Name;
    }

}