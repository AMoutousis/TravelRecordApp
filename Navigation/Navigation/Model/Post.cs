using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Navigation.Model
{
    public class Post
    {
        [PrimaryKey, AutoIncrement]
        public int _id { get; set; }
        [MaxLength(250)]
        public string _experience { get; set; }


    }
}
