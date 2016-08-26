using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitiesOperation.Data;
using HotelOperation.data;
using HotelRoomsOperation.data;
using HotelReservation.Entities;
using CustomerOperations.data;
using BookingDetailsOperation.Data;

namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                //Displaying the choice to the user
                Console.WriteLine("Enter your role");
                Console.WriteLine("1. Customer");
                Console.WriteLine("2. Agent");
                int choice = 0;
                bool selection = int.TryParse(Console.ReadLine(), out choice);

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
                                            CitiesDBImpl citiesimpl = new CitiesDBImpl();
                                            List<Cities> cities = citiesimpl.SelectCities();
                                            for (int i = 0; i < cities.Count; i++)
                                            {
                                                Console.WriteLine("{0}  {1}", cities[i].CityCode, cities[i].CityName);
                                            }
                                            int citicode = int.Parse(Console.ReadLine());
                                            string citiname = cities[citicode - 1].CityName;


                                            //Selection of Hotel
                                            Console.WriteLine("Select the Hotel code");
                                            HotelDBImpl hotelimpl = new HotelDBImpl();
                                            List<Hotel> hotels = hotelimpl.SelectHotel(citiname);
                                            Console.WriteLine("HotelID\tHotelName\tHotelEmail\tPhoneNumber\tCity");
                                            for (int i = 0; i < hotels.Count; i++)
                                            {
                                                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", hotels[i].Hotel_Id, hotels[i].HotelName, hotels[i].HotelEmailId, hotels[i].PhoneNumber, hotels[i].City);
                                            }
                                            Int64 Hotel_id = Int64.Parse(Console.ReadLine());


                                            //Selection of Room Type
                                            Console.WriteLine("Select Room id ");
                                            HotelRommDBImple roomimpl = new HotelRommDBImple();
                                            List<HotelRooms> hotelrooms = roomimpl.SelectHotelRooms(Hotel_id);

                                            Console.WriteLine("RoomID\tHotelId\tRoomType\tRates  \tAvai. Rooms\tTotalRooms");
                                            for (int i = 0; i < hotelrooms.Count; i++)
                                            {
                                                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t\t{5}", hotelrooms[i].Room_Id, hotelrooms[i].Hotel_Id, hotelrooms[i].RoomType, hotelrooms[i].Rates, hotelrooms[i].AvailableRooms, hotelrooms[i].TotalRooms);
                                            }
                                            Int64 roomid = Int64.Parse(Console.ReadLine());


                                            //Taking Customer's details and storing it into database
                                            Console.WriteLine("Please ente the following datails");
                                            Customer customer = new Customer();
                                            Console.WriteLine("First Name");
                                            customer.FirstName = Console.ReadLine();

                                            Console.WriteLine("Last Name");
                                            customer.LastName = Console.ReadLine();

                                            Console.WriteLine("Email Id");
                                            customer.EmailId = Console.ReadLine();

                                            Console.WriteLine("Phone Number");
                                            customer.PhoneNumber = Console.ReadLine();

                                            CustomerDBImpl customerdb = new CustomerDBImpl();
                                            Int64 Cust_Id = customerdb.InsertCustomer(customer.FirstName, customer.LastName, customer.EmailId, customer.PhoneNumber);


                                            //Storing booking details into database
                                            BookingDetailsDBImpl booking = new BookingDetailsDBImpl();
                                            Int64 Booking_Id = booking.InsertBookingDetails(Cust_Id, Hotel_id);

                                            Console.WriteLine("Your booking id is {0}", Booking_Id);

                                            //Updating hotel rooms database
                                            HotelRommDBImple update_hotel_rooms = new HotelRommDBImple();
                                            update_hotel_rooms.UpdateHotelRooms(roomid);


                                            break;

                                        case 2:

                                            Console.WriteLine("Please enter your Booking id");
                                            Int64 booking_id = Int64.Parse(Console.ReadLine());
                                            BookingDetailsDBImpl update_booking = new BookingDetailsDBImpl();
                                            update_booking.UpdateBookingDetails(booking_id);

                                            break;

                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Please enter proper choice !");
                                }
                                Console.WriteLine("Do you want to do check in or check out ?");

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
                                            Hotel new_hotel = new Hotel();
                                            Console.WriteLine("Enter Hotel's Name");
                                            new_hotel.HotelName = Console.ReadLine();

                                            Console.WriteLine("Enter hotel's email id");
                                            new_hotel.HotelEmailId = Console.ReadLine();

                                            Console.WriteLine("Enter hotel's Phone number");
                                            new_hotel.PhoneNumber = Console.ReadLine();

                                            Console.WriteLine("Enter hotel's city");
                                            new_hotel.PhoneNumber = Console.ReadLine();

                                            HotelDBImpl insert_new_hotel = new HotelDBImpl();
                                            Int64 hotel_id = insert_new_hotel.InsertHotel(new_hotel.HotelName, new_hotel.HotelEmailId, new_hotel.PhoneNumber, new_hotel.PhoneNumber);

                                            if (hotel_id > 0)
                                                Console.WriteLine("Hotel added successfully with hotel id {0}", hotel_id);
                                            break;

                                        case 2:
                                            //Taking Hotel Room details
                                            HotelRooms new_hotelroom = new HotelRooms();
                                            Console.WriteLine("Enter Hotel Id");
                                            new_hotelroom.Hotel_Id = Convert.ToInt64(Console.ReadLine());

                                            Console.WriteLine("Enter Room type");
                                            new_hotelroom.RoomType = Console.ReadLine();

                                            Console.WriteLine("Enter rates");
                                            new_hotelroom.Rates = Convert.ToInt64(Console.ReadLine());

                                            Console.WriteLine("Enter Available rooms");
                                            new_hotelroom.AvailableRooms = Convert.ToInt64(Console.ReadLine());

                                            Console.WriteLine("Enter Total rooms");
                                            new_hotelroom.TotalRooms = Convert.ToInt64(Console.ReadLine());

                                            HotelRommDBImple insert_hotel_room = new HotelRommDBImple();
                                            Int64 room_id = insert_hotel_room.InsertHotelRooms(new_hotelroom.Hotel_Id, new_hotelroom.RoomType, new_hotelroom.Rates, new_hotelroom.AvailableRooms, new_hotelroom.TotalRooms);

                                            if (room_id > 0)
                                                Console.WriteLine("Room added successfully with Room id {0}", room_id);

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
                    Console.WriteLine("Please enter the valide input !");
                }

                Console.WriteLine("Do you want to continue or change your role? (y/n)");

            } while (Console.ReadLine() != "n");

            
        }
    }
}
