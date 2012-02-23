﻿using System;
using Ninject;
using Ch.TimeTweet.Domain.Service.MasterData;
using Ch.TimeTweet.Domain.Entity.MasterData;

namespace Ch.TimeTweet.Infrastructure.Configuration.Setup
{
    public class Service : IConfiguration
    {
        public IKernel _ninjectKernel { get; set; }

        public Service(IKernel ninjectKernel)
        {
            _ninjectKernel = ninjectKernel;
        }

        public void Initialization()
        {
            // Set Service
            _ninjectKernel.Bind<ICompanyAppService<Company>>().To<CompanyAppService<Company>>().InRequestScope();                
        }
    }
}