namespace BooksAPI.Service
{
    public class MyService
    {
        public void showRequestDetails(string requestType, DateTime requestDateTime)
        {
            Console.WriteLine($"Une nouvelle requête de type {requestType} a été détectée à : {requestDateTime}");
        }
    }
}
