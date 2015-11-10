using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRMVC.Models
{
    public class EventRepertory
    {
        private int _nextId = 1;
        List<Event> events=new List<Event>(); 
        public EventRepertory()
        {
            Add(new Event()
            {
                Name = "ant",
                Desc = "hello word",
            });
            Add(new Event()
            {
                Name = "ant",
                Desc = "最新版spring ide for eclipse在线安装方法"
            });
        }

        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Event Add(Event model)
        {
            if (model!=null)
            {
                model.Id = _nextId++;
                model.Time = DateTime.Now;
                events.Add(model);
            }
            return model;
        }
    }
}