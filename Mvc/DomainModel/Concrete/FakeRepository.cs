﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModel.Abstract;
using DomainModel.Entities;

namespace DomainModel.Concrete
{
    public class FakeRepository : IProductsRepository
    {
        private static IQueryable<Product> fakeProducts = new List<Product>{
                                                          new Product() {Name = "Football", Price = 25},
                                                          new Product() {Name = "Surfboard", Price = 179},
                                                          new Product() {Name = "Running Shoes", Price = 95}
                                                      }.AsQueryable();

        public IQueryable<Product> Products
        {
            get { return fakeProducts; }
        }


    }
}
