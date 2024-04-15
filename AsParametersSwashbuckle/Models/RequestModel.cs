namespace AsParametersSwashbuckle.Models;

public class RequestModel
{
    public ConditionState? ConditionStateAsParameters { get; init; }
    public Guid? SomeId { get; set; }
    public string? SomeFilter { get; set; }
}
