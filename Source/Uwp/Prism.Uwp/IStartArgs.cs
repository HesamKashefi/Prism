namespace Prism.Uwp
{
    public interface IStartArgs
    {
        object Arguments { get; }
        int StartCause { get; }
        StartKinds StartKind { get; }
    }
}
