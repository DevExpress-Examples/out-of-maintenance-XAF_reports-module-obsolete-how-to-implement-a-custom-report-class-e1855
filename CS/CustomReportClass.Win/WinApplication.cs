using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp;

namespace CustomReportClass.Win {
    public partial class CustomReportClassWindowsFormsApplication : WinApplication {
        public CustomReportClassWindowsFormsApplication() {
            InitializeComponent();
        }
        private void CustomReportClassWindowsFormsApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
            e.Updater.Update();
            e.Handled = true;
        }
    }
}
