using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRAstro.Api
{
    public static class DependencyRegister
    {
        public static IServiceCollection RegisterDependencies(this IServiceCollection services)
        {
            services.AddScoped<RRAstro.Core.Interface.Repository.QuestionAns.IQuestionTopicRepository
                , RRAstro.Repository.QuestionAns.QuestionTopicRepository>();
            services.AddScoped<RRAstro.Core.Interface.Application.QuestionAns.IQuestionTopicApplication
                , RRAstro.Application.QuestionAns.QuestionTopicApplication>();

            return services;
        }

    }
}