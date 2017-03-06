using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID_example.Examples
{
    interface IWorker
    {
        void Work();
        void Eat();
    }
    class Worker : IWorker
    {
        public void Work()
        {
        }
        public void Eat()
        {
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
        }
        public void Eat()
        {
            throw new NotImplementedException();
        }
    }

    interface IWorkable
    {
        void Work();
    }
    interface IFeedable
    {
        void Eat();
    }
    class Workerv2 : IWorkable, IFeedable
    {
        public void Work()
        {
        }
        public void Eat()
        {
        }
    }
    class Robotv2 : IWorkable
    {
        public void Work()
        {
        }
    }
}
