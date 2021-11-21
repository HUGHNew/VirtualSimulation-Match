using System;
using System.Windows.Forms;

namespace GUI {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Form tf = new TransparentLableForm("测试再试试 再长点看看 再长点", System.Drawing.Color.Blue) {
            //    Location = new System.Drawing.Point(100, 100)
            //};
            //Application.Run(tf);
            //Application.Run(new Appraisal());
            //Application.Run(new Content());
            Application.Run(new MainForm());
            //Application.Run(new QuestionBoard());
            //Application.Run(new Crops());
        }
    }
}
