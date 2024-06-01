using ePizzaDelivery.Entities;
using ePizzaDelivery.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizzaDelivery.Services.Implementations
{
    public class AuthenticationService : IAuthenticationService
    {
        protected SignInManager<User> _signInManger;
        protected UserManager<User> _userManager;
        protected RoleManager<Role> _roleManager;
        public AuthenticationService(SignInManager<User> signInManager,UserManager<User> userManager,RoleManager<Role> roleManager)
        {
            _signInManger = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public User AuthenticateUser(string Username, string Password)
        {
            var result = _signInManger.PasswordSignInAsync(Username, Password, false, lockoutOnFailure: false).Result;
            if (result.Succeeded)
            {
                var user = _userManager.FindByNameAsync(Username).Result;
                var roles = _userManager.GetRolesAsync(user).Result;
                user.Roles = roles.ToArray();
                return user;
            }
            return null;
        }

        public bool CreateUser(User user, string Password)
        {
            var result=_userManager.CreateAsync(user,Password).Result;
            if (result.Succeeded)
            {
                //Admin, user (adding the user with Admin role.)
                string role = "Admin";
                var res = _userManager.AddToRoleAsync(user, role).Result;
                if (res.Succeeded)
                {
                    return true;
                }
            }
            return false;
        }

        public User GetUser(string Username)
        {
            return _userManager.FindByNameAsync(Username).Result;
        }

        public async Task<bool> SignOut()
        {
            try
            {
                await _signInManger.SignOutAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
