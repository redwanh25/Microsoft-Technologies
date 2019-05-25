using MemberDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_API.Controllers
{
    public class MembersController : ApiController
    {
        public HttpResponseMessage Get()
        {
            using (BestowersAppDatabase_OldEntities entity = new BestowersAppDatabase_OldEntities())
            {
                return Request.CreateResponse(HttpStatusCode.OK, entity.Members.ToList());
            }

        }
        [Route("api/members/GetMembers")]
        public HttpResponseMessage post(Member member)
        {
            using (BestowersAppDatabase_OldEntities entities = new BestowersAppDatabase_OldEntities())
            {
                return Request.CreateResponse(HttpStatusCode.OK, entities.Members.Where(e => e.MemberID.ToString().StartsWith(member.MemberID.ToString()) || string.IsNullOrEmpty(member.MemberID.ToString()) || e.FirstName.ToString().StartsWith(member.FirstName.ToString()) || string.IsNullOrEmpty(member.FirstName.ToString()) || string.IsNullOrEmpty(member.LastName.ToString()) || string.IsNullOrEmpty(member.BatchID.ToString()) || string.IsNullOrEmpty(member.CadetNo.ToString()) || string.IsNullOrEmpty(member.HomeEmail.ToString()) || string.IsNullOrEmpty(member.HomePhone.ToString()) || string.IsNullOrEmpty(member.City.ToString()) || string.IsNullOrEmpty(member.State.ToString()) || string.IsNullOrEmpty(member.CountryID.ToString())).ToList());
                //return Request.CreateResponse(HttpStatusCode.OK, entity.Member_Proc(member.MemberID, member.FirstName, member.LastName, member.BatchID, Convert.ToInt32(member.CadetNo), member.HomeEmail, member.HomePhone, member.City, member.State, member.CountryID));
            }

        }
    }
}
