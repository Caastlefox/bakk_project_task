namespace bakk_project_task
{
    public class Entry(string name, char tag, long id = -1)
    {
        public string Name { get; set; } = name;
        public char Tag { get; set; } = tag;
        public long Id { get; set; } = id;
        public string EntryName => Name;
    }

}