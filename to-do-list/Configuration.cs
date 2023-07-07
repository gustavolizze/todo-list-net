using System;
using to_do_list.services;

namespace to_do_list
{
	public static class Configuration
	{

		public static WebApplicationBuilder AddServices(this WebApplicationBuilder builder)
		{
			builder.Services.AddSingleton<ToDoListService>();

			return builder;
		}
	}
}

