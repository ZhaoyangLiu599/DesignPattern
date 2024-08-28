namespace DesignPattern.FilterPattern.Criteria;

public class CriteriaMale : ICriteria
{
    public List<Person> MeetCriteria(List<Person> persons)
    {
        return persons.Where(p => p.Gender.Equals("male", StringComparison.OrdinalIgnoreCase)).ToList();
    }
}