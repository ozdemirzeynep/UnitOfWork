using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1
{
    
    public class UserRepository: Repository<User>, IUserRepository
    {
        private readonly XContext _xContext;
        public UserRepository(XContext xContext): base(xContext)
        {
            _xContext = xContext;
        }
    }
}
