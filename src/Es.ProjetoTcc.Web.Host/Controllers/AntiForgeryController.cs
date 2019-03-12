using Microsoft.AspNetCore.Antiforgery;
using Es.ProjetoTcc.Controllers;

namespace Es.ProjetoTcc.Web.Host.Controllers
{
    public class AntiForgeryController : ProjetoTccControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
