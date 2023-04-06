﻿using Consultancy_Project.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Entity.Concrate
{
    public class Certificate:IBaseEntity
    {
        public string Id { get; set; }
        public string Institution { get; set; }
        public string CertificateName { get; set; }
        public DateTime CertificateTime { get; set; }
    }
}
