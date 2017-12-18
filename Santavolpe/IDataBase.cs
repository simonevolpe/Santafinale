using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santavolpe { 
    public interface IDataBase
    {
        // Qui si def i metodi che agiscono sul database insert, getall, update

        bool InsertOrder(Order category);

        bool UpdateOrder(Order category);

        bool InsertUser(User category);

        bool UpdateUser(User user);

        IEnumerable<Order> GetAllCategoriesOreders();

        IEnumerable<Toy> GetAllToys();

        //        Order GetOrder(Order order);

        User GetUser(User user);

        Order GetOrder(string id);

        //        User GetUser(string id);


    }
}