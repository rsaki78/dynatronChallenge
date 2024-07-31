using Dyna.API.Data;
using Dyna.API.Models;

namespace Dyna.API.Extensions
{
    public class DataSeeder
    {
        private CustomerContext _customerContext;

        public DataSeeder(CustomerContext customerContext)
        {
            _customerContext = customerContext;
        }

        public void SeedData()
        {
            _customerContext.Customers.AddRange(GetTestData());
            _customerContext.SaveChanges();
        }

        List<Customer> GetTestData()
        {
            return new List<Customer>
            {
                new Customer() {Id=1, FirstName="Quinn", LastName="Craigs", Email="qcraigs0@vinaora.com", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=2, FirstName="Rutherford", LastName="Geraudel", Email="rgeraudel1@github.io", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=3, FirstName="Letizia", LastName="Walklett", Email="lwalklett2@washington.edu", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=4, FirstName="Ronni", LastName="Duce", Email="rduce3@senate.gov", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=5, FirstName="Babette", LastName="Bernaldo", Email="bbernaldo4@ezinearticles.com", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=6, FirstName="Berry", LastName="Martellini", Email="bmartellini5@jiathis.com", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=7, FirstName="Audrye", LastName="Olden", Email="aolden6@yelp.com", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=8, FirstName="Madge", LastName="Kinset", Email="mkinset7@gov.uk", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=9, FirstName="Siegfried", LastName="Heugle", Email="sheugle8@toplist.cz", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=10, FirstName="Beilul", LastName="Bredes", Email="bbredes9@icq.com", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=11, FirstName="Casey", LastName="Blackmoor", Email="cblackmoora@uol.com.br", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=12, FirstName="Glory", LastName="Steed", Email="gsteedb@bluehost.com", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=13, FirstName="Milty", LastName="Taggart", Email="mtaggartc@is.gd", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=14, FirstName="Arleta", LastName="Altofts", Email="aaltoftsd@google.com.br", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=15, FirstName="Laurice", LastName="Teager", Email="lteagere@miibeian.gov.cn", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=16, FirstName="Kiah", LastName="Coggins", Email="kcogginsf@discovery.com", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=17, FirstName="Giacobo", LastName="Ellingford", Email="gellingfordg@dedecms.com", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=18, FirstName="Elvin", LastName="Prosek", Email="eprosekh@epa.gov", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=19, FirstName="Sayer", LastName="Narrie", Email="snarriei@dailymail.co.uk", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=20, FirstName="Karita", LastName="Stillman", Email="kstillmanj@nydailynews.com", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=21, FirstName="Fiorenze", LastName="Paff", Email="fpaffk@ft.com", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=22, FirstName="Adey", LastName="Ivankovic", Email="aivankovicl@hud.gov", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=23, FirstName="Minette", LastName="Simioni", Email="msimionim@nbcnews.com", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=24, FirstName="Trevar", LastName="Michal", Email="tmichaln@amazon.de", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
                new Customer() {Id=25, FirstName="Martelle", LastName="Mendonca", Email="mmendoncao@scribd.com", CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now, IsActive = true },
            };
        }
    }
}
