namespace MLSGrid
{
    /// <summary>
    /// Interface that identifies all entities returned by Stripe.
    /// </summary>
    public interface IGridEntity
    {
        GridResponse GridResponse { get; set; }
    }
}
