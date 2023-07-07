using System;
using to_do_list.models;

namespace to_do_list.services
{
	public class ToDoListService
	{

		private List<ToDo> List { get; set; }


		public ToDoListService()
		{
			this.List = new List<ToDo>();
		}


		public void FinishTask(String taskName)
		{
			this.List = this.List.Select(c => {
				if (c.Name == taskName)
					c.FinishTask();

				return c;
			}).ToList();
		}

		public void AddPendingTask(String task)
		{
			this.List.Add(new ToDo(task, false));
		}

		public void AddFinishedTask(String task)
		{
			this.List.Add(new ToDo(task, true));
		}

		public List<ToDo> Get()
		{
			return this.List;
		}
	}
}

