

using System;
using System.Collections.Generic;

namespace Year3GroupBackend.Models


{
    public interface IUserRepository
    {
        IEnumerable<userDetails> GetAll();
        
        userDetails Add(userDetails user);
    }
}