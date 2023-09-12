namespace Alchemy.Services;


public interface IAddRobotService
{

    public Robot CreateRobot(string name, string poids, string country);

    public List<Robot> ListRobots();

    public Robot GetRobotById(int id);

    public void DeleteRobot(int id);

    // a mthode to return a random element in the list
    public string RandomFromList(List<string> mylist);

    // a mthode to generate a random robot with random infos
    public  Robot? GetRobotByNameWithRandomInfos(string? Name);
}