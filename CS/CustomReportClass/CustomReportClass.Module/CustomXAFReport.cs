using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.ExpressApp.Reports;
using DevExpress.Xpo;
using DevExpress.XtraReports;
using DevExpress.XtraReports.Serialization;
using DevExpress.Persistent.Base;

namespace CustomReportClass.Module {
    [RootClass]
    public class CustomXafReport : XafReport {
        protected string additionalInfo;
        public string AdditionalInfo {
            get { return additionalInfo; }
            set { additionalInfo = value; }
        }
        protected override void SerializeProperties(XRSerializer serializer) {
            base.SerializeProperties(serializer); 
            serializer.SerializeString("AdditionalInfo", AdditionalInfo);
        }
        protected override void DeserializeProperties(XRSerializer serializer) {
            base.DeserializeProperties(serializer);
            AdditionalInfo = serializer.DeserializeString("AdditionalInfo", string.Empty);
        }
    }
    [System.ComponentModel.DisplayName("Custom Report")]
    [NavigationItem("Reports")]
    public class CustomReportData : ReportData {
        public CustomReportData(Session session) : base(session) { }
        protected override XafReport CreateReport() {
            return new CustomXafReport();
        }
    }
}
