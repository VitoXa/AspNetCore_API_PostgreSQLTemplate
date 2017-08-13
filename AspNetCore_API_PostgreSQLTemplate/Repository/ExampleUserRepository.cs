using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore_API_PostgreSQLTemplate.Models;
using AspNetCore_API_PostgreSQLTemplate.Data;
using Microsoft.Extensions.Logging;

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

        public void AddUser(User user)
        {
            try {
                _context.Users.Add(user);
            }
            catch (Exception exp)
            {
                _logger.LogError($"Error in {nameof(AddUser)}: " + exp.Message);
            }

        }

        public User getUser(int id)
        {
            return _context.Users.SingleOrDefault(u => u.Id == id);
        }
    }
}
