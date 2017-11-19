using System.Collections.Generic;
using VidlyProject.Models;

namespace VidlyProject.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}