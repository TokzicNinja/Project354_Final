using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Project_Final_354.Models
{
    public class HomeModel
    {
        //public class ViewModel
        //{
            //Basically what I'm trying to do is link all the models into one page,
            //so I can be able to work with multiple models in one controller
            //public List<Project_Final_354.Game> Games{get;set;}
            //public List<Project_Final_354.Client> Client { get; set; }

            
            public IEnumerable<Client> client { get; set; }
            public IEnumerable<Game> game { get; set; }
            public IEnumerable<GameGenre> gameGenre { get; set; }
            
        //}
    }
}