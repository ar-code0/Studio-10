using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Extensions.Logging;
using SkillsTracker.Models;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        [HttpGet]
        [Route("/skills")]
        public IActionResult SkillsIndex()
        {
            string html = "<h1 style='background-color: purple; color: white; padding: 10px; text-align: center'>Skills Tracker</h1>" +
                             "<h2 style='background-color: rgb(169, 169, 169); color: white; padding: 5px; text-align: center'>Coding skills to learn</h2>" +
                             "<ul style='background-color: rgb(127, 255, 212); list-style-type:none;'>" +
                                 "<li style='padding: 5px; text-align: center'><b>C#</b></li>" +
                                 "<li style='padding: 5px; text-align: center'><b>JavaScript</b></li>" +
                                 "<li style='padding: 5px; text-align: center'><b>Python</b></li>" +
                             "</ul>";
            return Content(html, "text/html");
        }
        
        [HttpGet]
        [Route("/skills/form")]
        public IActionResult Form()
        {
            string html = "<div style='margin-left: 30%; margin-right: 30%; border: 2px grey solid; background-color: rgb(127, 255, 212);'>" +
                          "<form method='post' action='/skills/form/completed'>" +
                              "<div style='text-align: center; margin-top: 20px; margin-bottom: 20px'><label for='start'><span style='font-weight: bold;'>Date:</span></label><br><br>" +
                                    "<input type='date' name='date'>" +
                              "</div>" +
                              "<div style='text-align: center; margin-bottom: 20px'><span style='font-weight: bold;'>C#:</span><br><br>" +
                                  "<select name='csharp'>" +
                                    "<option value='learning-basics'>learning basics</option>" +
                                    "<option value='making-apps'>making apps</option>" +
                                    "<option value='master-coder'>master coder</option>" +
                                  "</select>" +
                              "</div>" +
                              "<div style='text-align: center; margin-bottom: 20px'><span style='font-weight: bold;'>JavaScript:</span><br><br>" +
                                  "<select name='javascript'>" +
                                    "<option value='learning-basics'>learning basics</option>" +
                                    "<option value='making-apps'>making apps</option>" +
                                    "<option value='master-coder'>master coder</option>" +
                                  "</select>" +
                              "</div>" +
                              "<div style='text-align: center; margin-bottom: 20px'><span style='font-weight: bold;'>Python:</span><br><br>" +
                                  "<select name='python'>" +
                                    "<option value='learning-basics'>learning basics</option>" +
                                    "<option value='making-apps'>making apps</option>" +
                                    "<option value='master-coder'>master coder</option>" +
                                  "</select>" +
                              "</div>" +
                              "<div style='text-align: center; margin-top: 20px; margin-bottom: 20px;'>" +
                                  "<input type='submit' style='font-weight: bold; color: white; background-color: purple; padding: 1x'>" +
                              "<div>" +
                            "</form>" +
                            "</div>";
            return Content(html, "text/html");
        }

        [HttpPost]
        [Route("/skills/form/completed")] // Bonus Mission
        public IActionResult Completed(string csharp, string javascript, string python, string date = "2020-07-17")
        {
            string html = "<h1 style='background-color: purple; color: white; padding: 10px; text-align: center'> " + date + "</h1>" +
                          "<ol style='background-color: rgb(127, 255, 212);'>" +
                              "<li style='padding: 5px;'><b>C#</b>: " + csharp + "</li>" +
                              "<li style='padding: 5px;'><b>JavaScript</b>: " + javascript + "</li>" +
                              "<li style='padding: 5px;'><b>Python</b>: " + python + "</li>" +
                          "</ol>";
            return Content(html, "text/html");
        }
    }
}
