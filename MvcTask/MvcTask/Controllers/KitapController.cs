using Microsoft.AspNetCore.Mvc;
using MvcTask.Models;
using MvcTask.Models.KitYaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTask.Controllers
{
    public class KitapController : Controller
    {
        public IActionResult Goster()
        {
                Kitap Kitap = new Kitap()
                {
                    kitID=1,
                    kitAd="Türklerin Tarihi"
                };
                
                Yazar yazar = new Yazar()
                {
                    yazID=1,
                    yazAd="İlber Ortaylı"
                };


            KitYaz kityaz = new KitYaz()
            {
                Yazar = yazar,
                Kitap = Kitap
            };

                return View(kityaz);
            
        }
    }
}
