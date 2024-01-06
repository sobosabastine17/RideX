using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideX.Services
{
    public interface IUserService
    {
        //get all user
        List<User> GetUsers();
          //method to login user
    void Login(string username, string password);
    //method to register user
    bool Register(User register);
    void UpdateProfile(User user); // Method to update user profile
    void ChangePassword(User user, string newPassword); // Method to change user password
    void DeleteAccount(User user); // Method to delete user account
    void AddToFavorite(User user, int itemId); // Method to add an item to user's favorites
    void RemoveFromFavorite(User user, int itemId); // Method to remove an item from user's favorites
    void CreatePost(User user, string content); // Method to create a post or content
    void LikePost(User user, int postId); // Method to like a post
    void CommentOnPost(User user, int postId, string comment); // Method to comment on a post
    }
}