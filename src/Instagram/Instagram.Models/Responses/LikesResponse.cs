﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Instagram.Models.Responses {
    public class LikesResponse : IResponse {
        public Meta Meta { get; set; }
        public string Data { get; set; }
    }
}
