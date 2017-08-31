using APIExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIExample.Controllers
{
    public class SampleController : ApiController
    {
        [HttpGet]
        [Route("api/sample/get")]
        //get localhost:56560/get?id=1&name=brinda
        public string Get(int id,string name)
        {
            return id + " " + name;
        }
        [HttpPost]
        [Route("api/sample/post")]
        //post localhost:56560/post
        //[FromBody]Student stud
        public Student Post([FromUri]int id)
        {
            List<Student> studList = new List<Student>(){
                new Student() {ID=1,Name="brinda",Marks=45 },
                new Student() {ID=2,Name="anju",Marks=46 },
                new Student() {ID=3,Name="linda",Marks=41 },
                new Student() {ID=4,Name="meenu",Marks=46 }
            };
            foreach(Student student in studList)
            {
                if (student.ID == id)
                    return student;
            }
            return null;
        }
        [HttpPut]
        [Route("api/sample/update")]
        //put localhost:56560/update
        public Student Update()
        {
            Student student = new Student();
            student.ID = 1;
            student.Name = "Brinda";
            student.Marks = 45;
            return student;
        }
        [HttpDelete]
        [Route("api/sample/delete")]
        //delete localhost:56560/delete
        public Student Delete()
        {
            Student student = new Student();
            student.ID = 1;
            student.Name = "Brinda";
            student.Marks = 45;
            return student;
        }
    }
}
