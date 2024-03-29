﻿namespace ExtendingEpiserverEdit.Controllers.Api
{
    using EPiServer.ServiceLocation;
    using ExtendingEpiserverEdit.Business.Repositories;
    using ExtendingEpiserverEdit.Models.Entities;
    using System;
    using System.Web.Http;

    [Authorize(Roles = "Administrators, WebAdmins, WebEditors")]
    public class ProfileApiController : ApiController
    {
        private readonly IUserProfileRepository userProfileRepository;

        public ProfileApiController(IUserProfileRepository userProfileRepository)
        {
            this.userProfileRepository = userProfileRepository;
        }

        [AcceptVerbs("GET")]
        public IHttpActionResult SearchUserProfiles(string searchString)
        {
            return this.Ok(this.userProfileRepository.SearchUsers(searchString));
        }

        [AcceptVerbs("GET")]
        public IHttpActionResult GetUserProfile(string userId)
        {
            return this.Ok(this.userProfileRepository.GetUserProfile(userId));
        }

        [AcceptVerbs("POST")]
        public IHttpActionResult UpsertUserProfile(UserProfile userProfile)
        {
            try
            {
                this.userProfileRepository.UpsertUserProfile(userProfile);

            }
            catch (Exception ex)
            {
                return this.InternalServerError(ex);
            }

            return this.Ok("Update done");
        }

    }
}