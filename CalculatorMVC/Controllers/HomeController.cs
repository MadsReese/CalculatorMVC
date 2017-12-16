using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorMVC.Models;
using CalculatorLib;

namespace CalculatorMVC.Controllers
{
    public class HomeController : Controller
    {
		public IActionResult Index()
		{
			return View(new CalculateViewModel());
		}

		[HttpPost]
		public IActionResult Index(CalculateViewModel model)
		{
			if (ModelState.IsValid)
			{
				Calculator calc = new Calculator();
				model.Result = calc.Add(model.FirstNumber, model.SecondNumber);
			}
			return View(model);
		}
	}
}
