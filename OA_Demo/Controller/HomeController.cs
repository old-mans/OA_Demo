using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using OA_Demo.Helper;

namespace OA_Demo.Controller
{
    /// <summary>
    /// 主页
    /// </summary>
    [Produces("application/json")]
    [Route("api/Home/[action]")]
    [ApiController]
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        // GET: api/Home
        [HttpPost(Name = "login")]
        public JsonResult login([FromBody] Users users)
        {
            //var data = new JsonResult();
            if (users.UserName != "" || users.UserPwd != "")
            {
                var data = new { id = 1, name = "123" };
                return Json(ReturnStd.Success(data));
            }
            return Json(new { erry ="200" });
        }
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        // GET: api/Home
        [HttpPost(Name = "get")]
        public JsonResult getlist()
        {
            var data = new Adept {
                AdeptID = 1,
                AdeptName="123",
            };
            return Json(ReturnStd.Success(data));
        }
    }
}
