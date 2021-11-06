using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI {
    interface Status {
        MainForm.Status GetStatus();
        void ToShow(MainForm.Status st);
    }
}
