using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using DevExpress.ExpressApp;

namespace CustomReportClass.Module.Win {
    [ToolboxItemFilter("Xaf.Platform.Win")]
    public sealed partial class CustomReportClassWindowsFormsModule : ModuleBase {
        public CustomReportClassWindowsFormsModule() {
            InitializeComponent();
        }
    }
}
