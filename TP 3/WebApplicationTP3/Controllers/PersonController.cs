﻿using Microsoft.AspNetCore.Mvc;
using System.Data.SQLite;
using WebApplicationTP3.Models;

namespace WebApplicationTP3.Controllers
{
	public class PersonController : Controller
	{
		[Route("/Person")]
		[Route("Person/All")]
		public IActionResult All()
		{
			SQLiteConnection dbcon = new SQLiteConnection("Data Source=.\\2022 GL3 .NET Framework TP3 - SQLite database.db;");
			return View(Personal_info.GetAllPerson(dbcon));
		}
		[Route("Person/{id?}")]
		public IActionResult GetById(int id)
		{
			SQLiteConnection dbcon = new SQLiteConnection("Data Source=.\\2022 GL3 .NET Framework TP3 - SQLite database.db;");
			return View(Personal_info.GetPerson(id, dbcon));
		}
		[Route("Person/Search")]
		public IActionResult Search()
		{
			return View();
		}
	}
}
