using System;
using System.Collections.Generic;
using System.Text;
using CS321_W4D2_ExerciseLogAPI.Core.Models;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepo;

        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public User Add(User user)
        {
            _userRepo.Add(user);
            return user;
        }

        public User Get(int id)
        {
            return _userRepo.Get(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepo.GetAll();
        }

        public User Update(User updatedUser)
        {
            var user = _userRepo.Update(updatedUser);
            return user;
        }

        public void Remove(User deleteUser)
        {
            _userRepo.Remove(deleteUser);
        }
    }
}
