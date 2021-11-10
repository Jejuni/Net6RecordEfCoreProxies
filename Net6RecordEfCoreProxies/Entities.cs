namespace Net6RecordEfCoreProxies;

public class MyEntity
{
    public Guid Id { get; set; }
    public virtual MyRecord MyRecord { get; init; }
}

public record MyRecord : MyBaseRecord
{
    public int MyInt { get; init; }
}

public record MyBaseRecord
{
}