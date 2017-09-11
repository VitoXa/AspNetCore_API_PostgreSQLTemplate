using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCore_API_PostgreSQLTemplate.Models;
using AspNetCore_API_PostgreSQLTemplate.Data;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore_API_PostgreSQLTemplate.Repository
{
    public class ExampleUserRepository : IExampleUserRepository
    {
        private readonly ExampleDbContext _context;

        private readonly ILogger _logger;

        public ExampleUserRepository(ExampleDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("ExampleUserRepository");
        }

        public Person AddPerson(Person user)
        {
            try {
                _context.Persons.Add(user);
                _context.SaveChanges();
            }
            catch (Exception exp)
            {
                _logger.LogError($"Error in {nameof(AddPerson)}: " + exp.Message);
            }
            return user;

        }

        public Person GetPerson(int id)
        {
            return _context.Persons.Include(person => person.Document).SingleOrDefault(u => u.Id == id);
        }

        public List<Person> GetAllUsers()
        {
            return _context.Persons.ToList();
        }

        public Person GetTask(int id)
        {
            return _context.Persons.SingleOrDefault(u => u.Id == id);
        }

        public List<Person> GetAllTasks()
        {
            return _context.Persons.ToList();
        }
    }
}
