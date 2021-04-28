using System;
using System.Collections.Generic;

namespace Year3GroupBackend.Models
{
    public class userDetails
    {

        public interface IUserRepository
    {
        IEnumerable<UserModel> GetAll();
        
        UserModel Add(UserModel user);
    }





    public class UserModel
    {
        public int Id { get; set; }
        
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }
    }









public class UserRepository: IUserRepository
    {
        private List<UserModel> users = new List<UserModel>();
        private int _nextId = 1;

        public UserRepository()
        {
            Add(new UserModel { firstName= "first1", lastName="last1", email="email1@gmail.com"});
            Add(new UserModel { firstName= "first2", lastName="last2", email="email2@gmail.com"});
            Add(new UserModel { firstName= "first3", lastName="last3", email="email3@gmail.com"});
        }

        public IEnumerable<UserModel> GetAll()
        {
            return users;
        }

        public UserModel Add(UserModel item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            users.Add(item);
            return item;
        }
    }
}
}
    