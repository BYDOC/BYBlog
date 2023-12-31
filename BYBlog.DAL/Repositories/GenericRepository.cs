﻿using BYBlog.DAL.Concrete;
using BYBlog.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BYBlog.DAL.Repositories
{
    public class GenericRepository<T> : IGeneric<T> where T : class
    {
  
        BYBlog_DbContext _context = new BYBlog_DbContext();
        public void Delete(T t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().Where(filter).ToList();
        }

        public void Update(T t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }
    }
}
