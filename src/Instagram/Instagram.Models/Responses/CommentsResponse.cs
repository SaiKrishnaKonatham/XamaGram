﻿using System.Collections.Generic;

namespace Instagram.Models.Responses {
    public class CommentsResponse : IResponse {
        public Meta Meta { get; set; }
        public List<Comment> Data { get; set; }
    }
}
