using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KV.Models
{
    public class Staff                              // Сотрудники
    {
        public int Id { get; set; }                 // id
        public string FirstName { get; set; }       // имя сотрудника
        public string LastName { get; set; }        // фамилия сотрудника
        public List<Task> Task { get; set; }        // задачи сотрудника
        public string Login { get; set; }           // логин сотрудника
        public string Password { get; set; }        // пароль сотрудника
    }
}