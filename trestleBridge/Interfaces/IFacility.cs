namespace trestleBridge.Interfaces
{
    public interface IFacility<T>
    {
        double Capacity { get; }

        void AddResource(T resource);

    }
}