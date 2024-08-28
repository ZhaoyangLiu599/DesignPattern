namespace DesignPattern.FilterPattern.Criteria;

public class CriteriaOld : ICriteria
{
    public List<Person> MeetCriteria(List<Person> persons)
    {
        return persons.Where(p => p.Old >= 50).ToList();
    }
}