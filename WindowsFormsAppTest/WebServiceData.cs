namespace WindowsFormsAppTest
{
    class WebServiceData
    {
        public WebServiceData()
        {
        }

        public WebServiceData(int id, string name)
            : this()
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; set; }
    }
}
