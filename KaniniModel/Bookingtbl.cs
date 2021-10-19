using System;
using System.Collections.Generic;

#nullable disable

namespace MovieApi.KaniniModel
{
    public partial class Bookingtbl
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        public string MoviePoster { get; set; }
    }
}
