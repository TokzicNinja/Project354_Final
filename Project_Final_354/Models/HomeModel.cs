using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Final_354.Models
{
    public class HomeModel
    {
        public class ViewModel
        {
            //Basically what I'm trying to do is link all the models into one page,
            //so I can be able to work with multiple models in one controller
            public List<Project_Final_354.Game> Games{get;set;}
            public List<Project_Final_354.Client> Client { get; set; }
        }
    }
}