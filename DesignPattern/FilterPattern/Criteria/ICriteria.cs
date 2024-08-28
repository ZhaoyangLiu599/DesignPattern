namespace DesignPattern.FilterPattern.Criteria;

public interface ICriteria
{
    List<Person> MeetCriteria(List<Person> persons);
}