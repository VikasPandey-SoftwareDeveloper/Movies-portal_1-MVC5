﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movies_portal_MVC5.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
    }
}