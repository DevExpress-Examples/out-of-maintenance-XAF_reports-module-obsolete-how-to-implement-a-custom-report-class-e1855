using DevExpress.ExpressApp.Reports;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DevExpress.XtraReports.Serialization;

namespace CustomReportClass.Module {
    [DevExpress.XtraReports.RootClass]
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
        public string CustomProperty { get; set; }
    }
}
