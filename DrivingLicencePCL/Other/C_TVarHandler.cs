using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicencePCL.Other
{
    public class C_TVarHandler<TSource>
    {
        private TSource _Data { get; set; }
        public TSource Data { get => _Data; set { subscribers.Invoke(this, _Data); _Data = value; } }

        public event EventHandler<TSource> subscribers;
    }
}
