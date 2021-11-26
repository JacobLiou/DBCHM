﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocTools.Dtos
{
    public class SqlCode
    {
        public string DBType { get; set; }

        public string CodeName { get; set; }

        public string Content { get; set; }

        public string StyleContent
        {
            get
            {
                return JS.RunStyleSql(Content?.Trim(), DBType);
            }
        }
    }
}
