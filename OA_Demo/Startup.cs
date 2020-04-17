using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace OA_Demo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            #region ע��Swagger����
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API Demo", Version = "v1" });
                // ��ȡxml�ļ���
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                // ��ȡxml�ļ�·��
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                // ��ӿ�������ע�ͣ�true��ʾ��ʾ������ע��
                c.IncludeXmlComments(xmlPath, true);
            });
            services.AddControllers();
            #endregion
            services.AddControllersWithViews().AddNewtonsoftJson();
            #region CORS
            //�����һ�ַ�������ע������������ԣ�Ȼ�����±�app�����ÿ����м��
            services.AddCors(c =>
            {
                //һ��������ַ���
                c.AddPolicy("LimitRequests", policy =>
                {
                    policy
                    .WithOrigins("http://127.0.0.1:1818", "http://localhost:8080", "http://localhost:8021", "http://localhost:8081", "http://localhost:1818")//֧�ֶ�������˿ڣ�ע��˿ںź�Ҫ��/б�ˣ�����localhost:8000/���Ǵ�� 
                    .AllowAnyHeader()//Ensures that the policy allows any header.
                    .AllowAnyMethod();
                });
            });

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            #region Swagger�м��
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Demo v1");
            });
            #endregion
            app.UseRouting();
            #region Cors ��������
            app.UseCors("LimitRequests");
            // ��תhttps ��Httpsʱʹ��
            //app.UseHttpsRedirection();
            //ʹ�þ�̬�ļ�
            app.UseStaticFiles();
            //ʹ��cookie
            app.UseCookiePolicy();
            // ���ش�����
            app.UseStatusCodePages();//�Ѵ����뷵��ǰ̨��������404
            #endregion
            //������ʼҳ
            app.UseStaticFiles();
            app.Run(ctx =>
            {
                ctx.Response.Redirect("/swagger/"); //����֧������·������index.html������ʼҳ.
                return Task.FromResult(0);
            });
     

        }
    }
}
