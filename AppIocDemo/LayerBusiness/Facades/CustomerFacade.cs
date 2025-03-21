﻿using AppIocDemo.Interfaces;
using AppIocDemo.Models;

namespace AppIocDemo.LayerBusiness.Facades
{
    public class CustomerFacade(ICustomerBe be) : ICustomerFacade
    {
        public List<Customer> GetCustomerList()
        {
            var custData = be.GetCustomers();
            return custData;
        }
    }
}
