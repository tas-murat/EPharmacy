namespace EPharmacy.WebUI.Extensions
{
    public class NotFoundExceptionMessage : Exception
    {
        public NotFoundExceptionMessage(string message) : base(message) { }
    }
}
