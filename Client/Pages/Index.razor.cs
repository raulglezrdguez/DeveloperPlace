using Microsoft.AspNetCore.Components;
using DeveloperPlace.Shared;

namespace DeveloperPlace.Client;


public partial class Index : ComponentBase
{
    private State State { get; } = new State();

    protected override void OnInitialized()
    {
        State.DeveloperList.Add(new Developer(1, "Peter", 100, Levels.Trainee));
        State.DeveloperList.Add(new Developer(2, "Susan", 200, Levels.Junior));
        State.DeveloperList.Add(new Developer(3, "Ana", 300, Levels.Mid_level));
        State.DeveloperList.Add(new Developer(4, "Carl", 400, Levels.Senior));
        State.DeveloperList.Add(new Developer(5, "Elena", 500, Levels.Leader));
    }

    private string LevelImage(Levels level)
    {
        return $"images/${level.ToString().ToLower()}.png";
    }

    private void SelectDeveloper(Developer developer)
    {
        State.Group.Add(developer.Id);
    }
}