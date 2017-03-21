using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KV.Models
{
    public class TaskStatus                     // Справочник статусов задач
    {
        public int Id { get; set; }
        public string Name { get; set; }        // Наименование статуса - новая, в работе, исполнена
    }
}