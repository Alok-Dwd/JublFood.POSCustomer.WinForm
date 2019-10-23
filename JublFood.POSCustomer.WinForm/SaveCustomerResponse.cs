namespace JublFood.POSCustomer.WinForm
{
    public class SaveCustomerResponse
    {
        public SaveCustomerResult result { get; set; }
    }

    public class SaveCustomerResult
    {
        public string ResponseStatus { get; set; }
        public string ResponseStatusCode { get; set; }

    }
}
