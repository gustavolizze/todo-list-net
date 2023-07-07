using System;
namespace to_do_list.models
{
    public class ToDo
    {
        public String Name { get; private set; }
        public Boolean Finish { get; private set; }


        public ToDo(string name, bool finish)
        {
            this.Name = name;
            this.Finish = finish;
        }

        public void PendingTask()
        {
            this.Finish = false;
        }

        public void FinishTask()
        {
            this.Finish = true;
        }
    }
}

