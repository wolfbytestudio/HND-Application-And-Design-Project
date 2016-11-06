using FinalPoject.com.hotel;
using FinalPoject.com.hotel.room;
using FinalPoject.com.people;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPoject.com
{
    /// <summary>
    /// The library object contains a instance of it's class
    /// this class is privare so external classes need to use the instance
    /// 
    /// This class contains the people, transactions list and hotels
    /// 
    /// Author - Zack Davidson - 30008095
    /// </summary>
    public class Library
    {

        /// <summary>
        /// The Library instance
        /// </summary>
        public static Library library = new Library();

        /// <summary>
        /// The library Getter
        /// </summary>
        public static Library Get
        {
            get { return library; }
        }

        /// <summary>
        /// The list of people
        /// </summary>
        private List<Person> people;

        /// <summary>
        /// The list of transactions
        /// </summary>
        private List<Transaction> transactions;

        /// <summary>
        /// The hotel object
        /// </summary>
        private Hotel hotel;

        /// <summary>
        /// Private Constructor to stop outer classes from initializing
        /// </summary>
        private Library()
        {
            people = new List<Person>();
            transactions = new List<Transaction>();
            hotel = new Hotel("Simply Hoteliers");
        }

        /// <summary>
        /// Loads all the content and replaces the data objects
        /// from the corresponding files
        /// </summary>
        public void initialize()
        {
            loadContent();
        }

        /// <summary>
        /// Populates the people list with people
        /// </summary>
        public void populate()
        {
            Person zack = new Person("Zack", "password123", "0124531211", PersonType.ADMINISTRATOR)
                .withAddress(new Address("St Andrew Road", "Glasgow", "G6", "1"))
                .withBalance(10000)
                .withDiscount(0.50F);

            Person james = new Person("James Duncan", "dogs", "0562", PersonType.GUEST)
                .withAddress(new Address("kilcross avanue", "Glasgow", "G1", "68"))
                .withBalance(1200)
                .withDiscount(0.10F);

            people.Add(zack);
            people.Add(james);

            
        }

        /// <summary>
        /// Saves all the content of library the corresponding files
        /// </summary>
        public void saveContent()
        {
            JsonManager.save(Person.FILE, people);
            JsonManager.save(Transaction.FILE, transactions);
            JsonManager.save(Hotel.FILE, hotel);
        }

        /// <summary>
        /// Loads all the library content to the corresponding files
        /// </summary>
        private void loadContent()
        {
            people = (List<Person>) JsonManager.load<List<Person>>(Person.FILE);
            transactions = (List<Transaction>) JsonManager.load<List<Transaction>>(Transaction.FILE);
            hotel = (Hotel) JsonManager.load<Hotel>(Hotel.FILE);
        }

        /// <summary>
        /// Requests a login
        /// </summary>
        /// <param name="id">the member id</param>
        /// <param name="password">the users password</param>
        /// <returns>true if the id and password match</returns>
        public bool login(string id, string password)
        {
            if(id == "" || password == "")
            {
                throw new Exception("You must enter a UserId and Password");
            }

            Person p = getPersonById(int.Parse(id));

            if (p == null) { return false; }
                
            if (password == p.Password)
            {
                return true;
            }
                
            return false;
        }

        /// <summary>
        /// Adds a transaction to the list
        /// </summary>
        /// <param name="transaction">The transaction object</param>
        public void addTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
        }

        /// <summary>
        /// Adds a bedroom to the bedroom list
        /// </summary>
        /// <param name="bedRoom">the bedroom</param>
        /// <returns></returns>
        public bool addRoom(BedRoom bedRoom)
        {
            foreach (BedRoom b in hotel.Rooms)
            {
                if (bedRoom.RoomId == b.RoomId)
                    return false;
            }

            hotel.Rooms.Add(bedRoom);
            return true;
        }

        /// <summary>
        /// Gets the amount of rooms with a specific roomcount
        /// </summary>
        /// <param name="rooms">the amount of rooms</param>
        /// <returns>the amount of rooms with the specific room count</returns>
        public int getRoomCount(int rooms)
        {
            int counter = 0;
            foreach (BedRoom b in hotel.Rooms)
            {
                Console.WriteLine(b.RoomCount + "\t" + rooms);
                if (b.RoomCount == rooms)
                    counter++;
            }

            return counter;
        }

        /// <summary>
        /// Adds a person to the list
        /// </summary>
        /// <param name="person">The person we are adding</param>
        public void addPerson(Person person)
        {
            
            people.Add(person);
            Console.WriteLine("added " + person.MemberId);
        }

        /// <summary>
        /// Sets the indexed person's deleted boolean to true
        /// </summary>
        /// <param name="index">the indexed person</param>
        public void deletePerson(int index)
        {
            people[index].Deleted = true;
        }

        /// <summary>
        /// Gets a person by their id
        /// </summary>
        /// <param name="memberId">The persons id</param>
        /// <returns>the person object</returns>
        public Person getPersonById(int id)
        {
            foreach (Person p in people)
            {
                if (p.MemberId == id)
                    return p;
            }

            return null;
        }

        /// <summary>
        /// Getter + Setter for people
        /// </summary>
        public List<Person> People
        {
            get { return people; }
            set { people = value; }
        }

        /// <summary>
        /// Getter + Setter for transactions
        /// </summary>
        public List<Transaction> Transactions
        {
            get { return transactions; }
            set { transactions = value; }
        }

        /// <summary>
        /// Getter + Setter for hotel
        /// </summary>
        public Hotel _Hotel
        {
            get { return hotel; }
            set { hotel = value; }
        }

    }
}
