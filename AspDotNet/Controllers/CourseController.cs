using ResfulsApi_AspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ResfulsApi_AspNet.Controllers
{
    public class CourseController : ApiController
    {
        static List<Course> courses = new List<Course>()
        {
            new Course()
            {
                CourseId = 1,
                Description= "a",
                Name="a",
            },
             new Course()
            {
                CourseId = 2,
                Description= "a",
                Name="b",
            },
              new Course()
            {
                CourseId = 3,
                Description= "a",
                Name="c",
            },
        };
        public IHttpActionResult get()
        {
            return Ok(courses);
        }
        public IHttpActionResult Post()
        {
            courses.Add(new Course()
            {
                CourseId = 4,
                Description = "a",
                Name = "d",
            });
            return Ok(courses);
        }
        public IHttpActionResult Puta(int id , Course c)
        {
            courses[id] = c;
            return Ok(courses);
        }
        public IHttpActionResult Delete(int id)
        {
          
            courses.RemoveAt(id);
            return Ok(courses);
        }
    }
}
