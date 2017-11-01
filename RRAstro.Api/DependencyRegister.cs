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
            services.AddScoped<RRAstro.Core.Interface.Repository.KundaliReq.IKundaliReqRepository
               , RRAstro.Repository.KundaliReq.KundaliReqRepository>();
            services.AddScoped<RRAstro.Core.Interface.Application.KundaliReq.IKundaliReqApplication
                , RRAstro.Application.KundaliReq.KundaliReqApplication>();
            services.AddScoped<RRAstro.Core.Interface.Repository.GetColorStone.IColorStoneReqRepository
               , RRAstro.Repository.GetColorStone.ColorStoneReqRepository>();
            services.AddScoped<RRAstro.Core.Interface.Application.GetColorStone.IColorStoneReqApplication
                , RRAstro.Application.GetColorStone.ColorStoneReqApplication>();
            services.AddScoped<RRAstro.Core.Interface.Repository.BookApp.IBookAppointmentRepository
               , RRAstro.Repository.BookApp.BookAppointmentRepository>();
            services.AddScoped<RRAstro.Core.Interface.Application.BookApp.IBookAppointmentApplication
                , RRAstro.Application.BookApp.BookAppointmentApplication>();
            return services;
        }

    }
}