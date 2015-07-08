using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyApp
{
    class Members
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Password { get; set; }

    }
}
