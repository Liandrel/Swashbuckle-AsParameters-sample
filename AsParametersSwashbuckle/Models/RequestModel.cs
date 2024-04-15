namespace AsParametersSwashbuckle.Models;

public class RequestModel
{
    public ConditionState? conditionStateAsParameters { get; init; }
    public Guid? SomeId { get; set; }
    public string? SomeFilter { get; set; }
}
