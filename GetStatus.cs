using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI {
    interface VEInter {
        MainForm.Status GetStatus();
        MainForm.Status OnStatus();
        void ToShow(MainForm.Status st);
    }
}
