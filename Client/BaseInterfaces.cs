using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public interface Itransfer
    {
        string Request(string json);
    }
    public interface ISendAble
    {
        long Id { get;}
        bool IsNew { get; }
        bool Removed { get;}
        bool Select { get; }
    }
    public interface IProduct
    {
        long Price { get;}
        string Name { get;}
        string Description { get;}
    }
    public interface ICustomer
    {
        long Balance { get; set; }
        long OrderCountRecive { get; set; }
        long OrderCountRemove { get; set; }
        string SubscribeCode { get; }
    }
    public interface IClerk
    {
        string UserName { get; }
        string Password { get; }
        bool IsAdmin { get; set; }
    }
    public interface IOrder
    {
        int Hour { get; set; }
        long TotalPrice { get;}
        string OrderCode { get;}
    }
}
