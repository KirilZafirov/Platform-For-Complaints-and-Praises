using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PractiseBuildingApp.Data
{
    public class Topic
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Body { get; set; }
        public virtual DateTime Created { get; set; }
        public virtual ICollection<Reply> Replies { get; set; }

    }
}