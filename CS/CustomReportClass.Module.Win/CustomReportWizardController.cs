using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Reports;
using DevExpress.ExpressApp.Reports.Win;
using DevExpress.Persistent.Validation;

namespace CustomReportClass.Module.Win {    
    public partial class ReportWizardModifyController : ViewController {
        WinReportServiceController reportServiceController;
        public ReportWizardModifyController() { }
        protected override void OnActivated() {
            base.OnActivated();
            reportServiceController = Frame.GetController<WinReportServiceController>();
            reportServiceController.NewXafReportWizardShowing += reportServiceController_NewXafReportWizardShowing;
        }
        protected override void OnDeactivated() {
            reportServiceController.NewXafReportWizardShowing -= reportServiceController_NewXafReportWizardShowing;
            reportServiceController = null;
            base.OnDeactivated();
        }
        void reportServiceController_NewXafReportWizardShowing(object sender, NewXafReportWizardShowingEventArgs e) {
            if (!e.ReportDataType.Equals(typeof(CustomReportData))) return;
            CustomReportWizardParameters newReportParamsObject = new
                CustomReportWizardParameters(e.WizardParameters.Report);
            newReportParamsObject.ReportName = "Custom report name";
            newReportParamsObject.AdditionalInfo = "AdditionalInfo default value";
            e.WizardParameters = newReportParamsObject;
        }
    }
    [NonPersistent]
    public class CustomReportWizardParameters : NewXafReportWizardParameters {
        public CustomReportWizardParameters(XafReport report) : base(report) { }        
        public string AdditionalInfo {            
            get { return ((CustomXafReport)Report).AdditionalInfo; }
            set { ((CustomXafReport)Report).AdditionalInfo = value; }            
        }       
    }
}

