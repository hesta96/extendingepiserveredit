using ExtendingEpiserverEdit.Models.Entities;
using System.Collections.Generic;

namespace ExtendingEpiserverEdit.Business.Repositories
{
    public interface IUserProfileRepository
    {
        IEnumerable<UserProfile> SearchUsers(string searchString);
        UserProfile GetUserProfile(string userId);
        UserProfile UpsertUserProfile(UserProfile userProfile);
    }
}