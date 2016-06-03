﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamC
{
    class UserData
    {
        private string password;
        private int id;
        private int usertype;
        private List<Order> orderlist=new List<Order>();
        private List<string> payinformation;
        private string account;
        public  UserData(int uid=0,string pwd="")
        {
            id = uid;
            password = pwd;
            account = "";
            usertype  = 0;
        }
        public void SetPayinformation(List<string> Payinformation)
        {
            payinformation = Payinformation;
        }
        public List<string> GetPayinformation()
        {
            return payinformation;
        }
        public void SetPassword(string pwd)
        {
            password = pwd;
        }
        public string GetPassword()
        {
            return password;
        }
        public void SetUserType(int UserType)
        {
            usertype = UserType;
        }
        public int GetUserType()
        {
            return usertype;
        }
        public void SetOrderList(Order order)
        {
            orderlist.Add(order);
        }
        public Order GetOrderList()
        {
            return orderlist[0];
        }

    }
}
