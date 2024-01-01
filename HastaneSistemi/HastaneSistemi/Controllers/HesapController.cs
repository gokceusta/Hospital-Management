using HastaneSistemi.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Security.Claims;

namespace HastaneSistemi.Controllers
{
    public class HesapController : Controller
    {
        SqlConnection connection;
        SqlDataReader reader;
        SqlCommand cmd;
        public IActionResult Giris()
        {
            return View();
        }
        

    }
}
