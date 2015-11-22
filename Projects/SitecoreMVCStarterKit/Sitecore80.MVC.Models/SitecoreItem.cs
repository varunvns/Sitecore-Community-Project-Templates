using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Globalization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore80.MVC.Models
{
    public partial interface ISitecoreItem
    {

        [SitecoreId]
        Guid Id { get; }

        [SitecoreInfo(SitecoreInfoType.Language)]
        Language Language { get; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        int Version { get; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        string ItemName { get; set; }

        [SitecoreInfo(SitecoreInfoType.FullPath)]
        string FullPath { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateName)]
        string TemplateName { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        Guid TemplateId { get; set; }

        [SitecoreInfo(SitecoreInfoType.Url)]
        string Url { get; set; }

        [SitecoreChildren(IsLazy = true, InferType = true)]
        IEnumerable<ISitecoreItem> Children { get; set; }

        [SitecoreParent(IsLazy = true, InferType = true)]
        ISitecoreItem Parent { get; set; }
    }

    [DebuggerDisplay("{FullPath}")]
    public abstract partial class SitecoreItem : ISitecoreItem
    {
        //[SitecoreId]
        public virtual Guid Id { get; set; }

        [SitecoreInfo(SitecoreInfoType.Language)]
        public virtual Language Language { get; set; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        public virtual int Version { get; set; }

        [SitecoreInfo(SitecoreInfoType.Url)]
        public virtual string Url { get; set; }

        [SitecoreInfo(SitecoreInfoType.FullPath)]
        public virtual string FullPath { get; set; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        public virtual string ItemName { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateName)]
        public virtual string TemplateName { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        public virtual Guid TemplateId { get; set; }

        [SitecoreChildren(IsLazy = true, InferType = true)]
        public virtual IEnumerable<ISitecoreItem> Children { get; set; }

        [SitecoreParent(IsLazy = true, InferType = true)]
        public virtual ISitecoreItem Parent { get; set; }
    }
}
