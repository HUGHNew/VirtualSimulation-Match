namespace GUI {
    internal interface IVEInter {
        /// <summary>
        /// get current status
        /// </summary>
        MainForm.Status GetStatus();
        /// <summary>
        /// get the status if this form is on
        /// </summary>
        MainForm.Status OnStatus();
        /// <summary>
        /// set form status and show itself
        /// </summary>
        void ToShow();
        //[Obsolete]
        //void ToShow(MainForm.Status st);
    }
    internal interface IQTag {
        void TextLoad();
        void SetFile(string file);
    }
    internal interface IVariableOptionPanel {
        void LoadContent(string path);
        bool IsCorrect();
        void ButtonLoad(string path);
    }
}
