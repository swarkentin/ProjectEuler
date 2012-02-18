namespace ProjectEuler
{
    internal interface IProblem
    {
        string Name { get; }
        string Description { get; }
        string Execute();
    }
}