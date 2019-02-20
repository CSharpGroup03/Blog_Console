namespace SocialNetwork
{
    public class Comment : BaseComment
    {
        public string Text { get; set; }

        public Comment(string _text)
        {
            this.Text = _text;
        }

        public override BaseComment Clone()
        {
            System.Console.WriteLine(this.Text);

            return this.MemberwiseClone() as BaseComment;
        }
    }
}