using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalWebsiteBknd.Models; //Import the model I created

namespace PersonalWebsiteBknd.Controllers
{
    [Route("api/[controller]")] // specify that the api coute should be named after the controller ∴ skillscontroller to /spi/skills
    public class SkillsController : Controller
    {
        Skill[] skills = new Skill[] // create a new variable thatis a list of skills
        {
           new Skill {
           SkillName = "Golang",
           SkillDescription = "Go is the best!",
           SkillImage = null
           },
           new Skill {
           SkillName = "Python",
           SkillDescription = "and yet, somehow, Python is better",
           SkillImage = null
           }
        }; //spoofed data

        public IEnumerable<Skill> Get()//return an IEnumerable type with a get request
        {

            return skills;
        }
    }
}
