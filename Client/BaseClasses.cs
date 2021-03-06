using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Person
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        
        public Person(string Name, string PhoneNumber, string Address)
        {
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
        }
    }
    public class Clerk: Person, ISendAble, IClerk
    {
        public long Id { get; set; }
        public bool IsNew { get; set; }
        public bool Removed { get; set; }
        public bool Select { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public Clerk(string Name, string PhoneNumber, string Address, string UserName, string Password, bool IsAdmin)
            :base(Name, PhoneNumber, Address)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.IsAdmin = IsAdmin;
        }
    }
    public class Customer : Person, ISendAble, ICustomer
    {
        public long Id { get; set; }
        public bool IsNew { get; set; }
        public bool Edited { get; set; }
        public bool Removed { get; set; }
        public bool Select { get; set; }

        public long Balance { get; set; }
        public long OrderCountRecive { get; set; }
        public long OrderCountRemove { get; set; }
        public string SubscribeCode { get; }

        public Customer(string Name, string PhoneNumber, string Address, string SubscribeCode)
            : base(Name, PhoneNumber, Address)
        {
            this.SubscribeCode = SubscribeCode;
            OrderCountRecive = 0;
            OrderCountRemove = 0;
            Balance = 0;
        }

        public override string ToString()
        {
            return Name;
        }
    }
    public class Cake: IProduct, ISendAble
    {
        public long Id { get; set; }
        public bool IsNew { get; set; }
        public bool Removed { get; set; }
        public bool Select { get; set; }

        public long Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Cake(long Price, string Name, string Description)
        {
            this.Price = Price;
            this.Name = Name;
            this.Description = Description;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    public class Order:ISendAble, IOrder
    {
        public long Id { get; set; }
        public bool IsNew { get; set; }
        public bool Removed { get; set; }
        public bool Select { get; set; }
        public  int Hour { get; set; }
        public long TotalPrice 
        { 
                get { return Products.Select(x => x.cake.Price*x.count).Sum(); }
        }
        public string OrderCode { get; set; }
        public List<Item> Products = new List<Item>();
        public Customer Customer { get; set; }

    }
    public class Requst
    {
        public bool clerk, cutomer, product, order;
        public List<ISendAble> Objects;
        public ISendAble SelectObject;

    }
    public class Search: Requst, ISendAble
    {
        public long Id { get; set; }
        public bool IsNew { get; set; }
        public bool Edited { get; set; }
        public bool Removed { get; set; }
        public bool Select { get; set; }
        public ISendAble Up, Down;
        public Search()
        {
            Select = true;IsNew = false;Edited = false;Removed = false;
            clerk = false; cutomer = false; product = false; order = false; 
        }
    }
    class ClientToServer : Requst
    {
        public string UserName, Password;
        public bool Select { get; set; }
        public bool Apply{ get; set; }
        public ClientToServer(string UserName, string Password, bool Select, bool Apply)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Select = Select;
            this.Apply = Apply;
            clerk=false; cutomer=false; product=false; order=false;
        }
    }
    class ServerToClient: Requst
    {
        public bool ClerkAccept;
        public List<Status> Statuses;
    }
    class Status
    {
        public bool Done;
        public string Description;
    }
    
    public static class ConstValue
    {
        public static int start_hour { get { return 6; } }
        public static int end_hour { get { return 21; } }
        public static int max_in_hour { get { return 1000; } }
    }
    public static class GlobalData
    {
        public static BindingList<Clerk> clerks = new BindingList<Clerk>();
        public static BindingList<Cake> cakes = new BindingList<Cake>();
        public static BindingList<Customer> customers = new BindingList<Customer>();
        public static BindingList<Order> orders = new BindingList<Order>();
        public static BindingList<Item> basket = new BindingList<Item>();

        public static string Username = "";
        public static string Password = "";
    }

    public class Item
    {
        public Cake cake;
        public int count { get; set; }
        public string name { get; set; }
    }
}