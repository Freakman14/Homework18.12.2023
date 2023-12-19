

var post = new Post();
post.Text = "It is Post";
post.Likes = 1;
post.Comments = "Super";
post.Average = "Great";

System.Console.WriteLine(post.SetPost());
System.Console.WriteLine(post.AddLike());
System.Console.WriteLine(post.AddComment());
System.Console.WriteLine(post.GetInfo());



class Post
{
    public string Text;
    public string SetPost()
    {
        return $"Text = {Text}";
    }
    public int Likes;
    public string AddLike()
    {
        return $"Likes : {Likes + 1}";
    }
    public string Comments;
    public string AddComment()
    {
        return $"Comments : {Comments}";
    }
    public string Average;
    public string GetInfo()
    {
        return $"{Average}";
    }


}