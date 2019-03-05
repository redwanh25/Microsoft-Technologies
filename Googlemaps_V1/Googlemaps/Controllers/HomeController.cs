using Googlemaps.DBContext;
using Googlemaps.Models;
using System;
using System.Collections.Generic;
using System.Data.Spatial;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Googlemaps.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Ajax call to retrive the nearest locations for the given location
        /// </summary>
        /// <param name="lat">latitude</param>
        /// <param name="lng">longitude</param>
        /// <returns>json data of the nearest locations</returns>
        public ActionResult GetNearByLocations(string Currentlat, string Currentlng)
        {
            using (var context = new POC_gmapsEntities())
            {
                var currentLocation = DbGeography.FromText("POINT( " + Currentlng + " " + Currentlat + " )");

                //var currentLocation = DbGeography.FromText("POINT( 78.3845534 17.4343666 )");

                var places = (from u in context.SchoolInfoes
                              orderby u.GeoLocation.Distance(currentLocation)
                              select u).Take(4).Select(x => new Googlemaps.Models.SchoolInfo() { Name = x.SchoolName, lat = x.GeoLocation.Latitude, lng = x.GeoLocation.Longitude, Distance = x.GeoLocation.Distance(currentLocation) });
                var nearschools = places.ToList();
                
                return Json(nearschools, JsonRequestBehavior.AllowGet );
            }
        }
    }
}
