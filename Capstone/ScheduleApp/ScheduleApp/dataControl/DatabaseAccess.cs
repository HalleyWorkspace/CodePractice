using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleApp.dataControl
{
    /*
     * Lambda function is used 24 times here for manipulating data retrieved from the database.
     * All lambda functions used here could be replaced with LINQ Query syntax instead of methods.
     * The main reason I used methods with lambdas over query syntax was that I found it simpler to write and easier to understand what i was retrieveing with each query.
     * Additionally, i did not use lambdas where i needed to use joins as I find the query sintax for join easier to read and understand than the methods with lambdas.
     * 
     * Most common uses of the function is:
     * 1. Filter to a single object or single database entry
     * 2. Filter to a subset from a larger set
     * 3. Select only the column or columns needed
     * 
     * Other uses are detailed directly in the lines where used
     */
    public class DatabaseAccess
    {
        private static List<consultantObject> consultantlist = null;

        //Constructor used to bypass database for unit tests
        public DatabaseAccess(List<consultantObject> consultants)
        {
            consultantlist = consultants;
        }

        public static List<scheduleObject> getSchedule()
        {
            using (var conn = new client_scheduleEntities())
            {
                List<scheduleObject> schedule = (from apointment in conn.appointments
                        join customer in conn.customers on apointment.customerId equals customer.customerId
                        join user in conn.users on apointment.userId equals user.userId
                        orderby apointment.appointmentId
                        select new scheduleObject(){ apointmentID = apointment.appointmentId, date = apointment.start, customerName = customer.customerName, consultantName = user.userName, customerID = customer.customerId, consultantId = user.userId, type = apointment.type }).ToList();
                //lambda function used to format time to local time in a single line
                schedule.ForEach(x => x.date = x.date.ToLocalTime()); 
                return schedule;
            }
        }

        public static List<scheduleObject> getSchedule(DateTime start, DateTime end)
        {
            //lambda function used to filter apointments between two dates
            return getSchedule().Where(x => x.date >= start && x.date <= end).ToList();
        }

        public static List<customerObject> getCustomers()
        {
            using (var conn = new client_scheduleEntities())
            {

                return (from customer in conn.customers
                        join address in conn.addresses on customer.addressId equals address.addressId
                        join city in conn.cities on address.cityId equals city.cityId
                        join country in conn.countries on city.countryId equals country.countryId
                        orderby customer.customerId
                        select new customerObject() { customerID = customer.customerId, customerName = customer.customerName, address = address.address1, city = city.city1, country = country.country1, phoneNumber = address.phone, postalCode = address.postalCode }).ToList();
            }
        }

        public static List<consultantObject> getConsultants()
        {
            using (var conn = new client_scheduleEntities())
            {
                //Lambda used to generate a list of consultantObjects that contain only the information from the database of users that might be needed
                return conn.users.Select(consultant => new consultantObject() { consultantId = consultant.userId, consultantName = consultant.userName, password = consultant.password }).ToList();
            }
        }

        public static List<scheduleObject> getConsultantSchedule(int consultantId)
        {
            // See 2. above
            return getSchedule().Where(x => x.consultantId == consultantId).ToList();
        }

        public static customerObject getCustomer(int customerID)
        {
            // See 1. above
            return getCustomers().Single(x => x.customerID == customerID);
        }

        public static void addCutomer(customerObject newCustomer)
        {
            country newCountry = addCountry(newCustomer.country);
            city newCity = addCity(newCustomer.city, newCountry);
            address address = addAddress(newCustomer.address, newCity, newCustomer.phoneNumber, newCustomer.postalCode);
            customer addCutomer = new customer()
            {
                customerName = newCustomer.customerName,
                address = address,
                active = true,
                createDate = DateTime.Now,
                lastUpdate = DateTime.Now,
                createdBy = "test",
                lastUpdateBy = "test"
            };
            using (var conn = new client_scheduleEntities())
            {
                conn.customers.Add(addCutomer);
                conn.SaveChanges();
            }
        }

        private static country addCountry(string countryName)
        {
            country newCountry;
            using (var conn = new client_scheduleEntities())
            {
                // See 3. above
                if(conn.countries.Select(x => x.country1).ToList().Contains(countryName))
                {
                    newCountry = conn.countries.Single(x => x.country1 == countryName);
                }
                else
                {
                    newCountry = new country()
                    {
                        country1 = countryName,
                        lastUpdate = DateTime.Now,
                        lastUpdateBy = "test",
                        createDate = DateTime.Now,
                        createdBy = "test"
                    };
                }   
            }
            return newCountry;
        }

        private static city addCity(string cityName, country country)
        {
            city newCity = null;
            using (var conn = new client_scheduleEntities())
            {
                // See 3. above
                if (conn.cities.Select(x => x.city1).ToList().Contains(cityName))
                {
                    newCity = conn.cities.Single(x => x.city1 == cityName);
                    if (newCity.country != country)
                        newCity = null;
                }
                if(newCity == null)
                {
                    newCity = new city()
                    {
                        city1 = cityName,
                        lastUpdate = DateTime.Now,
                        lastUpdateBy = "test",
                        createDate = DateTime.Now,
                        createdBy = "test",
                        country = country
                    };
                }                
            }
            return newCity;
        }


        private static address addAddress(string newAddress, city city, string phoneNumber, string postalCode)
        {
            address addAddress = null;
            using (var conn = new client_scheduleEntities())
            {
                // See 3. above
                if(conn.addresses.Select(x => x.address1).ToList().Contains(newAddress))
                {
                    //See 1. above
                    addAddress = conn.addresses.Single(x => x.address1 == newAddress);
                    if (addAddress.phone != phoneNumber || addAddress.postalCode != postalCode || addAddress.city != city)
                        addAddress = null;
                }
                if(addAddress == null)
                {
                    addAddress = new address()
                    {
                        address1 = newAddress,
                        address2 = "",
                        lastUpdate = DateTime.Now,
                        lastUpdateBy = "test",
                        createDate = DateTime.Now,
                        createdBy = "test",
                        city = city,
                        phone = phoneNumber,
                        postalCode = postalCode
                    };
                }
            }
            return addAddress;
        }

        public static bool addAppointment(scheduleObject newApointment)
        {
            using (var conn = new client_scheduleEntities())
            {
                // See 1. above for both
                user user = conn.users.Single(x => x.userId == newApointment.consultantId);
                customer currentCustomer = conn.customers.Single(x => x.customerId == newApointment.customerID);

                appointment appointment = new appointment()
                {
                    type = newApointment.type,
                    user = user,
                    customer = currentCustomer,
                    title = "not needed",
                    description = "not needed",
                    location = "not needed",
                    contact = "not needed",
                    url = "not needed",
                    start = newApointment.date.ToUniversalTime(),
                    end = newApointment.date.ToUniversalTime(),
                    createDate = DateTime.Now,
                    lastUpdate = DateTime.Now,
                    createdBy = "test",
                    lastUpdateBy = "test"
                };

                if (checkOverlap(currentCustomer, user, appointment, true))
                    return false;

                conn.appointments.Add(appointment);
                conn.SaveChanges();
                return true;
            }
        }

        public static void updateCustomer(customerObject updatedCustomer)
        {
            using (client_scheduleEntities conn = new client_scheduleEntities())
            {
                // See 1. above
                customer customer = conn.customers.Single(x => x.customerId == updatedCustomer.customerID);
                address address = customer.address;
                city city = address.city;
                country country = city.country;

                if (!country.country1.Equals(updatedCustomer.country))
                    country = addCountry(updatedCustomer.country);
                if (!city.city1.Equals(updatedCustomer.city) || city.countryId != country.countryId)
                    city = addCity(updatedCustomer.city, country);
                updateAddress(address, updatedCustomer, city);
                if (!customer.customerName.Equals(updatedCustomer.customerName))
                    customer.customerName = updatedCustomer.customerName;
                conn.SaveChanges();
                    
            }
        }

        public static void updateAddress(address oldAddress, customerObject updatedCustomer, city updatedCity)
        {
            address updatedAddress;
            using (client_scheduleEntities conn = new client_scheduleEntities()) 
            {
                // See 1. above
                updatedAddress = conn.addresses.Single(x => x.addressId == oldAddress.addressId);
                if (!oldAddress.address1.Equals(updatedCustomer.address))
                    updatedAddress.address1 = updatedCustomer.address;
                if (!oldAddress.postalCode.Equals(updatedCustomer.postalCode))
                    updatedAddress.postalCode = updatedCustomer.postalCode;
                if (!oldAddress.phone.Equals(updatedCustomer.phoneNumber))
                    updatedAddress.phone = updatedCustomer.phoneNumber;
                if (!oldAddress.cityId.Equals(updatedCity.cityId))
                    updatedAddress.city = updatedCity;
                
                conn.SaveChanges();
            }
        }

        public static bool updateApointment(scheduleObject updatedApointment)
        {
            appointment apointmentUpdate;
            customer customer;
            user user;
            using (client_scheduleEntities conn = new client_scheduleEntities())
            {
                // See 1. above for all three
                apointmentUpdate = conn.appointments.Single(x => x.appointmentId == updatedApointment.apointmentID);
                customer = conn.customers.Single(x => x.customerId == updatedApointment.customerID);
                user = conn.users.Single(x => x.userId == updatedApointment.consultantId);
                if (!updatedApointment.customerID.Equals(customer.customerId))
                    apointmentUpdate.customer = customer;
                if (!updatedApointment.consultantId.Equals(user.userId))
                    apointmentUpdate.user = user;
                if (!updatedApointment.type.Equals(apointmentUpdate.type))
                    apointmentUpdate.type = updatedApointment.type;
                if (!updatedApointment.date.Equals(apointmentUpdate.start))
                {
                    apointmentUpdate.start = updatedApointment.date.ToUniversalTime();
                    apointmentUpdate.end = updatedApointment.date.ToUniversalTime();
                }

                if(checkOverlap(customer, user, apointmentUpdate, false))
                    return false;

                conn.SaveChanges();
                return true;
            }
        }

        public static void deleteAppointment(scheduleObject oldAppointment)
        {
            using (client_scheduleEntities conn = new client_scheduleEntities())
            {
                // See 1. above
                appointment appointment = conn.appointments.Single(x => x.appointmentId == oldAppointment.apointmentID);

                conn.appointments.Remove(appointment);
                conn.SaveChanges();
            }
        }

        public static void deleteCustomer(customerObject oldCustomer)
        {
            using (client_scheduleEntities conn = new client_scheduleEntities())
            {
                //see 1. above
                customer customer = conn.customers.Single(x => x.customerId == oldCustomer.customerID);
                //remove customer apointments
                List<appointment> removedAppointments = conn.appointments.Where(x => x.customerId == oldCustomer.customerID).ToList();
                conn.appointments.RemoveRange(removedAppointments);
                conn.customers.Remove(customer);
                conn.SaveChanges();
            }
        }

        public static consultantObject login(String username, string password)
        {
            consultantObject consultant = null;


            if(consultantlist == null)
                consultantlist = getConsultants();
            
            var userList = (consultantlist.Select(x => x.consultantName));
            if (userList.Count() > 0
                && userList.Contains(username)
                && consultantlist.Single(x => x.consultantName == username).password.Equals(password))
                consultant = consultantlist.Single(x => x.consultantName == username);
            
            return consultant;
        }

        
        private static bool checkOverlap(customer customer, user user, appointment appointment, bool newApointment)
        {
            DateTime appointmentDate = appointment.start;
            int appointmentId = appointment.appointmentId;
            // See 2. above for the next 2
            List<scheduleObject> clientSchedule = getSchedule().Where(x => x.customerID == customer.customerId).ToList();            
            List<scheduleObject> consultantSchedule = getSchedule().Where(x => x.consultantId == user.userId).ToList();
            
            // See 3. above for the next 2
            int clientApointmentId = -1;
            int consultantApointmentId = -1;
            if(clientSchedule.Select(x => x.date.ToUniversalTime()).Contains(appointmentDate))
                clientApointmentId = clientSchedule.Single(x => x.date.ToUniversalTime() == appointmentDate).apointmentID;
            if(consultantSchedule.Select(x => x.date.ToUniversalTime()).Contains(appointmentDate))
                consultantApointmentId = consultantSchedule.Single(x => x.date.ToUniversalTime() == appointmentDate).apointmentID;

            if ((clientApointmentId == -1 && consultantApointmentId == -1)
                || (clientApointmentId == appointmentId && consultantApointmentId == -1)
                || (consultantApointmentId == appointmentId && clientApointmentId == -1)
                || (clientApointmentId == appointmentId && consultantApointmentId == appointmentId))
                return false;


            return true;
        }

        public static scheduleObject nextApointment(String username){
            // See 2. above for the next 2
            List<scheduleObject> scheduleList = getSchedule().Where(x => x.consultantName == username).ToList();
            scheduleObject nextApointment = scheduleList.Where(x => DateTime.Now < x.date).FirstOrDefault(); ;
            return nextApointment;
        }
    }
}
