﻿using System;
namespace BSIT3L_Movies.Models
{
	public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rating { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public string Image {get; set; }
    }
}

