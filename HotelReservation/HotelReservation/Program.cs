using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using CitiesOperation.Data;
using HotelOperation.data;
using HotelRoomsOperation.data;
using HotelReservation.Entities;
using CustomerOperations.data;
using BookingDetailsOperation.Data;
using LINQ_to_SQL;
using NLog;
using NLog.Targets.
using LogHandler;
namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            
            do
            {
                try
                {

                    //Displaying the choice to the user
                    Console.WriteLine("Enter your role");
                    Console.WriteLine("1. Customer");
                    Console.WriteLine("2. Agent");
                    int choice = 0;
                    bool selection = int.TryParse(Console.ReadLine(), out choice);


                    DataClasses1DataContext datacontext = new DataClasses1DataContext();


                    //Doing operations for valid input
                    if (selection && (choice == 1 || choice == 2))
                    {
                        switch (choice)
                        {
                            //For Costomer
                            case 1:

                                do
                                {
                                    Console.WriteLine("What do you want to do ?");
                                    Console.WriteLine("1. Check In");
                                    Console.WriteLine("2. Check Out");

                                    int check_in_out_choice = 0;
                                    bool check_in_out_choice_selection = int.TryParse(Console.ReadLine(), out check_in_out_choice);

                                    if (check_in_out_choice_selection && (check_in_out_choice == 1 || check_in_out_choice == 2))

                                    {
                                        switch (check_in_out_choice)
                                        {
                                            case 1:

                                                //Selection of City
                                                Console.WriteLine("Select the city code");

                                                //Using StoreProcedure and Methods
                                                //CitiesDBImpl citiesimpl = new CitiesDBImpl();
                                                //List<Cities> cities = citiesimpl.SelectCities();
                                                //for (int i = 0; i < cities.Count; i++)
                                                //{
                                                //    Console.WriteLine("{0}  {1}", cities[i].CityCode, cities[i].CityName);
                                                //}
                                                //int citicode = int.Parse(Console.ReadLine());
                                                //string citiname = cities[citicode - 1].CityName;


                                                //Using LinQ to SQL



                                                var CityDetails = datacontext.spShowCities();
                                                foreach (var city in CityDetails)
                                                {
                                                    Console.WriteLine("{0}  {1}", city.CityCode, city.CityName);
                                                }
                                                Int64 citicode = Convert.ToInt64(Console.ReadLine().ToString());
                                                String citiname = (from city in datacontext.CitiesDetails where city.CityCode == citicode select city.CityName).FirstOrDefault().ToString();





                                                //Selection of Hotel
                                                Console.WriteLine("Select the Hotel code");


                                                //Using StoreProcedure and Methods
                                                //HotelDBImpl hotelimpl = new HotelDBImpl();
                                                //List<Hotel> hotels = hotelimpl.SelectHotel(citiname);
                                                //Console.WriteLine("HotelID\tHotelName\tHotelEmail\tPhoneNumber\tCity");
                                                //for (int i = 0; i < hotels.Count; i++)
                                                //{
                                                //    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", hotels[i].Hotel_Id, hotels[i].HotelName, hotels[i].HotelEmailId, hotels[i].PhoneNumber, hotels[i].City);
                                                //}
                                                //Int64 Hotel_id = Int64.Parse(Console.ReadLine());






                                                //Using LinQ to SQL
                                                var HotelDetailss = datacontext.spSelectHotel(citiname);
                                                Console.WriteLine("HotelID\tHotelName\tHotelEmail\tPhoneNumber\tCity");
                                                foreach (var hotel in HotelDetailss)
                                                {
                                                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", hotel.Hotel_Id, hotel.HotelName, hotel.HotelEmailID, hotel.HotelPhoneNumber, hotel.City);
                                                }
                                                Int64 Hotel_id = Int64.Parse(Console.ReadLine());



                                                //Selection of Room Type
                                                Console.WriteLine("Select Room id ");

                                                //Using StoreProcedure and Methods
                                                //HotelRommDBImple roomimpl = new HotelRommDBImple();
                                                //List<HotelRooms> hotelrooms = roomimpl.SelectHotelRooms(Hotel_id);
                                                //Console.WriteLine("RoomID\tHotelId\tRoomType\tRates  \tAvai. Rooms\tTotalRooms");
                                                //for (int i = 0; i < hotelrooms.Count; i++)
                                                //{
                                                //    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t\t{5}", hotelrooms[i].Room_Id, hotelrooms[i].Hotel_Id, hotelrooms[i].RoomType, hotelrooms[i].Rates, hotelrooms[i].AvailableRooms, hotelrooms[i].TotalRooms);
                                                //}
                                                //Int64 roomid = Int64.Parse(Console.ReadLine());

                                                //Using LinQ to SQL
                                                var RoomDetails = datacontext.spSelectHotelRooms(Hotel_id);
                                                Console.WriteLine("RoomID\tHotelId\tRoomType\tRates  \tAvai. Rooms\tTotalRooms");
                                                foreach (var room in RoomDetails)
                                                {
                                                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t\t{5}", room.Room_Id, room.Hotel_Id, room.RoomType, room.Rates, room.AvailableRooms, room.TotalRooms);
                                                }
                                                Int64 roomid = Int64.Parse(Console.ReadLine());
                                                if (roomid % 2 == 1)
                                                {
                                                    Console.WriteLine("Rooms with odd room_id is not present");
                                                    throw new Exception("Rooms with odd room_id is not present");
                                                }



                                                //Taking Customer's details and storing it into database
                                                Console.WriteLine("Please ente the following datails");


                                                //Using StoreProcedure and Methods
                                                //Customer customer = new Customer();
                                                //Console.WriteLine("First Name");
                                                //customer.FirstName = Console.ReadLine();

                                                //Console.WriteLine("Last Name");
                                                //customer.LastName = Console.ReadLine();

                                                //Console.WriteLine("Email Id");
                                                //customer.EmailId = Console.ReadLine();

                                                //Console.WriteLine("Phone Number");
                                                //customer.PhoneNumber = Console.ReadLine();

                                                //CustomerDBImpl customerdb = new CustomerDBImpl();
                                                //Int64 Cust_Id = customerdb.InsertCustomer(customer.FirstName, customer.LastName, customer.EmailId, customer.PhoneNumber);


                                                //using LinQ to SQL
                                                CustomerData new_customer = new CustomerData();
                                                Console.WriteLine("First Name");
                                                new_customer.FirstName = Console.ReadLine();

                                                Console.WriteLine("Last Name");
                                                new_customer.LastName = Console.ReadLine();

                                                Console.WriteLine("Email Id");
                                                new_customer.EmailId = Console.ReadLine();

                                                Console.WriteLine("Phone Number");
                                                new_customer.PhoneNumber = Console.ReadLine();


                                                Int64 Cust_Id = (Int64)datacontext.spInsertCustomer(new_customer.FirstName, new_customer.LastName, new_customer.EmailId, new_customer.PhoneNumber).SingleOrDefault().Column1.Value; //new_customer.Cust_Id;

                                                Console.WriteLine("Your customer id is {0} .", Cust_Id);



                                                //Storing booking details into database

                                                //Using StoreProcedure and Methods
                                                //BookingDetailsDBImpl booking = new BookingDetailsDBImpl();
                                                //Int64 Booking_Id = booking.InsertBookingDetails(Cust_Id, Hotel_id);


                                                //Using linq to sql
                                                BookingDetail new_booking = new BookingDetail();
                                                new_booking.Cust_Id = Cust_Id;
                                                new_booking.Hotel_Id = Hotel_id;

                                                Int64 New_Booking_Id = (Int64)datacontext.spInsertBookingDetails(new_booking.Cust_Id, new_booking.Hotel_Id).SingleOrDefault().Column1.Value;
                                                Console.WriteLine("Your booking id is {0}", New_Booking_Id);

                                                logger.Trace("Customer with id {0} has searched for hotel with hotel id {1} on {2} at {3} .", Cust_Id, Hotel_id, DateTime.Now.Date, DateTime.Now.TimeOfDay);
                                                //Updating hotel rooms database

                                                //using store preocedure
                                                //HotelRommDBImple update_hotel_rooms = new HotelRommDBImple();
                                                //update_hotel_rooms.UpdateHotelRooms(roomid);

                                                //using linq to sql
                                                datacontext.spUpdateHotelRooms(roomid);

                                                datacontext.SubmitChanges();

                                                break;

                                            case 2:
                                                //updating booking details at check out 

                                                Console.WriteLine("Please enter your Booking id");
                                                Int64 booking_id = Int64.Parse(Console.ReadLine());

                                                //using store procedure
                                                //BookingDetailsDBImpl update_booking = new BookingDetailsDBImpl();
                                                //update_booking.UpdateBookingDetails(booking_id);

                                                //using linq to sql
                                                datacontext.spUpdateBookingDetails(booking_id);


                                                datacontext.SubmitChanges();

                                                break;

                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter proper choice !");
                                    }
                                    Console.WriteLine("Do you want to do check in or check out ? (y/n)");

                                } while (Console.ReadLine() != "n");


                                break;

                            //For Agent
                            case 2:
                                do
                                {
                                    Console.WriteLine("What do you want to do?");
                                    Console.WriteLine("1. Add Hotel");
                                    Console.WriteLine("2. Add Room");

                                    int agent_choice = 0;

                                    bool valid_choice = int.TryParse(Console.ReadLine(), out agent_choice);

                                    if (valid_choice && (agent_choice == 1 || agent_choice == 2))
                                    {
                                        switch (agent_choice)
                                        {
                                            case 1:

                                                //Taking Hotel datails and inserting it into database

                                                //using store procedure
                                                //Hotel new_hotel = new Hotel();
                                                //Console.WriteLine("Enter Hotel's Name");
                                                //new_hotel.HotelName = Console.ReadLine();

                                                //Console.WriteLine("Enter hotel's email id");
                                                //new_hotel.HotelEmailId = Console.ReadLine();

                                                //Console.WriteLine("Enter hotel's Phone number");
                                                //new_hotel.PhoneNumber = Console.ReadLine();

                                                //Console.WriteLine("Enter hotel's city");
                                                //new_hotel.PhoneNumber = Console.ReadLine();

                                                //HotelDBImpl insert_new_hotel = new HotelDBImpl();
                                                //Int64 hotel_id = insert_new_hotel.InsertHotel(new_hotel.HotelName, new_hotel.HotelEmailId, new_hotel.PhoneNumber, new_hotel.PhoneNumber);

                                                //if (hotel_id > 0)
                                                //    Console.WriteLine("Hotel added successfully with hotel id {0}", hotel_id);


                                                //using linq to sql
                                                Hotel_Data new_hotel = new Hotel_Data();
                                                Console.WriteLine("Enter Hotel's Name");
                                                new_hotel.HotelName = Console.ReadLine();

                                                Console.WriteLine("Enter hotel's email id");
                                                new_hotel.HotelEmailID = Console.ReadLine();

                                                Console.WriteLine("Enter hotel's Phone number");
                                                new_hotel.HotelPhoneNumber = Console.ReadLine();

                                                Console.WriteLine("Enter hotel's city");
                                                new_hotel.City = Console.ReadLine();

                                                Int64 new_hotel_id = (Int64)datacontext.spInsertHotel(new_hotel.HotelName, new_hotel.HotelEmailID, new_hotel.HotelPhoneNumber, new_hotel.City).SingleOrDefault().Column1.Value;

                                                if (new_hotel_id > 0)
                                                    Console.WriteLine("Hotel added successfully with hotel id {0}", new_hotel_id);


                                                break;

                                            case 2:

                                                //Taking Hotel Room details and storing in database

                                                //using store procedure
                                                //HotelRooms new_hotelroom = new HotelRooms();
                                                //Console.WriteLine("Enter Hotel Id");
                                                //new_hotelroom.Hotel_Id = Convert.ToInt64(Console.ReadLine());

                                                //Console.WriteLine("Enter Room type");
                                                //new_hotelroom.RoomType = Console.ReadLine();

                                                //Console.WriteLine("Enter rates");
                                                //new_hotelroom.Rates = Convert.ToInt64(Console.ReadLine());

                                                //Console.WriteLine("Enter Available rooms");
                                                //new_hotelroom.AvailableRooms = Convert.ToInt64(Console.ReadLine());

                                                //Console.WriteLine("Enter Total rooms");
                                                //new_hotelroom.TotalRooms = Convert.ToInt64(Console.ReadLine());

                                                //HotelRommDBImple insert_hotel_room = new HotelRommDBImple();
                                                //Int64 room_id = insert_hotel_room.InsertHotelRooms(new_hotelroom.Hotel_Id, new_hotelroom.RoomType, new_hotelroom.Rates, new_hotelroom.AvailableRooms, new_hotelroom.TotalRooms);

                                                //if (room_id > 0)
                                                //    Console.WriteLine("Room added successfully with Room id {0}", room_id);


                                                //using linq to sql
                                                HotelRoom new_room = new HotelRoom();
                                                Console.WriteLine("Enter Hotel Id");
                                                new_room.Hotel_Id = Convert.ToInt64(Console.ReadLine());

                                                Console.WriteLine("Enter Room type");
                                                new_room.RoomType = Console.ReadLine();

                                                Console.WriteLine("Enter rates");
                                                new_room.Rates = Convert.ToInt64(Console.ReadLine());

                                                Console.WriteLine("Enter Available rooms");
                                                new_room.AvailableRooms = Convert.ToInt64(Console.ReadLine());

                                                Console.WriteLine("Enter Total rooms");
                                                new_room.TotalRooms = Convert.ToInt64(Console.ReadLine());

                                                Int64 new_room_id = (Int64)datacontext.spInsertHotelRooms(new_room.Hotel_Id, new_room.RoomType, new_room.Rates, new_room.AvailableRooms, new_room.TotalRooms).SingleOrDefault().Column1.Value;

                                                if (new_room_id > 0)
                                                    Console.WriteLine("Room added successfully with Room id {0}", new_room_id);



                                                break;
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter valid choice !");
                                    }
                                    Console.WriteLine("Do you want to add Hotel or Room? (y/n)");

                                } while (Console.ReadLine() != "n");

                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter the valid input !");
                    }

                    
                }
                catch (Exception e)
                {
                    logger.ErrorException(e.Message,e);
                }
                Console.WriteLine("Do you want to continue or change your role? (y/n)");
            } while (Console.ReadLine() != "n");

            
        }
    }
}