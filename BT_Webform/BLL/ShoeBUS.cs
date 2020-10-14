using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BT_Webform.DTO;
using BT_Webform.DAL;

namespace BT_Webform.BLL
{
    public class ShoeBUS
    {
        public List<Shoe> GetAll()
        {
            List<Shoe> shoes = new ShoeDAO().SelectAll();
            return shoes;
        }
        public bool Delete(int code)
        {
            bool result = new ShoeDAO().Delete(code);
            return result;
        }
        public List<Shoe> SearchByName(String keyword)
        {
            List<Shoe> shoes = new ShoeDAO().SelectByName(keyword);
            return shoes;
        }
        public Shoe GetDetails(int code)
        {
            Shoe shoe = new ShoeDAO().SelectByCode(code);
            return shoe;
        }
        public bool Update(Shoe newShoe)
        {
            bool result = new ShoeDAO().Update(newShoe);
            return result;
        }
        public bool AddItem(Shoe newShoe)
        {
            bool result = new ShoeDAO().Insert(newShoe);
            return result;
        }
    }
}