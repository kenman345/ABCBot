﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABCBot.ViewModels.GitHub
{
    public class IssueWebHookViewModel
    {
        public string Action { get; set; }
        public IssueViewModel Issue { get; set; }
    }
}
