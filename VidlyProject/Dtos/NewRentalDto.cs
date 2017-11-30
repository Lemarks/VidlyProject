using System.Collections.Generic;

namespace VidlyProject.Dtos
{
    public class NewRentalDto   
    {
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }
    }
}