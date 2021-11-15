namespace GUI {
    public class VariablePanelFactory {
        public static VariableBasePanel Create(string AnswerFile) {
            char[] sep = { ',' };
            VariableBasePanel Base;
            string ca=System.IO.File.ReadAllLines(AnswerFile)[0];
            string[] answer=ca.Split(sep);
            if (answer.Length == 1) {
                Base = new VariableSelectPanel();
            } else {
                Base = new VariableCheckPanel();
            }
            return Base;
        }
    }
}
