using System.Net.NetworkInformation;
using System.Security.Cryptography;

namespace Task3.BL
{
    public class Flat
    {
        int id;
        string city;
        string address;
        double price;
        int numberOfRooms;

        //static List<Flat> FlatsList = new List<Flat>();
        public static List<Flat> FlatsList = new List<Flat>();

        public Flat(int id, string city, string address, double price, int numberOfRooms)
        {
            Id = id;
            City = city;
            Address = address;
            Price = price;
            NumberOfRooms = numberOfRooms;
        }
        public Flat()
        {

        }

        public int Id { get => id; set => id = value; }
        public string City { get => city; set => city = value; }
        public string Address { get => address; set => address = value; }
        public int NumberOfRooms { get => numberOfRooms; set => numberOfRooms = value; }

        public double Price { get => price; set => price = value; }
  

        public bool Insert()
        {           
            if (!FlatsList.Exists(flat => flat.Id == this.Id))
            {
                Discount(this);
                DBservices dbs = new DBservices();
                dbs.Insert(this);
                return true;
            }
            return false;
        }
        public List<Flat> Read()
        {
            DBservices dbs = new DBservices();
            return dbs.ReadFlats();
        }

        public void Discount(Flat flat)
        {
            if (flat.numberOfRooms > 1 && flat.Price > 100)
            {
                 flat.Price *= 0.9;
            }
        }

        public List<Flat> ReadByPriceAndCity(double price, string city)
        {
            List<Flat> tempFlat = new List<Flat>();
            foreach (Flat flat in FlatsList)
            {
                if (flat.price <= price && flat.city == city)
                {
                    tempFlat.Add(flat);
                }
            }
            return tempFlat;
        }
    }

}
