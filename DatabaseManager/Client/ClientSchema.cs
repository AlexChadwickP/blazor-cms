namespace DatabaseManager.Client
{
    public class ClientSchema
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }

        public ClientSchema(string firstName = "-", string lastName = "-", string email = "-", string phoneNumber = "-", string website = "-")
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Website = website;
        }
    }
}