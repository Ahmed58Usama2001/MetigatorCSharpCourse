namespace StackAndQueue;

class Command
{
    private readonly DateTime _createdAt;
    private readonly string _url;

    public Command( string url)
    {
        _createdAt = DateTime.Now;
        _url = url;
    }

    public override string ToString()
    {
        return $"[{this._createdAt.ToString("yyyy-mm-dd hh:mm")} - {this._url}]";
    }
}
