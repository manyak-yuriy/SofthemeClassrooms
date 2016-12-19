﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementServices.Models
{
    public class RoomInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Capacity { get; set; }
        public bool IsBookable { get; set; }
    }
}
