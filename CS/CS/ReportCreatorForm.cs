using System;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using DevExpress.XtraReports.UI;

namespace ThreadingReport {
    public class ReportCreatorForm : System.Windows.Forms.Form {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Timer timerAutoClose;
        private System.ComponentModel.IContainer components;

        public static void CreateReport(Type reportType) {
            ReportCreatorForm form = new ReportCreatorForm(reportType);
            form.Show();
        }

        private ReportCreatorForm(Type reportType) {
            if (reportType == null || !reportType.IsSubclassOf(typeof(XtraReport)))
                throw new Exception("An XtraReport type expected");
            this.reportType = reportType;
            InitializeComponent();
            Text = Application.ProductName;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.timerAutoClose = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creating a report.  Please wait.";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(240, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 20);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // timerAutoClose
            // 
            this.timerAutoClose.Interval = 500;
            this.timerAutoClose.Tick += new System.EventHandler(this.timerAutoClose_Tick);
            // 
            // ReportCreatorForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(404, 42);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportCreatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportCreatorForm";
            this.Load += new System.EventHandler(this.ReportCreatorForm_Load);
            this.ResumeLayout(false);

        }
        #endregion

        Thread thread;
        Type reportType;
        XtraReport report;

        public XtraReport Report {
            get {
                if (!IsReportReady)
                    return null;
                return report;
            }
        }

        public bool IsReportReady {
            get { return !thread.IsAlive && report != null; }
        }

        private void ReportCreatorForm_Load(object sender, System.EventArgs e) {
            thread = new Thread(new ThreadStart(CreateReport));
            thread.Start();
            timerAutoClose.Start();
        }

        void CreateReport() {
            ConstructorInfo ci = reportType.GetConstructor(Type.EmptyTypes);
            if (ci == null)
                throw new Exception("The report class does not have a default constructor");
            XtraReport r = ci.Invoke(null) as XtraReport;
            Thread.Sleep(0);
            r.CreateDocument();
            Thread.Sleep(0);
            report = r;
        }

        private void btnCancel_Click(object sender, System.EventArgs e) {
            if (this.thread.IsAlive) {
                this.timerAutoClose.Stop();
                this.thread.Abort();
                while ((this.thread.ThreadState & ThreadState.Aborted) == 0 &&
                    (this.thread.ThreadState & ThreadState.Stopped) == 0) {
                    Thread.Sleep(0);
                }
                this.Close();
            }
        }

        private void timerAutoClose_Tick(object sender, System.EventArgs e) {
            if (thread != null && (thread.ThreadState & ThreadState.Stopped) > 0) {
                timerAutoClose.Stop();
                Close();
                if (Report != null)
                    Report.ShowPreview();
            }
        }
    }
}
