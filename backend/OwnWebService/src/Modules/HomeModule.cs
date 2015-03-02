﻿/*
 * Created by SharpDevelop.
 * User: durane
 * Date: 2/17/2015
 * Time: 4:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nancy;
using Nancy.ModelBinding;  // for JSON magic
using Nancy.Responses;

namespace OHWebService
{
	/// <summary>
	/// Description of HomeModule.
	/// </summary>
	public class HomeModule : Nancy.NancyModule
	{
		const String IndexPage = @"
				<html><body>
				<h1>Yep. The server is running</h1>
				</body></html>
				";
		public HomeModule()
		{
			// http://localhost:8080/
//            Get["/"] = parameter =>
//            {
//				return IndexPage;
//            };
		 Get[@"/"] = parameters =>
		    {
		        //return Response.AsFile("index.html", "text/html");
		        return View["index"];
		    };
				    
		}
	}
}
