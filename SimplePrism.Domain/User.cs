﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrism.Domain
{
    class User
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string Account { get; set; }

        public string PasswordHash { get; set; }

    }
}
