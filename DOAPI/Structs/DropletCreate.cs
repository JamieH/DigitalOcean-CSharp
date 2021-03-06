﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalOcean.Structs
{
    public class CreatedDroplet
        {
            public int id { get; set; }
            public string name { get; set; }
            public int image_id { get; set; }
            public int size_id { get; set; }
            public int event_id { get; set; }
        }

    public class CreateDropletStatus
        {
            public string status { get; set; }
            public CreatedDroplet droplet { get; set; }
        }
}
