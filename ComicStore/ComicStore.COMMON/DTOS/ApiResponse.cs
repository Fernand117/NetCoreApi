﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ComicStore.COMMON.DTOS
{
    public class ApiResponse
    {
        public Response ResponseCode { get; set; }
        public string ResponseText { get; set; }
        public object Data { get; set; }
    }
}
