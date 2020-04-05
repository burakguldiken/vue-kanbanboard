using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using kanbanboard.api.Models;
using kanbanboard.core.Entity;
using kanbanboard.core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace kanbanboard.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : BaseController
    {
        #region Variables
        IUser _SUser;
        IMenu _SMenu;
        #endregion
        #region Constructor
        public UserController(IMethod _SMethod,
            IUser _SUser,IMenu _SMenu)
           : base(_SMethod)
        {
            this._SMethod = _SMethod;
            this._SUser = _SUser;
            this._SMenu = _SMenu;
        }
        #endregion
        #region User      
        /// <summary>
        /// Kullanıcı Giriş İşlemi İçin Kullanılır.
        /// </summary>
        /// <param name="user">E-Posta ve Şifre Yeterlidir.</param>
        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody]User user)
        {
            BaseResult<UserModel> baseResult = new BaseResult<UserModel>();
            string passwordMd5 = _SMethod.Md5Password(user.password);
            User _user = _SUser.CheckUser(user.email, passwordMd5);
            if (_user != null)
            {
                baseResult.data.user = _user;
                List<Menu> menus = _SMenu.GetUserMenus().Where(x => x.isShow == 2).OrderBy(x => x.priority).ToList();
                if(menus.Count != 0)
                {
                    baseResult.data.menus = menus;
                    baseResult.data.token = Generate_Token(_user.id.ToString());
                    return Json(baseResult);
                }
                else
                {
                    baseResult.errorMessage = "Menüler Yüklenirken Bir Hatayla Karşılaşıldı";
                    return new NotFoundObjectResult(baseResult);
                }
            }
            else
            {
                baseResult.errorMessage = "Kullanıcı Adı veya Şifreniz Hatalı !";
                return new NotFoundObjectResult(baseResult);
            }

        }
        #endregion

        #region JWT
        [NonAction]
        private string Generate_Token(string userId)
        {
            var someClaims = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.UniqueName,userId),
                new Claim(JwtRegisteredClaimNames.Email,userId),
                new Claim(JwtRegisteredClaimNames.NameId,Guid.NewGuid().ToString()),
            };

            SecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("KanbanBoardProject"));
            var token = new JwtSecurityToken(
                claims: someClaims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256)
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        #endregion
    }
}