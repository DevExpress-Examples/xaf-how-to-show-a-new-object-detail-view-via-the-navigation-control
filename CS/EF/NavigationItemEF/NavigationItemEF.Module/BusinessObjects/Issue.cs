using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationItemEF.Module.BusinessObjects {
    [DefaultClassOptions, ImageName("BO_List")]
    public class Issue : BaseObject {
        public virtual string Subject { get; set; }
        [FieldSize(FieldSizeAttribute.Unlimited)]
        public virtual string Description { get; set; }
    }
}
