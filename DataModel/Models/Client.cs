using System;
using System.Collections.Generic;

namespace DataModel.Models
{
    public partial class Client
    {
        public int ClientID { get; set; }
        public int ClientMPI { get; set; }
        public string MCI { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
    }
}
