using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KV.Models
{
    public class Task                               // Задача
    {
        public int Id { get; set; }                 // id
        public string Name { get; set; }            // краткое название задачи
        public string Desription { get; set; }      // описание задачи
        public int StatusId { get; set; }           // статус задачи
        public TaskStatus Status { get; set; }      // статус по справочнику TaskStatus  
         
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreateDate { get; set; }    // Дата создания

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }     // Дата начала выполнения

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }       // Дата окончания выполнения
    }
}
