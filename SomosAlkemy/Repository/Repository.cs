﻿using Microsoft.EntityFrameworkCore;
using SomosAlkemy.DataAccess;
using SomosAlkemy.DTO_s;
using SomosAlkemy.Repository.Interfaces;

namespace SomosAlkemy.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {

        protected readonly ContextDB _contextDB;
        public Repository(ContextDB contextDB)
        {
            _contextDB = contextDB;
        }

        public async Task<List<T>> GetAll()
        {
            var entity = await _contextDB.Set<T>().ToListAsync();
            return entity;
        }

        public async Task<bool> Insert(T entity)
        {
            try
            {
                _contextDB.Set<T>().Add(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Task<bool> InsertUser(UserRegisterDTO userRegisterDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(T entity)
        {
            try
            {
                _contextDB.Set<T>().Update(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}