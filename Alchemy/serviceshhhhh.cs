// namespace Alchemy.Services;


// public static class AddRobotService{
//     private static int nextId = 0;
//     private static Dictionary<int, Robot> dataBase = new Dictionary<int, Robot>();

//     private static int genNewId(){
//         nextId += 1;
//         return nextId - 1;
//     }

//     public static Robot CreateRobot(string name, string poids, string country){
//         int id = genNewId();
//         Robot robot = new(id, name, poids, country);
//         dataBase[id] = robot;
//         return robot;
//     }

//     public static List<Robot> ListRobots(){
//         return dataBase.Values.ToList();
//     }

//     public static Robot GetRobotById(int id){
//         return dataBase[id];
//     }

//     public static void DeleteRobot(int id){
//         dataBase.Remove(id);
//     }
// }