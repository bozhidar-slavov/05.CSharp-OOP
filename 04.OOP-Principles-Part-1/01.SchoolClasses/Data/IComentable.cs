namespace School.Data
{
    public interface IComentable
    {
        string Comment { get; }

        void MakeComment(string text);
    }
}
