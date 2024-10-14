﻿using LANCommander.Server.Data;
using LANCommander.Server.Data.Models;
using Microsoft.Extensions.Logging;

namespace LANCommander.Server.Services
{
    public class CompanyService : BaseDatabaseService<Company>
    {
        public CompanyService(
            ILogger<CompanyService> logger,
            Repository<Company> repository) : base(logger, repository) { }
    }
}
