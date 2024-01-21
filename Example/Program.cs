// See https://aka.ms/new-console-template for more information
using Example;
using Example.Extensions;
using Newtonsoft.Json;

var personalJson = JsonConvert.DeserializeObject<IList<Personal>>(Datas.PersonalJson);
var studentJson = JsonConvert.DeserializeObject<IList<Student>>(Datas.StudentJson) ;
var jobberJson = JsonConvert.DeserializeObject<IList<Jobber>>(Datas.JobberJson);
IDictionary<string,IList<string>> indexes =new Dictionary<string,IList<string>>();
IDictionary<string, IUser> fastList = new Dictionary<string, IUser>();


fastList.AddToDictionary(jobberJson.Select(user=>(user as IUser)).ToList(),indexes);
var findAll = FindByIndex("Pirnie");
findAll.ToList().ForEach(user => Console.WriteLine("\n" + JsonConvert.SerializeObject(user)));
Console.ReadKey();



//var findedListWithPredicate= JobberJson.FindAll(user => user.FirstName == "Weekley" || user.LastName == "Weekley");



IList<IUser>? FindByIndex(string search)
{
    
    if (indexes.ContainsKey(search))
    {
        var findedKeys=indexes[search];
        return findedKeys.Select(key => fastList[key]).ToList();
    }
    return null;
}
