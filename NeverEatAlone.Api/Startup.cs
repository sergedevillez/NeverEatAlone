#region Alias
using GlobalUser = NeverEatAlone.Models.Global.Entities.User;
using GlobalAuthRepository = NeverEatAlone.Models.Global.Repositories.AuthRepository;
using GlobalMeeting = NeverEatAlone.Models.Global.Entities.Meeting;
using GlobalMeetingRepository = NeverEatAlone.Models.Global.Repositories.MeetingRepository;
using GlobalFood = NeverEatAlone.Models.Global.Entities.Food;
using GlobalFoodRepository = NeverEatAlone.Models.Global.Repositories.FoodRepository;
using GlobalFoodType = NeverEatAlone.Models.Global.Entities.FoodType;
using GlobalFoodTypeRepository = NeverEatAlone.Models.Global.Repositories.FoodTypeRepository;
using GlobalHobby = NeverEatAlone.Models.Global.Entities.Hobby;
using GlobalHobbyRepository = NeverEatAlone.Models.Global.Repositories.HobbyRepository;

#endregion

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using NeverEatAlone.Api.Infrastructure.Security;
using NeverEatAlone.Models.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Tools.Connection;
using NeverEatAlone.Models.Client.Entities;
using NeverEatAlone.Models.Client.Repositories;

namespace NeverEatAlone.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddCors(c => c.AddPolicy("default", options => options.AllowAnyOrigin()));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "NeverEatAlone.Api", Version = "v1" });
            });
            //Ces intterfaces permettent d'accéder au méthodes sans devoir tout charger.
            services.AddSingleton<ITokenService, TokenService>();
            services.AddSingleton<IConnection, Connection>(Span => new Connection(SqlClientFactory.Instance, @"Data Source=DESKTOP-PJ4VH9N;Initial Catalog=NeverEatAlone.Database;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
            services.AddSingleton<IAuthRepository<GlobalUser>, GlobalAuthRepository>();
            services.AddSingleton<IAuthRepository<User>, AuthRepository>();

            services.AddSingleton<IMeetingRepository<GlobalMeeting>, GlobalMeetingRepository>();
            services.AddSingleton<IMeetingRepository<Meeting>, MeetingRepository>();

            services.AddSingleton<IHobbyRepository<GlobalHobby>, GlobalHobbyRepository>();
            services.AddSingleton<IHobbyRepository<Hobby>, HobbyRepository>();

            services.AddSingleton<IFoodRepository<GlobalFood>, GlobalFoodRepository>();
            services.AddSingleton<IFoodRepository<Food>, FoodRepository>();

            services.AddSingleton<IFoodTypeRepository<GlobalFoodType>, GlobalFoodTypeRepository>();
            services.AddSingleton<IFoodTypeRepository<FoodType>, FoodTypeRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "NeverEatAlone.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
