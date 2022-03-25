namespace WindowsFormsAppTest
{
    class WebServiceData
    {
        public WebServiceData()
        {
        }

        public WebServiceData(int id, string name, bool soap)
            : this()
        {
            Id = id;
            Name = name;
            Soap = soap;
        }

        public int Id { get; }
        public string Name { get; set; }

        public bool Soap { get; set; }
    }
}
