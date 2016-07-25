namespace Dealership.Models
{
    using Common;
    using Contracts;

    public class Comment : IComment
    {
        private string content;

        public Comment(string content)
        {
            this.Content = content;
        }

        public string Author { get; set; }

        public string Content
        {
            get { return this.content; }

            protected set
            {
                Validator.ValidateNull(value, "Content cannot be null!");

                this.content = value;
            }
        }
    }
}
