using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBlog.Models.ORM.Entity
{
    public class BaseEntity
    {
        public int ID { get; set; }

        private DateTime _addDate { get; set; }
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }


        private bool _isDeleted = false;

        public bool isDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        }

        public DateTime DeleteDate { get; set; }


    }
}