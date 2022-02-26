internal class RegCursor
{
	public string Name { get; }
	public string Path { get; }

	public RegCursor(string Name, string Path)
	{
		this.Name = Name;
		this.Path = Path;
	}
}
