//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MediaDashboard.Persistence.Storage
{
    using System;
    using System.Collections.Generic;
    
    public partial class ArchiveAlert
    {
        public string SubscriptionName { get; set; }
        public string AccountName { get; set; }
        public string AlertTypeName { get; set; }
        public string ChannelID { get; set; }
        public string ProgramID { get; set; }
        public string ProgramName { get; set; }
        public System.DateTime AlertDate { get; set; }
        public System.TimeSpan AlertTime { get; set; }
        public string TrackID { get; set; }
        public string StreamID { get; set; }
        public string MetricType { get; set; }
        public string MetricName { get; set; }
        public string ErrorLevel { get; set; }
        public Nullable<decimal> AlertValue { get; set; }
        public string Details { get; set; }
        public int AlertID { get; set; }
    }
}
