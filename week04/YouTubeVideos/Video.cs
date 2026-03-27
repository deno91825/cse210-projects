
    public class Video
    {
        private string _title;
        private string _author;
        private int _length; // in seconds
        private List<Comment> _comments;

        // Constructor
        public Video(string title, string author, int length)
        {
            _title = title;
            _author = author;
            _length = length;
            _comments = new List<Comment>();
        }

        // Properties (getters)
        public string Title
        {
            get { return _title; }
        }

        public string Author
        {
            get { return _author; }
        }

        public int Length
        {
            get { return _length; }
        }

        // Add comment
        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        // Get number of comments
        public int GetNumberOfComments()
        {
            return _comments.Count;
        }

        // Display all comments
        public void DisplayComments()
        {
            foreach (Comment c in _comments)
            {
                Console.WriteLine($"- {c.Commenter}: {c.Text}");
            }
        }
    }
