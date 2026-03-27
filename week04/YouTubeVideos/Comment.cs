
    public class Comment
    {
        private string _commenter;
        private string _text;

        // Constructor
        public Comment(string commenter, string text)
        {
            _commenter = commenter;
            _text = text;
        }

        // Properties (getters)
        public string Commenter
        {
            get { return _commenter; }
        }

        public string Text
        {
            get { return _text; }
        }
    }
