using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ToDoList1.Models
{
    public class ToDoList1Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ToDoList1Context() : base("name=ToDoList1Context")
        {
        }

        public System.Data.Entity.DbSet<ToDoList1.Models.List> Lists { get; set; }

        public System.Data.Entity.DbSet<ToDoList1.Models.Task> Tasks { get; set; }
    }
}
