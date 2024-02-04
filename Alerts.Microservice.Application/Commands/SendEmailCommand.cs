﻿using Alerts.Microservice.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Alerts.Microservice.Application.Commands
{
    public class SendEmailCommand:IRequest<bool>
    {
        public EmailDto email{ get; set; }
    }
}
