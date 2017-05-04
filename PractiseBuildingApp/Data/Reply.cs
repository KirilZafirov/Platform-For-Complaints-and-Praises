using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PractiseBuildingApp.Data
{
    public class Reply
    {
        public virtual int Id { get; set; }
        public virtual string Body { get; set; }
        public virtual DateTime Created { get; set; }
        public virtual int TopicId { get; set; }

    }
}