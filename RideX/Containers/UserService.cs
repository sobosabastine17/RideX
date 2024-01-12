using RideX.Services;

public class UserService : IUserService
{
    //DB Dependency injection
    private readonly AppContext context;
    //userService contructor
    public UserService(AppContext context) {
        this.context=context;
    }
    public void UpdateProfile(User user)
    {
        // Implementation to update user profile
        //Console.WriteLine($"User profile updated for user {user.Username}");
    }

    public void ChangePassword(User user, string newPassword)
    {
        // Implementation to change user password
        Console.WriteLine($"Password changed for user {user.Username}");
    }

    public void DeleteAccount(User user)
    {
        // Implementation to delete user account
        Console.WriteLine($"Account deleted for user {user.Username}");
    }

    public void AddToFavorite(User user, int itemId)
    {
        // Implementation to add an item to user's favorites
        Console.WriteLine($"Item {itemId} added to favorites for user {user.Username}");
    }

    public void RemoveFromFavorite(User user, int itemId)
    {
        // Implementation to remove an item from user's favorites
        Console.WriteLine($"Item {itemId} removed from favorites for user {user.Username}");
    }

    public void CreatePost(User user, string content)
    {
        // Implementation to create a post or content
        Console.WriteLine($"Post created by user {user.Username}: {content}");
    }

    public void LikePost(User user, int postId)
    {
        // Implementation to like a post
        Console.WriteLine($"Post {postId} liked by user {user.Username}");
    }

    public void CommentOnPost(User user, int postId, string comment)
    {
        // Implementation to comment on a post
        Console.WriteLine($"User {user.Username} commented on post {postId}: {comment}");
    }

    public void FollowUser(User followerUser, User followeeUser)
    {
        // Implementation to follow another user
        Console.WriteLine($"User {followerUser.Username} started following {followeeUser.Username}");
    }

    public void UnfollowUser(User followerUser, User followeeUser)
    {
        // Implementation to unfollow a user
        Console.WriteLine($"User {followerUser.Username} unfollowed {followeeUser.Username}");
    }

    public void SendMessage(User senderUser, User receiverUser, string messageContent)
    {
        // Implementation to send a message
        Console.WriteLine($"Message sent from {senderUser.Username} to {receiverUser.Username}: {messageContent}");
    }

    public void BlockUser(User blockingUser, User blockedUser)
    {
        // Implementation to block a user
        Console.WriteLine($"User {blockingUser.Username} blocked {blockedUser.Username}");
    }

    public void ReportUser(User reportingUser, User reportedUser, string reason)
    {
        // Implementation to report a user
        Console.WriteLine($"User {reportingUser.Username} reported {reportedUser.Username} for {reason}");
    }

    public void Login(string username, string password)
    {
        throw new NotImplementedException();
    }

    public bool Register(User register)
    {
        //validate input
        if(string.IsNullOrEmpty(register.Email))
        if (register.Username == "" ||
         register.Password == "") return false;
        throw new NotImplementedException();
    }

    public List<User> GetUsers()
    {
        return this.context.Users.ToList();
        //throw new NotImplementedException();
    }

    // Other implementations of user-related actions...
}
