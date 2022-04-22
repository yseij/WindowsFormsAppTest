namespace WindowsFormsAppTest
{
    class KlantData : IBaseData
    {
        public KlantData(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
