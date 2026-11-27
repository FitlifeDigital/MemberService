namespace MemberService.Api.Domain;

public class Member
{
    public Guid Id { get; }
    public string Name { get; }
    public Guid TrainerId { get; }
    private bool _hasConsent;

    public Member(Guid id, string name, Guid trainerId)
    {
        Id = id;
        Name = name;
        TrainerId = trainerId;
    }

    public void GiveConsent() => _hasConsent = true;

    public bool CanShareActivityWithTrainer() => _hasConsent;
}